using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;

namespace StashSorter
{
    public partial class Form1 : Form
    {
        SQLiteConnection sqlite_conn;
        List<scenes> scenelist;
        List<performers> perflist;
        List<studios> studlist;
        List<tags> taglist;
        public Form1()
        {
            InitializeComponent();
            scenelist = new List<scenes>();
            perflist = new List<performers>();
            studlist = new List<studios>();
            taglist = new List<tags>();

        }


        private void btBrowse_Click(object sender, EventArgs e)
        {
            var fDialog = new OpenFileDialog
            {
                Title = "Browse",
                InitialDirectory = @"C:\",
                Filter = "All files(*.*)|*.*|All files(*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };
            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = fDialog.FileName;
            }
        }

        private void tbConnect_Click(object sender, EventArgs e)
        {
            sqlite_conn = CreateConnection();
            GetListOfVideos(sqlite_conn);
            GetListOfPerformers(sqlite_conn);
            GetListOfStudios(sqlite_conn);
            GetListOfTags(sqlite_conn);
        }
        SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection(@"Data Source=" + tbPath.Text + "; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
                this.Text = "StashSorter *CONNECTED*";
            }
            catch (Exception ex)
            {
                this.Text = "StashSorter *NOT CONNECTED*";
                MessageBox.Show("Could not connect", "Not connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return sqlite_conn;
        }
        void GetListOfVideos(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "select scenes.path,scenes.id as sid, GROUP_CONCAT(performers.name) as performer, GROUP_CONCAT(performers.id) as pid, studios.name as studio, studios.id  as stid, tags.name as tagname, tags.id as tagid from scenes left join performers_scenes on performers_scenes.scene_id = scenes.id left join performers on performers.id = performers_scenes.performer_id left join studios on scenes.studio_id = studios.id left join scenes_tags on scenes_tags.scene_id = scenes.id left join tags on tags.id = scenes_tags.tag_id";
            if (cbhStudio.Checked)
            { sqlite_cmd.CommandText += " where scenes.studio_id  IS NULL"; }
            if (chbPerf.Checked)
            {
                if (cbhStudio.Checked)
                { sqlite_cmd.CommandText += " AND performers.name IS NULL"; }
                else
                {
                    sqlite_cmd.CommandText += " where performers.name IS NULL";
                }

            }
            sqlite_cmd.CommandText += " GROUP BY scenes.id ";
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                //  Console.WriteLine(sqlite_datareader["sid"]+" "+sqlite_datareader["pid"] + " " + sqlite_datareader["stid"]);
                //int[] myInts = Array.ConvertAll(arr, int.Parse);
                //Console.WriteLine(sqlite_datareader.GetInt32(1) +" "+ sqlite_datareader.GetInt32(3) + " " + sqlite_datareader.GetInt32(4) + " " + sqlite_datareader.GetInt32(6) + " " + sqlite_datareader.GetString(0) + " " + sqlite_datareader.GetString(5) + " " + sqlite_datareader.GetString(2) + " " + sqlite_datareader.GetString(7));
                scenelist.Add(new scenes(convertToInt(sqlite_datareader["sid"].ToString()), convertToInt(sqlite_datareader["pid"].ToString()), convertToInt(sqlite_datareader["stid"].ToString()), sqlite_datareader["path"].ToString(), sqlite_datareader["studio"].ToString(), sqlite_datareader["performer"].ToString(), convertToInt(sqlite_datareader["tagid"].ToString()), sqlite_datareader["tagname"].ToString()));
            }

            fillList();
        }
        void GetListOfTags(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "select tags.id, tags.name from tags";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                taglist.Add(new tags(convertToInt(sqlite_datareader["id"].ToString()), sqlite_datareader["name"].ToString()));
            }

            filltag();

        }
        void GetListOfPerformers(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "select performers.id, performers.name from performers";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                perflist.Add(new performers(convertToInt(sqlite_datareader["id"].ToString()), sqlite_datareader["name"].ToString()));
            }

            fillperf();
        }

        void GetListOfStudios(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "select studios.id, studios.name from studios";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {

                studlist.Add(new studios(convertToInt(sqlite_datareader["id"].ToString()), sqlite_datareader["name"].ToString()));
            }

            fillstud();
        }


        void fillList()
        {
            listView1.Items.Clear();
            foreach (scenes sc in scenelist)
            {
                ListViewItem lvi = new ListViewItem(sc.path);
                lvi.SubItems.Add(sc.performer);
                lvi.SubItems.Add(sc.studio);
                lvi.SubItems.Add(sc.tag);
                lvi.Tag = sc.sceneID;
                listView1.Items.Add(lvi);

               
            }
            label3.Text = "Total: " + scenelist.Count.ToString();

        }
        void fillperf()
        {
            foreach (performers pf in perflist)
            {
                cbPerf.Items.Add(pf.Performer);
            }

        }

        void filltag()
        {
            foreach (tags tg in taglist)
            {
              
                checkedListBox1.Items.Add(tg.Name);
            }

        }
        void fillstud()
        {
            foreach (studios pf in studlist)
            {
                cbStud.Items.Add(pf.Studioname);

            }

        }
        static int convertToInt(string a)
        {
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = a[i] - '0';
                if (temp != 0)
                {
                    x += temp * (int)Math.Pow(10, (a.Length - (i + 1)));
                }
            }
            return x;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                //Console.WriteLine(item.Index.ToString());

                scenelist[item.Index].performer = cbPerf.Text;

                if (!string.IsNullOrEmpty(cbPerf.Text))
                {
                    InsertData(sqlite_conn, convertToInt(item.Tag.ToString()), perflist[cbPerf.SelectedIndex].ID);
                    item.SubItems[1].Text = cbPerf.Text;
                }
                if (!string.IsNullOrEmpty(cbStud.Text))
                {
                    InsertStudio(sqlite_conn, convertToInt(item.Tag.ToString()), studlist[cbStud.SelectedIndex].ID);
                    item.SubItems[2].Text = cbStud.Text;
                }
            }
        }



        void InsertStudio(SQLiteConnection conn, int vidid, int stid)
        {
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "Update scenes SET studio_id = " + stid + " where id =" + vidid;
            sqlite_cmd.ExecuteNonQuery();

        }

        void InsertData(SQLiteConnection conn, int vidid, int perfid)
        {


            SQLiteCommand sqlite_cmd;



            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO performers_scenes (performer_id,scene_id) VALUES(" + perfid + "," + vidid + ");";
            sqlite_cmd.ExecuteNonQuery();



        }

        private void llclearperf_MouseClick(object sender, MouseEventArgs e)
        {
            cbPerf.SelectedItem = null;
        }

        private void llclearstud_MouseClick(object sender, MouseEventArgs e)
        {
            cbStud.SelectedItem = null;
        }

        private void chbStud(object sender, EventArgs e)
        {

        }
        public void insertTags(SQLiteConnection conn, int vidid)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i) == true)
                {

                    // MessageBox.Show("This is the value of Item " + taglist[i].Name +" and ID:" + taglist[i].ID);
                    SQLiteCommand sqlite_cmd;



                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "INSERT INTO scenes_tags (scene_id,tag_id) VALUES(" + vidid + "," + taglist[i].ID + ");";
                    sqlite_cmd.ExecuteNonQuery();



                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                insertTags(sqlite_conn, scenelist[item.Index].sceneID);

                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    var item = listView1.Items[i];
                    if (item.Text.ToLower().Contains(textBox1.Text.ToLower()))
                    {

                    }
                    else
                    {
                        scenelist.RemoveAt(i);
                        listView1.Items.Remove(item);
                    }
                }
                if (listView1.SelectedItems.Count == 1)
                {
                    listView1.Focus();
                }
            }
            else
            {
                listView1.Items.Clear();
                scenelist.Clear();
                GetListOfVideos(sqlite_conn);
                fillList();
            }
        }

        private void AutoTagMovies(SQLiteConnection conn, string performer, int perfid)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "select scenes.path,scenes.id as sid, GROUP_CONCAT(performers.name) as performer, GROUP_CONCAT(performers.id) as pid, studios.name as studio, studios.id  as stid, tags.name as tagname, tags.id as tagid from scenes left join performers_scenes on performers_scenes.scene_id = scenes.id left join performers on performers.id = performers_scenes.performer_id left join studios on scenes.studio_id = studios.id left join scenes_tags on scenes_tags.scene_id = scenes.id left join tags on tags.id = scenes_tags.tag_id";
            sqlite_cmd.CommandText += " Where path LIKE '%" + performer + "%'";
            sqlite_cmd.CommandText += " GROUP BY scenes.id";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0);
                //  Console.WriteLine(sqlite_datareader["sid"]+" "+sqlite_datareader["pid"] + " " + sqlite_datareader["stid"]);
                //int[] myInts = Array.ConvertAll(arr, int.Parse);
                //Console.WriteLine(sqlite_datareader.GetInt32(1) +" "+ sqlite_datareader.GetInt32(3) + " " + sqlite_datareader.GetInt32(4) + " " + sqlite_datareader.GetInt32(6) + " " + sqlite_datareader.GetString(0) + " " + sqlite_datareader.GetString(5) + " " + sqlite_datareader.GetString(2) + " " + sqlite_datareader.GetString(7));
                if(sqlite_datareader["pid"].ToString().Contains(perfid.ToString()))
                    Console.WriteLine("Already exists!");
                 else
                {
                    Console.WriteLine(sqlite_datareader["performer"].ToString() + " Found!");
                    scenelist.Add(new scenes(convertToInt(sqlite_datareader["sid"].ToString()), convertToInt(sqlite_datareader["pid"].ToString()), convertToInt(sqlite_datareader["stid"].ToString()), sqlite_datareader["path"].ToString(), sqlite_datareader["studio"].ToString(), sqlite_datareader["performer"].ToString(), convertToInt(sqlite_datareader["tagid"].ToString()), sqlite_datareader["tagname"].ToString()));
                }
            }
            
            
            foreach(scenes sce in scenelist)
            {
                InsertData(sqlite_conn, convertToInt(sce.sceneID.ToString()), perfid);
            }
            UpdateProgress();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            scenelist.Clear();
            var test = cbPerf.Text.Replace(' ', '.');
            AutoTagMovies(sqlite_conn, test, perflist[cbPerf.SelectedIndex].ID);
            Console.WriteLine(cbPerf.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = perflist.Count * 2;
            Thread thread = new Thread(GetThreading);
            thread.Start();
          
            Console.WriteLine("while loop has breaked! so the thread is finished!");
            fillList();
        }
        public void UpdateProgress()
        {
            this.Invoke((MethodInvoker)delegate {
                progressBar1.Value = progressBar1.Value + 1; // runs on UI thread
            });
        }

        public void GetThreading()
        {
            foreach (var perf in perflist)
            {
                scenelist.Clear();
                var test = perf.Performer.Replace(' ', '.');
                AutoTagMovies(sqlite_conn, test, perf.ID);
                Console.WriteLine(perf.Performer);


            }
            foreach (var perf in perflist)
            {
                scenelist.Clear();

                AutoTagMovies(sqlite_conn, perf.Performer, perf.ID);
                Console.WriteLine(perf.Performer);


            }
            
        }
    }
    
}

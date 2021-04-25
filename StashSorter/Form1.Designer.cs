namespace StashSorter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvhPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhPerformer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhStudio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvhTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbPerf = new System.Windows.Forms.ComboBox();
            this.cbStud = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbConnect = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.llclearstud = new System.Windows.Forms.LinkLabel();
            this.llclearperf = new System.Windows.Forms.LinkLabel();
            this.chbPerf = new System.Windows.Forms.CheckBox();
            this.cbhStudio = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvhPath,
            this.lvhPerformer,
            this.lvhStudio,
            this.lvhTags});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(573, 342);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // lvhPath
            // 
            this.lvhPath.Text = "Path";
            this.lvhPath.Width = 194;
            // 
            // lvhPerformer
            // 
            this.lvhPerformer.Text = "Performer";
            this.lvhPerformer.Width = 120;
            // 
            // lvhStudio
            // 
            this.lvhStudio.Text = "Studio";
            this.lvhStudio.Width = 144;
            // 
            // lvhTags
            // 
            this.lvhTags.Text = "Tags";
            this.lvhTags.Width = 106;
            // 
            // cbPerf
            // 
            this.cbPerf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerf.FormattingEnabled = true;
            this.cbPerf.Location = new System.Drawing.Point(625, 36);
            this.cbPerf.Name = "cbPerf";
            this.cbPerf.Size = new System.Drawing.Size(121, 21);
            this.cbPerf.TabIndex = 1;
            // 
            // cbStud
            // 
            this.cbStud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStud.FormattingEnabled = true;
            this.cbStud.Location = new System.Drawing.Point(625, 111);
            this.cbStud.Name = "cbStud";
            this.cbStud.Size = new System.Drawing.Size(121, 21);
            this.cbStud.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Performers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Studios";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(650, 160);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbConnect
            // 
            this.tbConnect.Location = new System.Drawing.Point(404, 396);
            this.tbConnect.Name = "tbConnect";
            this.tbConnect.Size = new System.Drawing.Size(75, 23);
            this.tbConnect.TabIndex = 8;
            this.tbConnect.Text = "Connect";
            this.tbConnect.UseVisualStyleBackColor = true;
            this.tbConnect.Click += new System.EventHandler(this.tbConnect_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(21, 397);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(336, 20);
            this.tbPath.TabIndex = 9;
            this.tbPath.Text = "Z:\\stash-go.sqlite";
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(363, 397);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(26, 20);
            this.btBrowse.TabIndex = 10;
            this.btBrowse.Text = "...";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // llclearstud
            // 
            this.llclearstud.AutoSize = true;
            this.llclearstud.Location = new System.Drawing.Point(653, 135);
            this.llclearstud.Name = "llclearstud";
            this.llclearstud.Size = new System.Drawing.Size(64, 13);
            this.llclearstud.TabIndex = 11;
            this.llclearstud.TabStop = true;
            this.llclearstud.Text = "Clear Studio";
            this.llclearstud.MouseClick += new System.Windows.Forms.MouseEventHandler(this.llclearstud_MouseClick);
            // 
            // llclearperf
            // 
            this.llclearperf.AutoSize = true;
            this.llclearperf.Location = new System.Drawing.Point(647, 60);
            this.llclearperf.Name = "llclearperf";
            this.llclearperf.Size = new System.Drawing.Size(79, 13);
            this.llclearperf.TabIndex = 12;
            this.llclearperf.TabStop = true;
            this.llclearperf.Text = "Clear Performer";
            this.llclearperf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.llclearperf_MouseClick);
            // 
            // chbPerf
            // 
            this.chbPerf.AutoSize = true;
            this.chbPerf.Location = new System.Drawing.Point(485, 385);
            this.chbPerf.Name = "chbPerf";
            this.chbPerf.Size = new System.Drawing.Size(111, 17);
            this.chbPerf.TabIndex = 13;
            this.chbPerf.Text = "Without Performer";
            this.chbPerf.UseVisualStyleBackColor = true;
            // 
            // cbhStudio
            // 
            this.cbhStudio.AutoSize = true;
            this.cbhStudio.Location = new System.Drawing.Point(485, 408);
            this.cbhStudio.Name = "cbhStudio";
            this.cbhStudio.Size = new System.Drawing.Size(96, 17);
            this.cbhStudio.TabIndex = 14;
            this.cbhStudio.Text = "Without Studio";
            this.cbhStudio.UseVisualStyleBackColor = true;
            this.cbhStudio.CheckedChanged += new System.EventHandler(this.chbStud);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(626, 187);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Tags";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Total: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(670, 82);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Tag All";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(650, 329);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Automate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(602, 358);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(174, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 429);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.cbhStudio);
            this.Controls.Add(this.chbPerf);
            this.Controls.Add(this.llclearperf);
            this.Controls.Add(this.llclearstud);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.tbConnect);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStud);
            this.Controls.Add(this.cbPerf);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "StashSorter *NOT CONNECTED*";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lvhPath;
        private System.Windows.Forms.ColumnHeader lvhPerformer;
        private System.Windows.Forms.ColumnHeader lvhStudio;
        private System.Windows.Forms.ColumnHeader lvhTags;
        private System.Windows.Forms.ComboBox cbPerf;
        private System.Windows.Forms.ComboBox cbStud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button tbConnect;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btBrowse;
        private System.Windows.Forms.LinkLabel llclearstud;
        private System.Windows.Forms.LinkLabel llclearperf;
        private System.Windows.Forms.CheckBox chbPerf;
        private System.Windows.Forms.CheckBox cbhStudio;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}


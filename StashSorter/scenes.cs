using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StashSorter
{
    class scenes
    {
        public int sceneID { get;  set; }
        public int performerID { get;  set; }
        public int studioID { get;  set; }
        public int tagID { get; private set; }

        public string path { get;  set; }
        public string studio { get;  set; }
        public string performer { get;  set; }
        public string tag { get; private set; }

        public scenes(int sID,int pID,int stID, string spath,string sstudio,string sperformer,int tID,string stag)
        {
            sceneID = sID;
            performerID = pID;
            studioID = stID;
            tagID = tID;

            path = spath;
            studio = sstudio;
            performer = sperformer;
            tag = stag;



        }

    }
}

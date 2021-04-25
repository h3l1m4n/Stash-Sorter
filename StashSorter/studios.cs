using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StashSorter
{
    class studios
    {
        public int ID { get; private set; }
        public string Studioname { get; private set; }

        public studios(int id , string name)
        {
            ID = id;
            Studioname = name;
        }
    }
}

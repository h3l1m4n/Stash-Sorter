using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StashSorter
{
    class tags
    {
        public int ID { get;  set; }
        public string Name { get;  set; }

        public tags(int id, string name)
        {
            Name = name;
            ID = id;
        }

    }
}

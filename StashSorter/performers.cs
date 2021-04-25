using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StashSorter
{

    class performers
    {
        public int ID { get; private set; }
        public string Performer { get; private set; }

        public performers(int id, string performer)
        {
            ID = id;
            Performer = performer;

        }
    }
}

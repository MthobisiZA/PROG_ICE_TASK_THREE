using System;
using System.Collections.Generic;
using System.Text;

namespace PROG_ICE_TASK_THREE
{
    class TODO
    {
        public TODO(string name, string date, string priorities)
        {
            this.name = name;
            this.date = date;
            this.priorities = priorities;
        }

        public string name { get; set; }
        public string date{ get; set; }
        public string priorities { get; set; }
    }
}
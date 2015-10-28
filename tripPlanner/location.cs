using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripPlanner
{
    class Location
    {
        public List<string> museums { get; set; }
        public List<string> activities { get; set; }
        public List<string> landmarks { get; set; }
        public string name { get; set; }

        public Location()
            {

            }
        public override string ToString()
        {
            return name;
        }

    }
}

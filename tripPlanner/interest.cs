using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace tripPlanner
{
    class Interest
    {
        public string Name { get; set; }
        public string Info { get; set; }
        public interestType Type { get; set; }

        public Interest()
        {
        }

        public Interest(string name, string info, interestType type)
        {
            Name = name;
            Info = info;
            Type = type;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    enum interestType
    {
        Museum,
        Activity,
        Landmark
    }

}

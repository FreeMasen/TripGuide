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
        //the name and info properties are strings
        public string Name { get; set; }
        public string Info { get; set; }
        //the interest type is an interestType enum value
        public interestType Type { get; set; }

        //empty constructor
        public Interest()
        {
        }

        //constructor that takes two strings and a interestType
        public Interest(string name, string info, interestType type)
        {
            //set the values passed to the new Interest(); method
            //to the properties in this object
            Name = name;
            Info = info;
            Type = type;
        }

        //return the name string when the tostring method is called
        public override string ToString()
        {
            return Name;
        }
    }

    //this defines the 4 items avalable as types of interests
    //the first item is none because the default will always be 0
    //so I wanted to control the value at 0
    enum interestType
    {
        none,
        Museum,
        Activity,
        Landmark
    }

}

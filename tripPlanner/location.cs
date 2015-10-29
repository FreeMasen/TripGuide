using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripPlanner
{
    class Location
    {
        public List<Interest> Museums { get; set; }
        public List<Interest> Activities { get; set; }
        public List<Interest> Landmarks { get; set; }
        public string Name { get; set; }

        //blank constructor to create an empty location object
        public Location()
            {

            }

        //constructor passed 3 variables to create a completed location
        public Location(string name, List<Interest> museums, List<Interest> activities, List<Interest> landmarks)
        {
            Name = name;
            Museums = museums;
            Activities = activities;
            Landmarks = landmarks;

        }

        public override string ToString()
        {
            return Name;
        }

    }
}

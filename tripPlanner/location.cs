using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tripPlanner
{
    class Location
    {
        //Global varables are lists of interest objects
        public List<Interest> Museums { get; set; }
        public List<Interest> Activities { get; set; }
        public List<Interest> Landmarks { get; set; }
        //the name property is a string
        public string Name { get; set; }

        //blank constructor to create an empty location object
        public Location()
            {

            }

        //constructor passed 3 variables to create a completed location
        public Location(string name, List<Interest> museums, List<Interest> activities, List<Interest> landmarks)
        {
            //set the name to the object properties to the 
            //items passed to the new Location();
            Name = name;
            Museums = museums;
            Activities = activities;
            Landmarks = landmarks;

        }

        //return the name string when the tostring method is called on location
        public override string ToString()
        {
            return Name;
        }

    }
}

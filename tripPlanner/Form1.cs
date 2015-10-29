using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tripPlanner
{
    public partial class Travelguide : Form
    {
        public Travelguide()
        {
            InitializeComponent();
        }

        List<Location> Locations = new List<Location>();

        private void lstInterests_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if the listbox selection is not nothing
            if (lstInterests.SelectedIndex > -1)
            {
                //set the default interest type fo 0
                interestType check = 0;
                //loop over the selected radiobuttons in our group box that are selected
                //this will always be 1 item
                foreach (RadioButton rdo in grpInterests.Controls.OfType<RadioButton>().Where(t => t.Checked))
                {
                    //set the check variable to the tag property of the radiobutton selected
                    //this is not currently doing anythign but might be later
                    check = (interestType)rdo.Tag;
                }
                //set the variable place to the interestd located in the Museums propery list at the selected index for the list box
                //and the location to the selected index of the cbo.  
                //todo These would be better set as global variables? and then updated via methods
                Interest place = Locations[cboDestination.SelectedIndex].Museums[lstInterests.SelectedIndex];
                        lblInfo.Text = place.Info;
                    
            }
        }

        private void Travelguide_Load(object sender, EventArgs e)
        {
            //Location Amsterdam = new Location();
            //List<string> museum = new List<string>();
            //List<string> activities = new List<string>();
            //List<string> landmarks = new List<string>();
            //Amsterdam.name = "Amsterdamn";

            //museum.Add("Rijkmuseum");
            //museum.Add("Stedelijk Museum");
            //museum.Add("Ann Frank House");

            //activities.Add("Biking");
            //activities.Add("Gondola Riding");
            //activities.Add("Shopping");

            //landmarks.Add("Amsterdamn sign");
            //landmarks.Add("Vist Vondelpark");
            //landmarks.Add("Visit Hannekes Boom");

            //Amsterdam.Museums = museum;
            //Amsterdam.Activities = activities;
            //Amsterdam.Landmarks = landmarks;
            //Locations.Add(Amsterdam);
            //cboDestination.Items.Add(Locations[0]);
            //set the tags of our rdos to the options in our enum
            rdoMuseums.Tag = interestType.Museum;
            rdoActivities.Tag = interestType.Activity;
            rdoLandmarks.Tag = interestType.Landmark;
            dummyData();

        }

        /// <summary>
        /// this holds some dummy data to play with, taken from Wikipedia/google maps
        /// </summary>
        private void dummyData()
        {
            Interest Rij = new Interest("Rijkmuseum", "The Rijksmuseum is a Netherlands national museum dedicated to arts and history in Amsterdam. The museum is located at the Museum Square in the borough Amsterdam South.", interestType.Museum);
            Interest stedInterest = new Interest("Stedelijk Museum", "", interestType.Museum);
            Interest AnnFrank = new Interest("Ann Frank House", "", interestType.Museum);
            List<Interest> amst = new List<Interest>();
            amst.Add(Rij);
            amst.Add(stedInterest);
            amst.Add(AnnFrank);

            Location Amsterdam = new Location("Amsterdam",amst, amst, amst);
            Locations.Add(Amsterdam);
            updateCBO();
        }

        private void cboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDestination.SelectedIndex > -1)
            {
                //Location location = Locations[cboDestination.SelectedIndex];
                
                //    foreach (var museum in location.museums)
                //    {
                //        lstInterests.Items.Add(museum);
                //    }
                
            }
        }

        /// <summary>
        /// this updates the options in our cbo
        /// </summary>
        private void updateCBO()
        {
            foreach (var dest in Locations)
            {
                cboDestination.Items.Add(dest.ToString());
            }
        }

        //this sets the listbox to have the correct interests
        //todo this needs to be pulled out into methods
        private void rdoMuseums_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            if (rdo.Checked)
            {
                switch (cboDestination.SelectedIndex)
                {
                    case 0:
                        if(rdo.Text == "Museums")
                        {
                            Location location = Locations[cboDestination.SelectedIndex];
                            lstInterests.Items.Clear();
                            foreach (var museum in location.Museums)
                            {
                                lstInterests.Items.Add(museum);
                            }
         
                        }
                        else if(rdo.Text == "Activities")
                        {
                            Location location = Locations[cboDestination.SelectedIndex];
                            lstInterests.Items.Clear();
                            foreach (var activity in location.Activities)
                            {
                                lstInterests.Items.Add(activity);
                            }
                        }
                        else
                        {
                            Location location = Locations[cboDestination.SelectedIndex];
                            lstInterests.Items.Clear();
                            foreach (var landmark in location.Landmarks)
                            {
                                lstInterests.Items.Add(landmark);
                            }
                        }
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                }
            }
        }
    }
}

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

        }

        private void Travelguide_Load(object sender, EventArgs e)
        {
            Location Amsterdam = new Location();
            List<string> museum = new List<string>();
            List<string> activities = new List<string>();
            List<string> landmarks = new List<string>();
            Amsterdam.name = "Amsterdamn";

            museum.Add("Rijkmuseum");
            museum.Add("Stedelijk Museum");
            museum.Add("Ann Frank House");

            activities.Add("Biking");
            activities.Add("Gondola Riding");
            activities.Add("Shopping");

            landmarks.Add("Amsterdamn sign");
            landmarks.Add("Vist Vondelpark");
            landmarks.Add("Visit Hannekes Boom");

            Amsterdam.museums = museum;
            Amsterdam.activities = activities;
            Amsterdam.landmarks = landmarks;
            Locations.Add(Amsterdam);
            cboDestination.Items.Add(Locations[0]);


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
                            foreach (var museum in location.museums)
                            {
                                lstInterests.Items.Add(museum);
                            }
         
                        }
                        else if(rdo.Text == "Activities")
                        {
                            Location location = Locations[cboDestination.SelectedIndex];
                            lstInterests.Items.Clear();
                            foreach (var activity in location.activities)
                            {
                                lstInterests.Items.Add(activity);
                            }
                        }
                        else
                        {
                            Location location = Locations[cboDestination.SelectedIndex];
                            lstInterests.Items.Clear();
                            foreach (var landmark in location.landmarks)
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

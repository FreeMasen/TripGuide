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

#region Global Variables
        List<Location> Locations = new List<Location>();
        Location currentLocation = new Location();
        private interestType currentInterest = interestType.none;
#endregion

        #region Event Handlers
        private void Travelguide_Load(object sender, EventArgs e)
        {
            rdoMuseums.Tag = interestType.Museum;
            rdoActivities.Tag = interestType.Activity;
            rdoLandmarks.Tag = interestType.Landmark;
            dummyData();

        }

        //when the user chooes an interest
        private void lstInterests_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if the listbox selection is not nothing
            if (lstInterests.SelectedIndex > -1)
            {
                //set the label text to the info property of the interest selected in the lstbox
                //since we added the intereest object to the lstbox we can cast the selected item to
                //an interest object.
                Interest place = (Interest)lstInterests.SelectedItem;
                StringBuilder sb = new StringBuilder();
                StringBuilder ln = new StringBuilder();

                foreach (var letter in place.Info)
                {
                    ln.Append(letter);
                    if ((ln.Length > 20) && letter == ' ')
                    {
                        sb.AppendLine(ln.ToString());
                        ln.Clear();
                    }
                }
                lblInfo.Text = sb.ToString();     
            }
        }

        private void cboDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLocation();
            //since this method checks for both selections
            //we can call it here and in the checked change event
            updateListbox();

        }

        private void rdoMuseums_CheckedChanged(object sender, EventArgs e)
        {
            setInterest();
            updateListbox();

        }
        #endregion

        #region Visual Updates
        /// <summary>
        /// this method checks that both location and interest type are selected
        /// it then check which type of interest is selected and loops over
        /// the collection of interets in the selected location, adding them 
        /// to the lstbox
        /// </summary>
        private void updateListbox()
        {
            //if a location and interest have been selected
            if (isLocation() && isInterest())
            {
                lstInterests.Items.Clear();
                //check which type of interest has been selected
                switch (currentInterest)
                {
                    //if none, clear the listbox
                    case interestType.none:
                        lstInterests.Items.Clear();
                        lblInterests.Text = "";
                        break;
                        //if museums, add the museums to the lstbox
                    case interestType.Museum:
                        foreach (var museum in currentLocation.Museums)
                        {
                            lstInterests.Items.Add(museum);
                        }
                        lblInterests.Text = "Museums";
                    break;
                        //if activity ad the activities to the lstbox
                    case interestType.Activity:
                        foreach (var activity in currentLocation.Activities)
                        {
                            lstInterests.Items.Add(activity);
                        }
                        lblInterests.Text = "Activities";
                    break;
                        //if landmark, add the landmarks to the lstbox
                    case interestType.Landmark:
                        foreach (var landmark in currentLocation.Landmarks)
                        {
                            lstInterests.Items.Add(landmark);
                        }
                        lblInterests.Text = "Landmarks";
                    break;
                }
            }
        }



        /// <summary>
        /// this updates the options in our cbo
        /// </summary>
        private void updateCBO()
        {
            lstInterests.Items.Clear();
            foreach (var dest in Locations)
            {
                cboDestination.Items.Add(dest.ToString());
            }
        }
        #endregion

        #region Logic
        /// <summary>
        /// this method sets the location to what has been selected from the combobox
        /// </summary>
        private void setLocation()
        {
            if (isLocation())
            {
                currentLocation = Locations[cboDestination.SelectedIndex];
            }
            else
            {
                currentLocation = new Location();
            }
        }

        /// <summary>
        /// this method sets the current interest global variable
        /// </summary>
        private void setInterest()
        {
            if (isInterest())
            {
                foreach (var rdo in grpInterests.Controls.OfType<RadioButton>())
                {
                    if (rdo.Checked)
                    {
                        currentInterest = (interestType) rdo.Tag;
                    }
                }
            }
        }
        #endregion

#region Validation
        /// <summary>
        /// this method check to see if a rdo button has been checked
        /// to define the current interest type
        /// </summary>
        /// <returns></returns>
        private bool isLocation()
        {
            if (cboDestination.SelectedIndex > -1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This method checks if a radio button is seleted
        /// </summary>
        /// <returns></returns>
        private bool isInterest()
        {
            int selected = 0;
            foreach (var rdo in grpInterests.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    selected++;
                }
            }
            if (selected <= 0)
            {
                return false;
            }
            return true;
        }
#endregion
        

        /// <summary>
        /// this holds some dummy data to play with, taken from Wikipedia/google maps
        /// </summary>
        private void dummyData()
        {
            Interest Rij = new Interest("Rijkmuseum", "The Rijksmuseum is a Netherlands national museum dedicated to arts and history in Amsterdam. The museum is located at the Museum Square in the borough Amsterdam South.", interestType.Museum);
            Interest stedInterest = new Interest("Stedelijk Museum", "The Stedelijk Museum Amsterdam is an international museum dedicated to modern and contemporary art and design. - See more at: http://www.stedelijk.nl/en#sthash.dzaEBA4u.dpuf", interestType.Museum);
            Interest AnnFrank = new Interest("Ann Frank House", "The Anne Frank House (Dutch: Anne Frank Huis) is a historic house and biographical museum dedicated to Jewish wartime diarist Anne Frank. The building is located at the Prinsengracht, close to the Westerkerk, in central Amsterdam in the Netherlands.", interestType.Museum);
            List<Interest> mues = new List<Interest>();
            mues.Add(Rij);
            mues.Add(stedInterest);
            mues.Add(AnnFrank);

            Interest bike = new Interest("Ride a bike", "Do as the locals do, and grab a set of wheels for an active bicycle tour around Amsterdam. ", interestType.Activity);
            Interest boat = new Interest("Take a boat tour", "Experiencing Amsterdam from the water is one of the best ways to get to know the city", interestType.Activity);
            Interest walking = new Interest("Walking", "Hit the streets and get walking - the best way to see Amsterdam", interestType.Activity);
            List<Interest> act = new List<Interest>();
            act.Add(bike);
            act.Add(boat);
            act.Add(walking);

            Interest sign = new Interest("The I Amsterdam sign", "The large I amsterdam slogan quickly became a city icon and a much sought-after photo opportunity. Visitors photograph themselves, in, around and on top of the slogan, and it always manages to inspire the novice photographer.", interestType.Landmark);
            Interest Damsq = new Interest("Dam square", "The Dam is the very centre and heart of the city, and is the center of Amsterdam attractions.", interestType.Landmark);
            Interest Vondelpark = new Interest("Vonderlpark", "ondelpark is the largest city park in Amsterdam, and certainly the most famous park in the Netherlands, which welcomes about 10 million visitors every year.", interestType.Landmark);
            List<Interest> lndmrk = new List<Interest>();
            lndmrk.Add(sign);
            lndmrk.Add(Damsq);
            lndmrk.Add(Vondelpark);

            Location Amsterdam = new Location("Amsterdam",mues, act, lndmrk);
            Locations.Add(Amsterdam);
            updateCBO();
        }
        
        
            }
        }
    

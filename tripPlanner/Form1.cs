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
                lblInfo.Text = place.Info;
                    
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
                //check which type of interest has been selected
                switch (currentInterest)
                {
                    //if none, clear the listbox
                    case interestType.none:
                        lstInterests.Items.Clear();
                        break;
                        //if museums, add the museums to the lstbox
                    case interestType.Museum:
                        foreach (var museum in currentLocation.Museums)
                        {
                            lstInterests.Items.Add(museum);
                        }
                    break;
                        //if activity ad the activities to the lstbox
                    case interestType.Activity:
                        foreach (var activity in currentLocation.Activities)
                        {
                            lstInterests.Items.Add(activity);
                        }
                    break;
                        //if landmark, add the landmarks to the lstbox
                    case interestType.Landmark:
                        foreach (var landmark in currentLocation.Landmarks)
                        {
                            lstInterests.Items.Add(landmark);
                        }
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
        
        
            }
        }
    

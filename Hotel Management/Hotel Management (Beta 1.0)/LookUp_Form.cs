using FireSharp.Config;
using FireSharp.Interfaces;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management__Beta_1._0_
{
    public partial class LookUp_Form : Form
    {
        FirebaseSingleton db = FirebaseSingleton.Instance;
        Dictionary<string, Guest> dbGuestDictionary;

        public LookUp_Form()
        {
            InitializeComponent();
            db.StartFirebase();

        }

        // This method resets the textboxes
        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Name_TextBox.Text = "";
            LastName_TextBox.Text = "";
        }

        // This method searches the database for a guest(given name or last name)
        int performSearch(string firstName, string lastName) {
            int match = 0;
            try
            {
                dbGuestDictionary = db.GetDatabaseGuestDictionary();
                int progressBarValue = 1;
                if (firstName == "" && lastName == "") //
                {
                    result_TextBox.Text = "Enter a name.";
                }
                else
                {
                    foreach (var guest in dbGuestDictionary.Values)
                    {
                        if ((guest.FirstName == firstName) && (guest.LastName == lastName))//
                        {
                            result_TextBox.Text += guest.FirstName + ", " + guest.LastName + ", #" + guest.room.RoomNumber + ", Chk-in time: " + guest.payment.Time + "\n";
                            match = 1;
                            break;
                        }
                    }

                    if (match == 0)
                    {
                        foreach (var guest in dbGuestDictionary.Values)
                        {
                            if ((guest.FirstName == firstName && lastName != "") && lastName == "")//
                            {
                                result_TextBox.Text += guest.FirstName + ", " + guest.LastName + ", #" + guest.room.RoomNumber + ", Chk-in time: " + guest.payment.Time + "\n";
                                match++;
                            }
                            else if ((guest.LastName == lastName && lastName != "") && firstName == "")//
                            {
                                result_TextBox.Text += guest.FirstName + ", " + guest.LastName + ", #" + guest.room.RoomNumber + ", Chk-in time: " + guest.payment.Time + "\n";
                                match++;
                            }
                        }
                    }
                }
                
                progressBar.Value = progressBarValue++;

                if (match == 0)
                {
                    result_TextBox.Text = "No results found.";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return match;
        }
        private void Search_button_Click(object sender, EventArgs e)
        {
            result_TextBox.Text = "";
            progressBar.Visible = true;

            
            performSearch(Name_TextBox.Text, LastName_TextBox.Text);

            progressBar.Visible = false;
            progressBar.Value = 0;
        }
    }
}

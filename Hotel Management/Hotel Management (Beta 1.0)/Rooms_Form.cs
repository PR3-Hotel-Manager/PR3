using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection;
using System.Collections.Generic;
using FireSharp;
using System.ComponentModel;
using System.DirectoryServices;

namespace Hotel_Management__Beta_1._0_
{
    
    public partial class Rooms_Form : Form
    {
        FirebaseSingleton db = FirebaseSingleton.Instance;


        public Rooms_Form()
        {
            InitializeComponent();
        }
        private void Rooms_Form_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = true;

            db.StartFirebase();
            this.BringToFront();
            this.Show();

            checkRooms();

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void checkRooms()
        {
            Guest[] sortedRooms = db.GetSortedData();
            var available = K.NumberOfRooms;
            progressBar1.Maximum= available;
            int progressBarValue = 1;
            foreach (var guest in sortedRooms)
            {
                string roomNumber = guest.room.RoomNumber;
                if (guest.room.Occupied)
                {

                    string text = ("Room: " + roomNumber + " - Beds: " + guest.room.BedConfiguration + "\n"); 
                    Occupied_RichTextBox.Text += text;
                    available--;
                }
                else
                {
                    string text = ("Room: " + roomNumber + " - Beds: " + guest.room.BedConfiguration + "\n");
                    Empty_richTextBox.Text += text;
                }
                progressBar1.Value = progressBarValue++;
                        
            }
            //progressBar1.Visible = false;
            AvailableRooms_Label.Text = "Available Rooms: " + available;
        }
    }
}

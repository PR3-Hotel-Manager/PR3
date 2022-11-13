﻿using FireSharp.Config;
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

            try
            {
                FirebaseResponse res = db.client.Get(@K.FirebaseTopFolder);
                if (res.Body.ToString() == "null")
                {
                    MessageBox.Show("No one is Check-in.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Dictionary<string, Guest> data = JsonConvert.DeserializeObject<Dictionary<string, Guest>>(res.Body.ToString());
                    Guest[] sortedRooms = new Guest[K.NumberOfRooms];
                    for (var i = 0; i < K.NumberOfRooms; i++)
                    {
                        string firebaseKey = K.FirebaseKey((i+1).ToString());
                        int index = Convert.ToInt32(data[firebaseKey].room.RoomNumber)-1;
                        Guest guest = data[firebaseKey];
                        sortedRooms[index] = guest;
                    }
                    var available = K.NumberOfRooms;
                    progressBar1.Maximum= available;
                    int progressBarValue = 1;
                    foreach (var g in sortedRooms)
                    {
                        string roomNumber = g.room.RoomNumber;
                        if (g.room.Occupied)
                        {

                            string text = ("Room: " + roomNumber + " - Beds: " + g.room.BedConfiguration + "\n"); 
                            Occupied_RichTextBox.Text += text;
                            available--;
                        }
                        else
                        {
                            string text = ("Room: " + roomNumber + " - Beds: " + g.room.BedConfiguration + "\n");
                            Empty_richTextBox.Text += text;
                        }
                        progressBar1.Value = progressBarValue++;
                        
                    }
                    //progressBar1.Visible = false;
                    AvailableRooms_Label.Text = "Available Rooms: " + available;
                }
 
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error.");
            }
        }

    }
}

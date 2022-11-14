﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Reflection;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using FireSharp;
using JsonFlatten;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.AccessControl;

namespace Hotel_Management__Beta_1._0_
{
    public partial class CheckIn_Form : Form
    {
        FirebaseSingleton db = FirebaseSingleton.Instance;
        private Guest? guest;
        Dictionary<string, Guest> data;

        public CheckIn_Form()
        {
            InitializeComponent();
        }

        private void CheckIn_Form_Load(object sender, EventArgs e)
        {
            db.StartFirebase();
        }

        private bool verifyInputs()  // returns false if conditions are not met.
        {
            if (LastName_TextBox.Text == "" || Name_TextBox.Text == "")
            {
                return false;  // Check if TextBoxes are empty.
            }

            if (Name_TextBox.Text.All(Char.IsLetter) == false || LastName_TextBox.Text.All(Char.IsLetter) == false)
            {
                return false;   // Check if TextBoxes contain only letters.
            }

            else
                return true;

        }

        // Generate Hash 
        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        // Get Hash
        public static string getHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();

        }

        private string retrievePaymentMethod()
        {
            if (Cash_RadioButton.Checked == true)
            {
                return "Cash";
            }
            else
                return "Credit/Debit";
        }

        public void performCheckIn()
        {
            // Get Payment Method
            string pmtMethod = retrievePaymentMethod();

            // Get Name, Last Name, Age, Bed, Price, Room#, Stay Length
            // Add fields to Database
            guest = new Guest(
                Name_TextBox.Text,
                LastName_TextBox.Text,
                Age_Selector.Value.ToString(),
                StayLength_Selector.Value.ToString(),
                new Room(Room_Selector.Value.ToString(), BedConfig_Selector.Value.ToString(), true),
                new Payment((double)(Price_Selector.Value), pmtMethod));

            string confNumber = PrepareConfirmationNumber(guest);

            data = db.GetData();
            if (data == null)
            {
                MessageBox.Show("Data is null.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var firebaseKey = K.FirebaseKey(guest.room.RoomNumber);
                Guest databaseGuest = data[firebaseKey];
                if (databaseGuest.room.Occupied)
                {
                    MessageBox.Show("This room is already occupied. Please select another room.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.UpdateRoomStatus(guest);
                    ShowConfirmationForm(confNumber);
                    UpdateLogFile(guest);
                }
            }
        }

        private string PrepareConfirmationNumber(Guest guest)
        {
            // Prepare Confirmation Number
            string guestDetails = guest.FirstName + guest.LastName + guest.payment.PaymentType;
            string temp = getHashString(guestDetails);
            string confNumber = temp.Substring(temp.Length - (temp.Length / 4));
            return confNumber;
        }

        private void UpdateLogFile(Guest guest)
        {
            // Save to Log File
            string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
            File.AppendAllText(filePath, DateTime.Now.ToString("HH:mm:ss") + "|Chk-in|  " + guest.FirstName.PadRight(15, ' ') + " " + guest.LastName.PadRight(20, ' ') + " " + guest.Age.PadLeft(2) + "  #" + guest.room.RoomNumber.PadRight(2) + " - " + guest.payment.PaymentType + "\n");

            string filePathRoomList = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "room-list" + ".txt";
            File.AppendAllText(filePathRoomList, Room_Selector.Value.ToString() + "\n");
        }

        private void ShowConfirmationForm(string confNumber)
        {
            CheckInConfirmation_Form form = new();  // pass confirmation number to the label in #CheckInConfirmation_Form 
            form.changeLabel(confNumber);
            this.Hide();
            form.ShowDialog(); // Display #CheckInConfirmation_Form
            this.Close();
        }

        // Buttons -------------------
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close(); // Cancel & Exit CheckIn Form
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {

            if (verifyInputs() == true) // If input fields are verified, perform check-in.
            {
                performCheckIn();

            }

            else   // Else; Display Error Message.
            {
                MessageBox.Show("Input fields are missing or contain numbers. Please try again.", " Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Room_Selector_ValueChanged(object sender, EventArgs e)
        {
            if (Room_Selector.Value <= 15)
            {
                BedConfig_Selector.Value = 1;
            }
            else
            {
                BedConfig_Selector.Value = 2;

            }
        } 
    }
}
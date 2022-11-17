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
        private Guest? newGuest;
        private Payment payment = new Payment();
        Dictionary<string, Guest> dbGuestDictionary;

        public CheckIn_Form()
        {
            InitializeComponent();
        }

        private void CheckIn_Form_Load(object sender, EventArgs e)
        {
            db.StartFirebase();
            AvailableRooms();
            BedConfig_Selector.ReadOnly = true;
            BedConfig_Selector.Enabled = false;
            Price_Selector.ReadOnly = true;
            Price_Selector.Enabled = false;
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
            // Payment
            string pmtMethod = retrievePaymentMethod();
            payment.PaymentType = pmtMethod;

            // Room
            Room room = new Room(Room_Selector.Value.ToString(), BedConfig_Selector.Value.ToString(), true);

            // Get Name, Last Name, Age, Bed, Price, Room#, Stay Length
            // Add fields to Database
            newGuest = new Guest(
                Name_TextBox.Text,
                LastName_TextBox.Text,
                Age_Selector.Value.ToString(),
                StayLength_Selector.Value.ToString(),
                room,
                payment);

            string confNumber = PrepareConfirmationNumber(newGuest);
            try
            {
                dbGuestDictionary = db.GetDatabaseGuestDictionary();
                string newGuestKey = K.GuestKey(newGuest.room.RoomNumber);
                Guest dbGuest = dbGuestDictionary[newGuestKey];
                if (dbGuest.room.Occupied)
                {
                    MessageBox.Show("This room is already occupied. Please select another room.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.InsertGuest(newGuest);
                    ShowConfirmationForm(confNumber);
                    UpdateLogFile(newGuest);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            BedConfig_Selector.Value = BedNumber();
            payment.Price = (double)payment.CalculatePrice(BedConfig_Selector.Value, StayLength_Selector.Value);
            Price_Selector.Value = (decimal)payment.Price;
        }

        decimal BedNumber()
        {
            if (Room_Selector.Value <= 15)
            {
                return 1;
            }
            else
            {
                return 2;

            }
        }

        private void AvailableRoom_richTextBox_TextChanged(object sender, EventArgs e)
        {
    
        }

        public void AvailableRooms ()
        {
            Guest[] dbSortedGuests = db.GetSortedDatabaseGuests();
            foreach (var guest in dbSortedGuests)
            {
                if (!guest.room.Occupied)
                {
                    AvailableRoom_richTextBox.Text += "Room: " + guest.room.RoomNumber + " - " + "Beds: " + guest.room.BedConfiguration + "\n";
                }
            }
        }

        private void StayLength_Selector_ValueChanged(object sender, EventArgs e)
        {
            payment.Price = (double)payment.CalculatePrice(BedConfig_Selector.Value, StayLength_Selector.Value);
            Price_Selector.Value = (decimal)payment.Price;
        }
    }
}
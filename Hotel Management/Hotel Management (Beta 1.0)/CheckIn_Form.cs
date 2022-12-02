using System;
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
            Age_ComboBox.Text = "18";
            Available_Rooms_ComboBox.Text = db.GetAvailableRoomsList().ElementAt(0).room.RoomNumber.ToString();
            StayLength_ComboBox.Text = "1";
        }

        private void CheckIn_Form_Load(object sender, EventArgs e)
        {
            db.StartFirebase();
            AvailableRooms();
            Price_Value_Label.Text = "$" + payment.Price.ToString();
        }

        // Buttons -------------------
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close(); // Cancel & Exit CheckIn Form
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (verifyInputs(Name_TextBox.Text, Name_TextBox.Text) == true) // If input fields are verified, call performCheckIn().
            {
                performCheckIn();
            }

            else // Else; Display Error Message.
            {
                MessageBox.Show("Input fields are missing or contain numbers. Please try again.", " Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Auxiliary Methods -----------------------

        // This method verifies guest details
        private bool verifyInputs(string Name, string LastName)  
        {
            if (LastName == "" || Name == "")
            {
                return false;  // Check if inputs are empty.
            }

            if (Name.All(Char.IsLetter) == false || LastName.All(Char.IsLetter) == false)
            {
                return false;   // Check if inputs contain only letters.
            }

            else
                return true;
        }

        // This method generates a Hash 
        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        // This method gets a Hash String
        public static string getHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

        // This method determines which radio button is selected for Payment Method
        private string retrievePaymentMethod()
        {
            if (Cash_RadioButton.Checked == true)
            {
                return "Cash";
            }
            else
                return "Credit/Debit";
        }

        // This method performs Check-in
        public Boolean performCheckIn()
        {    
            Boolean isCheckedIn = false;    // Check-in boolean    
            var roomNumber = Available_Rooms_ComboBox.Text; // Room number to be checked in
            // Try to check-in
            try
            {
                dbGuestDictionary = db.GetDatabaseGuestDictionary();
                string newGuestKey = K.GuestKey(roomNumber);
                Guest dbGuest = dbGuestDictionary[newGuestKey];
                if (dbGuest.room.Occupied)
                {
                    MessageBox.Show("This room is already occupied. Please select another room.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Get Name, Last Name, Age, Bed, Price, Room#, Stay Length
                    // Add fields to Database
                    // Payment
                    string pmtMethod = retrievePaymentMethod();
                    payment.PaymentType = pmtMethod;
                    Room room = new Room(roomNumber, BedConfig_Value_Label.Text, true);
                    newGuest = new Guest(
                        Name_TextBox.Text,
                        LastName_TextBox.Text,
                        Age_ComboBox.Text,
                        StayLength_ComboBox.Text,
                        room,
                        payment);
                    string confNumber = PrepareConfirmationNumber(newGuest);
                    db.InsertGuest(newGuest);
                    ShowConfirmationForm(confNumber);
                    UpdateLogFile(newGuest);
                    isCheckedIn= true; 
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isCheckedIn; 
        }
        
        // This method prepares the confirmation number
        private string PrepareConfirmationNumber(Guest guest)
        {  
            string guestDetails = guest.FirstName + guest.LastName + guest.payment.PaymentType;
            string temp = getHashString(guestDetails);
            string confNumber = temp.Substring(temp.Length - (temp.Length / 4));
            return confNumber;
        }

        // This method saves the details of check-in process to a log file
        private void UpdateLogFile(Guest guest)
        {  
            string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
            File.AppendAllText(filePath, DateTime.Now.ToString("HH:mm:ss") + "|Chk-in|  " + guest.FirstName.PadRight(15, ' ') + " " + guest.LastName.PadRight(20, ' ') + " " + guest.Age.PadLeft(2) + "  #" + guest.room.RoomNumber.PadRight(2) + " - " + guest.payment.PaymentType + "\n");

            string filePathRoomList = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "room-list" + ".txt";
            File.AppendAllText(filePathRoomList, guest.room.RoomNumber + "\n");
        }

        // This method displays the confirmation page
        private void ShowConfirmationForm(string confNumber)
        {
            CheckInConfirmation_Form form = new();  // pass confirmation number to the label in #CheckInConfirmation_Form 
            form.changeLabel(confNumber);           // update the label
            this.Hide();                            // Hide current form   
            form.ShowDialog();                      // Display #CheckInConfirmation_Form
            this.Close(); 
        }

        public void AvailableRooms()
        {
            List<Guest> availableRoomsList = db.GetAvailableRoomsList();
            foreach (var guest in availableRoomsList)
            {
                    AvailableRoom_richTextBox.Text += "Room: " + guest.room.RoomNumber + " - " + "Beds: " + guest.room.BedConfiguration + "\n";
                    Available_Rooms_ComboBox.Items.Add(guest.room.RoomNumber);
            }
        }

        private void StayLength_Selector_ValueChanged(object sender, EventArgs e)
        {
            payment.Price = (double)payment.CalculatePrice(Convert.ToDecimal(BedConfig_Value_Label.Text), Convert.ToInt32(StayLength_ComboBox.Text));
            Price_Value_Label.Text = "$"+payment.Price.ToString();
        }

        decimal BedNumber()
        {
            if (Convert.ToInt32(Available_Rooms_ComboBox.Text) <= 15)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        private void Available_Rooms_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BedConfig_Value_Label.Text = BedNumber().ToString();
            payment.Price = (double)payment.CalculatePrice(Convert.ToDecimal(BedConfig_Value_Label.Text), Convert.ToInt32(StayLength_ComboBox.Text));
            Price_Value_Label.Text = "$" + payment.Price.ToString();
        }

        private void StayLength_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BedConfig_Value_Label.Text = BedNumber().ToString();
            payment.Price = (double)payment.CalculatePrice(Convert.ToDecimal(BedConfig_Value_Label.Text), Convert.ToInt32(StayLength_ComboBox.Text));
            Price_Value_Label.Text = "$" + payment.Price.ToString();
        }
    }
}

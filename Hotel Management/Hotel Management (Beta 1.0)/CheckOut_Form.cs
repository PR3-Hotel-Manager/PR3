using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management__Beta_1._0_
{
    public partial class CheckOut_Form : Form
    {
        FirebaseSingleton db = FirebaseSingleton.Instance;
        Guest dbGuest;
        Dictionary<string, Guest> dbGuestDictionary;

        public CheckOut_Form()
        {
            InitializeComponent();
            OccupiedeRooms();
        }
        private void CheckOut_Form_Load(object sender, EventArgs e)
        {
            db.StartFirebase();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();  // Exit CheckOut Form
        }

        // This method performs check-out
        private void OK_Button_Click(object sender, EventArgs e)
        {
            performCheckout(Occupied_Rooms_ComboBox.Text);
        }

        // This method checks out a guest from the database
        public Boolean performCheckout(string occupiedRoomNumber)
        {
            Boolean isCheckedOut = false;
            try
            {
                dbGuestDictionary = db.GetDatabaseGuestDictionary();
                string dbGuestKey = K.GuestKey(occupiedRoomNumber);
                dbGuest = dbGuestDictionary[dbGuestKey];
                if (dbGuest.room.Occupied)
                {
                    Guest emptyGuest = new Guest(occupiedRoomNumber);
                    db.InsertGuest(emptyGuest);
                    UpdateLogFile(dbGuest);
                    MessageBox.Show("Check out successful. Room: " + occupiedRoomNumber + " is now availabe.", " ", MessageBoxButtons.OK);
                    isCheckedOut = true;
                }
                else // If room is not occcupied, display error message
                {
                    MessageBox.Show("This room is not occupied.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return isCheckedOut;
        }

        // This method saves checkout details in a local log file
        private void UpdateLogFile(Guest guest)
        {
            // Save to Log File
            string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
            File.AppendAllText(filePath, DateTime.Now.ToString("HH:mm:ss") + "|Chk-Out| " + guest.FirstName.PadRight(15, ' ') + " " + guest.LastName.PadRight(20, ' ') + " " + guest.Age.PadLeft(2) + "  #" + guest.room.RoomNumber.PadRight(2) + " - " + guest.payment.PaymentType + "\n");
            this.Close();
        }
        
        public void OccupiedeRooms()
        {
            List<Guest> occupiedRoomsList = db.GetOccupiedRoomsList();
            foreach (var guest in occupiedRoomsList)
            {
                    Occupied_Rooms_ComboBox.Items.Add(guest.room.RoomNumber);
            }
        }

    }
}

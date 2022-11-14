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
        Dictionary<string, Guest> guestDictionary;

        public CheckOut_Form()
        {
            InitializeComponent();
        }
        private void CheckOut_Form_Load(object sender, EventArgs e)
        {
            db.StartFirebase();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();  // Exit CheckOut Form
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            guestDictionary = db.GetGuestDictionary();
            if (guestDictionary == null)
            {
                MessageBox.Show("Data is null.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var roomNumber = Room_Selector.Value.ToString();
                var firebaseKey = K.FirebaseKey(roomNumber);
                Guest guest = guestDictionary[firebaseKey];
                if (guest.room.Occupied)
                {
                    Guest emptyGuest = new Guest(roomNumber);
                    db.InsertGuest(emptyGuest);
                    UpdateLogFile(guest);
                }
                else
                {
                    MessageBox.Show("This room is not occupied.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateLogFile(Guest guest)
        {
            // Save to Log File
            string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
            File.AppendAllText(filePath, DateTime.Now.ToString("HH:mm:ss") + "|Chk-Out| " + guest.FirstName.PadRight(15, ' ') + " " + guest.LastName.PadRight(20, ' ') + " " + guest.Age.PadLeft(2) + "  #" + guest.room.RoomNumber.PadRight(2) + " - " + guest.payment.PaymentType + "\n");

            this.Close();

            MessageBox.Show("Check out successful. Room: " + Room_Selector.Value.ToString() + " is now availabe.", " ", MessageBoxButtons.OK);
        }


    }
}

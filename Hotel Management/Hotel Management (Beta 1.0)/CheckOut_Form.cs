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
            try
            {

                FirebaseResponse res = db.client.Get(@K.FirebaseTopFolder);
                if (res.Body.ToString() == "null")
                {
                    MessageBox.Show("No one is Check-in.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Dictionary<string, FlattenGuest> data = JsonConvert.DeserializeObject<Dictionary<string, FlattenGuest>>(res.Body.ToString());
                    var roomNumber = Room_Selector.Value.ToString();
                    var firebaseKey = K.FirebaseKey(roomNumber);
                    if (data[firebaseKey].Occupied)
                    {
                        FlattenGuest guest = data[firebaseKey];
                        deleteGuest(guest, firebaseKey, roomNumber);
                    }
                    else
                    {
                        MessageBox.Show("This room is not occupied.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                    MessageBox.Show("Connection Error.");
            }
        }

        private void deleteGuest(FlattenGuest guest, string firebaseKey, string roomNumber)
        {
            // Save to Log File
            string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
            File.AppendAllText(filePath, DateTime.Now.ToString("HH:mm:ss") + "|Chk-Out| " + guest.FirstName.PadRight(15, ' ') + " " + guest.LastName.PadRight(20, ' ') + " " + guest.Age.PadLeft(2) + "  #" + guest.RoomNumber.PadRight(2) + " - " + guest.PaymentType + "\n");
            
            FlattenGuest flattenGuest = new FlattenGuest(roomNumber);
            db.client.Set(K.FirebaseTopFolder+"/" + firebaseKey, flattenGuest);

            this.Close();

            MessageBox.Show("Check out successful. Room: " + Room_Selector.Value.ToString() + " is now availabe.", " ", MessageBoxButtons.OK);
        }


    }
}

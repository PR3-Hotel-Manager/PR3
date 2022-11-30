using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using Microsoft.VisualBasic;

namespace Hotel_Management__Beta_1._0_
{
    public partial class Main_Form : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        FirebaseSingleton db = FirebaseSingleton.Instance;

        public Main_Form()
        {
            InitializeComponent();
            // Use .ShowDialog() method to only keep the new Form active and prevent interference.
        }

        // Movable Main-Form
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Title_Label.FlatStyle = FlatStyle.Standard;
            Title_Label.Parent = Title_Holder;
            Title_Label.BackColor = Color.Transparent;

            checkConnection();
            InitGuestData();
        }
        
        // This method checks for internet connection status
        async private void checkConnection()
        {
            db.StartFirebase();

            Ping pingSignal = new Ping();
            string hostName = "www.google.com";

            byte[] buffer = new byte[32];
            int timeOut = 4000;

            connectionStatus_Label.Text = "Checking Connection...";

            try
            {
                PingOptions options = new PingOptions();
                PingReply reply = pingSignal.Send(hostName, timeOut, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    await Task.Delay(TimeSpan.FromSeconds(1)); // Wait 1 second before displaying result
                    connectionStatus_Label.Text = "Connected"; // Update Label text
                    RetryConnecting_Button.Enabled = false;
                    await Task.Delay(TimeSpan.FromSeconds(1.5));
                    databaseConnectionStatus_Panel.Visible = false;
                    CheckIn_Button.Enabled = true;
                    CheckOut_Button.Enabled = true;
                    Capacity_Button.Enabled = true;
                    LookUp_Button.Enabled = true;
                    Report_Button.Enabled = true;
                    Estimate_Button.Enabled = true;

                }

            }

            catch (Exception)
            {
                await Task.Delay(TimeSpan.FromSeconds(1)); // Wait 1 second before displaying result
                connectionStatus_Label.Text = "Unable to Connect."; // Update Label text
                RetryConnecting_Button.Enabled = true;
                databaseConnectionStatus_Panel.Visible = true;
                CheckIn_Button.Enabled = false;
                CheckOut_Button.Enabled = false;
                Capacity_Button.Enabled = false;
                LookUp_Button.Enabled = false;
                Report_Button.Enabled = false;
            }
        }

        // Populates Firebase Realtime database with empty guests objects if dataabase is empty
        // Number of empty guests is equal to K.NumberOfRooms in K Class
        private void InitGuestData()
        {
            try
            {
                if (db.GetMainFormFirebaseResponse().Body.ToString() == "null")
                {
                    Dictionary<string, Guest> initialGuestDictionary = new Dictionary<string, Guest>();
                    for (var i = 0; i < K.NumberOfRooms; i++)
                    {
                        int roomNumber = i + 1;
                        Guest guest = new Guest(roomNumber.ToString());
                        string guestKey = K.GuestKey(guest.room.RoomNumber);
                        initialGuestDictionary.Add(guestKey, guest);
                    }
                    db.InsertGuestDictionary(initialGuestDictionary);
                }
                else
                {
                    MessageBox.Show("Firebase database has been previously initialized with rooms. Press OK to continue.", "Notification:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckIn_Button_Click(object sender, EventArgs e)
        {
            CheckIn_Form form_CheckIn = new CheckIn_Form();
            form_CheckIn.ShowDialog();
        }

        private void CheckOut_Button_Click(object sender, EventArgs e)
        {
            CheckOut_Form form_CheckOut = new CheckOut_Form();
            form_CheckOut.ShowDialog();
        }

        private void Capacity_Button_Click(object sender, EventArgs e)
        {
            Rooms_Form form_Capacity = new Rooms_Form();
            form_Capacity.ShowDialog();
        }

        private void LookUp_Button_Click(object sender, EventArgs e)
        {
            LookUp_Form form_LookUp = new LookUp_Form();
            form_LookUp.ShowDialog();
        }

        private void Report_Button_Click(object sender, EventArgs e)
        {
            Report_Form form_Report = new Report_Form();
            form_Report.ShowDialog();
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RetryConnecting_Button_Click(object sender, EventArgs e)
        {
            checkConnection();
        }

        private void Title_Holder_Click(object sender, EventArgs e)
        {

        }

        private void databaseConnectionStatus_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Estimate_Button_Click(object sender, EventArgs e)
        {
            Estimate_Form form_Estimate= new Estimate_Form();
            form_Estimate.ShowDialog();
        }
    }
}

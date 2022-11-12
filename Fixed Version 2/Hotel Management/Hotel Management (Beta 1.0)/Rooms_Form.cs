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

        static readonly IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = Constants.AuthSecret,
            BasePath = Constants.BasePath
        };

        public IFirebaseClient client;
        async private void checkConnection()
        {

            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("Unable to establish connection.");

            }

        }
        public Rooms_Form()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void checkRooms()
        {

            try
            {
                FirebaseResponse res = client.Get(@"FlattenGuest");
                Dictionary<string, FlattenGuest> data = JsonConvert.DeserializeObject<Dictionary<string, FlattenGuest>>(res.Body.ToString());
                if (res.Body.ToString() == "null")
                {
                    MessageBox.Show("No one is Check-in.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var i in data.Values)
                    {
                        if (i.Occupied)
                        {
                            String s = i.RoomNumber + "\n";
                            Occupied_RichTextBox.Text += s;
                        }
                        else
                        {
                            Empty_richTextBox.Text += i + "\n";
                        }
                    }
                }
 
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error.");
            }
        }
        private void Rooms_Form_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
 
            checkConnection();
            this.BringToFront();
            this.Show();

            checkRooms();
      
        }
    }
}

using FireSharp.Config;
using FireSharp.Interfaces;
using System.Collections.Generic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;

namespace Hotel_Management__Beta_1._0_
{
    public partial class LookUp_Form : Form
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
        public LookUp_Form()
        {
            InitializeComponent();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Name_TextBox.Text = "";
            LastName_TextBox.Text = "";
        }

        void performSearch() {

            
            bool match = false;

            for (int i = 1; i <= 40; i++)
            {
                var get = client.Get("Room/" + i);
                Guest instance = get.ResultAs<Guest>();

                if (get != null && instance != null)
                {
                    if (instance.FirstName == Name_TextBox.Text || instance.LastName == LastName_TextBox.Text)
                    {
                        result_TextBox.Text += instance.FirstName + ", " + instance.LastName + ", #" + instance.room.RoomNumber + ", Chk-in time: " + instance.payment.Time + "\n";
                        match = true;
                    }

                }

                progressBar.Value = i;
            }

            if (match == false)
            {
                result_TextBox.Text = "No results found.";
            }
            

        }
        private void Search_button_Click(object sender, EventArgs e)
        {
            result_TextBox.Text = "";
            progressBar.Visible = true;

            checkConnection();
            performSearch();

            progressBar.Visible = false;
            progressBar.Value = 0;
        }
    }
}

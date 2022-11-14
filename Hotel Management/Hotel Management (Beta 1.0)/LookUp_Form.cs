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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management__Beta_1._0_
{
    public partial class LookUp_Form : Form
    {
        FirebaseSingleton db = FirebaseSingleton.Instance;
        Dictionary<string, Guest> data;

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
            data = db.GetData();
            if (data == null)
            {
                MessageBox.Show("Data is null.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int progressBarValue = 1;
                foreach (var guest in data.Values )
                {
                    if ((guest.FirstName == Name_TextBox.Text && Name_TextBox.Text != "") || (guest.LastName == LastName_TextBox.Text && LastName_TextBox.Text != ""))
                    {
                        result_TextBox.Text += guest.FirstName + ", " + guest.LastName + ", #" + guest.room.RoomNumber + ", Chk-in time: " + guest.payment.Time + "\n";
                        match = true;
                    }
                }
                progressBar.Value = progressBarValue++;
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

            db.StartFirebase();
            performSearch();

            progressBar.Visible = false;
            progressBar.Value = 0;
        }
    }
}

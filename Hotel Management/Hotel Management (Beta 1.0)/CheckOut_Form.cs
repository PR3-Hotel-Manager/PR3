using FireSharp.Config;
using FireSharp.Interfaces;
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
        static readonly IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = Constants.AuthSecret,
            BasePath = Constants.BasePath
        };

        public IFirebaseClient client;
        public CheckOut_Form()
        {
            InitializeComponent();
        }

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
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();  // Exit CheckOut Form
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            try
            {
                try // check if room is occupied 
                {
                    var result = client.Get("Room/" + Room_Selector.Value.ToString());
                    Guest customer = result.ResultAs<Guest>();

                    // Save to Log File
                    string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
                    File.AppendAllText(filePath, DateTime.Now.ToString("HH:mm:ss") + "|Chk-Out|  " + customer.FirstName.PadRight(15, ' ') + " " + customer.LastName.PadRight(20, ' ') + " " + customer.Age.PadLeft(2) + "  #" + Room_Selector.Value.ToString().PadRight(2) + "\n");

                }
                catch (Exception)
                {
                    MessageBox.Show("This room is not occupied.");

                }

                var delete = client.Delete("Room/" + Room_Selector.Value.ToString());

            }
            catch (Exception)
            {
            
                MessageBox.Show("Connection Error.");
            }

          

        }

        private void CheckOut_Form_Load(object sender, EventArgs e)
        {
            checkConnection();
        }
    }
}

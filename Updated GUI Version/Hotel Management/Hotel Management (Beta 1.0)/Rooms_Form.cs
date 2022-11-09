using FireSharp.Config;
using FireSharp.Interfaces;
using System.Reflection;

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
            int available = 40;

            for (int i = 1; i <= 40; i++)
            {
                var get = client.Get("Room/" + i);
                Guest customer = get.ResultAs<Guest>();

                if (get != null && customer != null)
                {
                    Occupied_RichTextBox.Text += i + "\n";
                    available--;
                }
                else
                {
                    Empty_richTextBox.Text += i + "\n";
                 

                }
                progressBar1.Value = i;
                AvailableRooms_Label.Text = "Available Rooms: " + available;
            }

           
            progressBar1.Visible = false;
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

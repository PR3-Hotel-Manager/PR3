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

namespace Hotel_Management__Beta_1._0_
{
    public partial class CheckIn_Form : Form
    {
        public CheckIn_Form()
        {
            InitializeComponent();
        }

        // Connect using FireSharp
        static readonly IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = Constants.AuthSecret,
            BasePath = Constants.BasePath
        };

        public IFirebaseClient client;
        private void CheckIn_Form_Load(object sender, EventArgs e)
        {

            checkConnection();

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

        bool verifyInputs()  // returns false if conditions are not met.
        {
            if (LastName_TextBox.Text == "" || Name_TextBox.Text == "")
            {
                return false;  // Check if TextBoxes are empty.
            }

            if (Name_TextBox.Text.All(Char.IsLetter) == false || LastName_TextBox.Text.All(Char.IsLetter) == false)
            {
                return false;   // Check if TextBoxes contain only letters.
            }

            else
                return true;

        }

        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        public static string getHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();

        }

        string transactionTime()
        {
            return DateTime.Now.ToString("mm/dd/yyyy h:mm:ss tt"); 

        }
        string retrievePaymentMethod()
        {
            if (Cash_RadioButton.Checked == true) {
                return "Cash";
            }
            else
                return "Credit/Debit";
        }
        public string pmtMethodLabel(string text)
        {
            if (text == "Credit/Debit")
                return "C/D";

            else
                return "C";
        }
        public void performCheckIn()
        {
            // Prepare Confirmation Number
            string guestDetails = Name_TextBox.Text + LastName_TextBox.Text + transactionTime();
            string temp = getHashString(guestDetails);
            string confNumber = temp.Substring(temp.Length - (temp.Length / 4));


            // Get Payment Method
            string pmtMethod;
            pmtMethod = retrievePaymentMethod();

            // Get Name, Last Name, Age, Bed, Price, Room#, Stay Length
            // Add fields to Database
            Guest customer = new Guest()
            {
                FirstName = Name_TextBox.Text,
                LastName = LastName_TextBox.Text,
                Age = Age_Selector.Value.ToString(),
                BedConfiguration = BedConfig_Selector.Value.ToString(),
                Occupied = true
            };

            try
            {
                var setter = client.Set("Room/" + Room_Selector.Value.ToString(), customer);

                CheckInConfirmation_Form form = new();  // pass confirmation number to the label in #CheckInConfirmation_Form 
                form.changeLabel(confNumber);
                this.Hide();
                form.ShowDialog(); // Display #CheckInConfirmation_Form
                this.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error.", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
           

            // Save to Log File
            string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
            File.AppendAllText(filePath, DateTime.Now.ToString("HH:mm:ss") + "|Chk-in|  " + customer.FirstName.PadRight(15,' ') + " " + customer.LastName.PadRight(20,' ') + " " + customer.Age.PadLeft(2) + "  #" + Room_Selector.Value.ToString().PadRight(2) + " - " + pmtMethodLabel(pmtMethod) + "\n");

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close(); // Cancel & Exit CheckIn Form
        }
   
        private void OK_Button_Click(object sender, EventArgs e)
        {

            if (verifyInputs() == true) // If input fields are verified, perform check-in.
            {
                performCheckIn();            

            }

            else   // Else; Display Error Message.
            {
                MessageBox.Show("Input fields are missing or contain numbers. Please try again.", " Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management__Beta_1._0_
{
    public partial class CheckInConfirmation_Form : Form
    {
        public CheckInConfirmation_Form()
        {
            InitializeComponent();
        }
    
        // This method is unused.
        private void CheckInConfirmation_Form_Load(object sender, EventArgs e)
        {

        }

        // This method updates the label, and displays the Confirmation number 
        public void changeLabel(string Text)
        {
            ConfirmationNumber_Label.Text = Text;

        }
        
        // This method closes the form and resets the label
        public void Quit()
        {
            ConfirmationNumber_Label.Text = "";
            this.Close();
        }
        
        private void OK_Button_Click(object sender, EventArgs e)
        {
            Quit();
        }
    }
}

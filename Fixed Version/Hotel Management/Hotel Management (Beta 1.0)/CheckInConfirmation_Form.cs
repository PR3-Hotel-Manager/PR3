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

        private void CheckInConfirmation_Form_Load(object sender, EventArgs e)
        {

        }

        public void changeLabel(string Text)
        {
            ConfirmationNumber_Label.Text = Text;

        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            ConfirmationNumber_Label.Text = "";
            this.Close();
        }
    }
}

//--Date--
//11/23/2022
//
//--Programmers Name--
//Ralph, Michael, Ziv, & Raymond
//
//--Brief Descirption of Module--
//This module is designed to give an estimate for the customer requesting a stay at the hotel
//
//--Brief explanation of important functions in each class, including its input values and output values--
//For this module, we utilzie the payment class and the claculatePrice() method. This method allows for a price...
//to be calculated. Arguments passed include bed number and stay length.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management__Beta_1._0_
{
    public partial class Estimate_Form : Form
    {
      
        Payment payment = new Payment();

        public Estimate_Form()
        {
            InitializeComponent();
        }

        private void StayLength_Selector_Estimate_ValueChanged(object sender, EventArgs e)
        {
            updateLabel();
        }

        private void Bed_Selector_ValueChanged(object sender, EventArgs e)
        {
            updateLabel();
        }

        void updateLabel()
        {
            Estimate_Price_Placeholder.Text = "$" + payment.CalculatePrice(Bed_Selector.Value, StayLength_Selector_Estimate.Value).ToString() + ".00";
        }
        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Estimate_Form_Load(object sender, EventArgs e)
        {
            updateLabel();
        }
    }
}

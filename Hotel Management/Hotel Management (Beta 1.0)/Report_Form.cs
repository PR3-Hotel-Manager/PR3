using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management__Beta_1._0_
{
    public partial class Report_Form : Form
    {

        private int findPosition = 0;
        public Report_Form()
        {
            InitializeComponent();
        }

        private void Report_Form_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now.AddDays(-4);

        }

        private void View_Button_Click(object sender, EventArgs e)
        {
         
            string fileDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");

            string filePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + fileDate + ".txt";

            if (File.Exists(filePath))
            {
                Report_TextBox.Text = File.ReadAllText(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + fileDate + ".txt");
            }

            else
            {
                MessageBox.Show("Unable to find Log file.", " Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Report_TextBox.Text = "";
                
            }

        }

        private void Report_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Find_Button_Click(object sender, EventArgs e)
        {
            Report_TextBox.SelectAll();
            Report_TextBox.SelectionBackColor = Color.White; // Reset Highlighter

            int index = Report_TextBox.Find(find_textBox.Text.ToString(), RichTextBoxFinds.None);
            while (index >= 0)
            {
                Report_TextBox.SelectionBackColor = Color.Yellow;
                index = Report_TextBox.Find(find_textBox.Text.ToString(), index + 1, RichTextBoxFinds.None);
            }
        }

        private void find_textBox_TextChanged(object sender, EventArgs e)
        { 

        }
    }
}

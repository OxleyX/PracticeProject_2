using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B1231818_洪順義_Week4_2_作業
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Parse the age value from the TextBox
            if (int.TryParse(textBox1.Text, out int wage))
            {
                // Call the GetTicketType method to get the ticket type message
                string salary = HourlyWage(wage);

                // Display the ticket type message in the result label
                lblResult.Text += "\n" + salary;
            }
            else
            {
                MessageBox.Show("Please enter a valid age.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
        private string HourlyWage(int wage)
        {
            if (wage < 120)
            {
                return " " + wage + " 是低時薪";
            }
            else if (wage >= 300)
            {
                return " " + wage + " 是超超高時薪";
            }
            else 
            {
                return " " + wage + " 是高時薪";
            }
        }
    }
}

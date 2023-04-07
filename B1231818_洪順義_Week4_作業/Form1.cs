using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace B1231818_洪順義_Week4_作業
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MsgBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Parse the age value from the TextBox
            if (int.TryParse(MsgBox.Text, out int age))
            {
                // Call the GetTicketType method to get the ticket type message
                string ticketType = GetTicketType(age);

                // Display the ticket type message in the result label
                lblResult.Text += "\n" + ticketType;
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

        private string GetTicketType(int age)
        {
            if (age >= 20 && age <= 64)
            {
                return " " + age + " 嵗 購買 普通票";
            }
            else if (age <= 10)
            {
                return " " + age + " 嵗 購買 復待票";
            }
            else
            {
                return " " + age + " 嵗 購買 復待票";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeAssigment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnshowData_Click(object sender, EventArgs e)
        {
            String day_of_the_week = txtdayOfWeek.Text;
            String name_of_the_month = txtmonth.Text;
            int numeric_day = int.Parse(txtmonthNumeric.Text);
            int Year = int.Parse(txtyear.Text);

            String Full_date = day_of_the_week + ", " + name_of_the_month + " " + numeric_day + ", " + Year;

            lbloutput.Text = Full_date;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdayOfWeek.Clear();
            txtmonth.Clear();
            txtmonthNumeric.Clear();
            txtyear.Clear();

            // Clear the output label - not used clear function because it is not a text box
            lbloutput.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // Close the form - using this keyword and close function to close the form
            this.Close();
        }
    }
}

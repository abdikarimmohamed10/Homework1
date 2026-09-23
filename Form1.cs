using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();  
            txtsememster.Clear();
            lblouput.Text = "";
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txtname.Text;
            int studentID = int.Parse(txtstudentid.Text);
            String Department = txtdepartment.Text;
            int semester = int.Parse(txtsememster.Text);
            String output= "Name: " + name + "\nStudent ID: " + studentID + "\nDepartment: " + Department + "\nSemester: " + semester;

            lblouput.Text = txtname.Text + " " + txtstudentid.Text + " " + txtdepartment.Text + " " + txtsememster.Text;    
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderReceiptGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;


            name = (this.textBox1.Text);
            this.label8.Text = "Name: " + textBox1.Text;

            string address;
            address = (this.textBox2.Text);
            this.label9.Text = "Address: " + textBox2.Text;

            //hold space for city, state and zip
            string city;
            string state;
            string zip;
            city = (this.textBox3.Text);
            state = (this.textBox4.Text);
            zip = (this.textBox5.Text);
            this.label10.Text = "Address Line 2: " + city + ", " + state + " " + zip;

            string blenderString;
            int blenderInt;
            blenderString = (this.textBox6.Text);
            blenderInt = Convert.ToInt32(blenderString);
            this.label11.Text = "Blenders Ordered: " + blenderInt;

            double amt;
            amt = (blenderInt * 39.95);
            this.label13.Text = "Amount Due " + amt.ToString("C");

            const double Sales_Tax = 0.07;
            double taxAmt;
            taxAmt = (amt * Sales_Tax);
            this.label14.Text = "Tax: " + taxAmt.ToString("C");

            double netDue;
            netDue = (taxAmt + amt);
            this.label15.Text = "Total: " + netDue.ToString("C");



           

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CH3PayrollGUI
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
            string ssn;
            double payRate;
            double hoursWorked;
            double grossPay;
            const double Fed = 0.15;
            const double State = 0.05;
            double netPay;
           

            name = (this.textBox1.Text);
            this.label9.Text = textBox1.Text;

          
            ssn = (this.textBox2.Text);
            this.label10.Text = textBox2.Text;

            
            payRate = Convert.ToDouble(this.textBox3.Text);
            this.label11.Text = payRate.ToString("C");

           
            hoursWorked = Convert.ToDouble(this.textBox4.Text);
            this.label12.Text = textBox4.Text;

            
           
            grossPay = payRate * hoursWorked;
            label13.Text = "Gross pay is " + grossPay.ToString("C");


           
            double fedTax = Fed * grossPay;
            this.label14.Text = "Federal withheld is " + fedTax.ToString("C");

            
            double stateTax = State * grossPay;
            this.label15.Text = "State tax is " + stateTax.ToString("C");

           
            netPay = stateTax + fedTax - grossPay;
            this.label16.Text = "Net pay is " + netPay.ToString("C");



            



            
            







            

            

   
       }
    }
}

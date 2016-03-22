using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiplicationGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(numberTextbox.Text);
            MultiplicationTable(num);
        }
        public void MultiplicationTable(int num)
        {
          for(int factor = 2; factor < 11; ++factor)
            outLabel.Text += String.Format("{0} * {1} = {2}\n", num, factor, num * factor);
        }
    }
}

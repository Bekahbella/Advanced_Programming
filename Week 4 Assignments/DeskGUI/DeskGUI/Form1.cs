using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeskGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
 
          
            
            DeskCost();
        }
            

        public int  NumOfDrawers()
        {
            string drawers;
            int drawerInt;

    
            drawers = (this.textBox1.Text);
            drawerInt = Convert.ToInt32(drawers);
            return drawerInt;
            


        }

        public string PickWoodType()
        {
            
            string woodType;
            
           

            
            woodType = (this.textBox2.Text);

            
            switch (woodType)
            {
                case "p":
                    woodType = "Pine";
                    break;
                case "o":
                    woodType = "Oak";
                    break;
                case "m":
                    woodType = "Mahogany";
                    break;
                default:
                    woodType = ("Invalid");
                    break;
            }


            return woodType;


        }

        public  void DeskCost()
        {
            string wood = PickWoodType();
            double woodCost; 


            switch (wood)
            {
                case "Pine":
                    woodCost = 100.00;
                    break;
                case "Oak":
                    woodCost = 140.00;
                    break;
                case "Mahogany":
                    woodCost = 180.00;
                    break;
                default:
                    woodCost = 0.00;
                    break;
                    
            }
        
            
            this.label2.Text = "Wood Chosen: " + wood;
            this.label6.Text = "Wood Cost: " + woodCost;

            
            double deskPrice;
            double totalDrawerCost;
            const double drawerBase = 30.00;
            int drawerTotal;

            drawerTotal = (NumOfDrawers());
            totalDrawerCost = (drawerTotal * drawerBase);
            this.label4.Text = "Drawer Cost : " + totalDrawerCost.ToString("C");
            
            deskPrice = (totalDrawerCost + woodCost);
            
            this.label5.Text = "Total Cost: " + deskPrice.ToString("C");

           

  

        }

      

       
    }
}


        

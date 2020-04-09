//Programmer: Mary Fischer
//Email: mfischer7@cnm.edu
//Form1.cs


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FischerP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //instantiate the class object with the overloaded constructor with 2 parameters
                LogoOrderItem item = new LogoOrderItem(ckbxLogo.Checked, tbTextToPrint.Text); 

                //set the properties
                item.ItemID = int.Parse(tbOrderNumber.Text);
                item.NumItems = int.Parse(tbNumItems.Text);
                item.Text = tbTextToPrint.Text;
                item.NumColors = int.Parse(tbNumColors.Text);

                //set the item types from the radio buttons
                if (rbMug.Checked)
                {
                    item.ItemType = rbMug.Text;
                }
                else if (rbPen.Checked)
                {
                    item.ItemType = rbPen.Text;
                }
                else
                {
                    item.ItemType = rbUSB.Text;
                }

                //set the output message
                tbOrderSummary.Text = item.GetOrderSummary();
            }
            catch (Exception exc)
            {
                tbOrderSummary.Text = exc.Message;
            }
        }

        //reset all the fields in the form
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbOrderNumber.Text = "1";
            tbNumItems.Text = "";
            rbUSB.Checked = true;
            rbMug.Checked = false;
            rbPen.Checked = false;
            ckbxLogo.Checked = false;
            tbOrderSummary.Text = "";
            tbTextToPrint.Text = "";
            tbNumColors.Text = "0";
        }
        
        //number of colors text box and label are only visible if logo checkbox is checked
        private void ckbxLogo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckbxLogo.Checked == true)
            {
                lblNumColors.Visible = true;
                tbNumColors.Visible = true;
            }
            else
            {
                lblNumColors.Visible = false;
                tbNumColors.Visible = false;
            }
        }
    }
}

  
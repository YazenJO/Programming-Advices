using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pizza_Project
{
    public partial class frmPizzaMenu : Form
    {

        public frmPizzaMenu()
        {
            InitializeComponent();
        }
        float GetSelectedSizePrice()
        {
            if (rdSmall.Checked)
            
                return Convert.ToSingle(rdSmall.Tag);
            
            else if (rdMeduim.Checked)
            
                return Convert.ToSingle(rdMeduim.Tag);
            
            else if (rdLarge.Checked)
            

                return Convert.ToSingle(rdLarge.Tag);
            return 0;
           
        } 
        float GetGetSelectedToppingPrice() {
            float TotalToppingPrice = 0;
            if (chkExtraChees.Checked)
                TotalToppingPrice += Convert.ToSingle(chkExtraChees.Tag);

            if (chkMuchrooms.Checked)
                TotalToppingPrice += Convert.ToSingle(chkMuchrooms.Tag);
            if (chkTomatoes.Checked)
                TotalToppingPrice += Convert.ToSingle(chkTomatoes.Tag);
            if (chkOnion.Checked)
                TotalToppingPrice += Convert.ToSingle(chkOnion.Tag);
            if (chkOlives.Checked)
                TotalToppingPrice += Convert.ToSingle(chkGreen.Tag);
            if (chkGreen.Checked)
                TotalToppingPrice += Convert.ToSingle(chkGreen.Tag);

            return TotalToppingPrice;
        }
        float GetSelectedCrustPrice()
        {
            if (rdThin.Checked)
                return Convert.ToSingle(rdThin.Tag);
            else if (rdThick.Checked)
                return Convert.ToSingle(rdThick.Tag); return 0;
        }
        float ClaculateTotalPrice()
        {

            return ((GetSelectedSizePrice() + GetGetSelectedToppingPrice() + GetSelectedCrustPrice()) * (float)numericUpDown1.Value);


        }
        void UpdateTotalPrice()
        {

            lbTotal.Text = "$" + ClaculateTotalPrice().ToString();

        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rdSmall.Checked)
            {
                lbSize.Text = "Small";
                return;
            }
            else if (rdMeduim.Checked)
            {
                lbSize.Text = "Meduim";
                return;
            }
            else if (rdLarge.Checked)
            {
                lbSize.Text = "Large";
                return;
            }
        }
        void UpdateToppings()
        {
            string sTopping = "";
            UpdateTotalPrice();
            if (chkExtraChees.Checked)
                sTopping += "ExtraCheese";
            if(chkGreen.Checked)
                sTopping += " ,Green";
            if (chkMuchrooms.Checked)
                sTopping += "\n ,Muchrooms";
            if (chkOnion.Checked)
                sTopping += "\n ,Onion";
            if (chkTomatoes.Checked)
                sTopping += " ,Tomatoes";
            if (chkOlives.Checked)
                sTopping += " ,Olives";

           lbToppings.Text = sTopping;



        }
        void UpdateCrust()
        {
           UpdateTotalPrice() ;
            if (rdThin.Checked)
                lbCrust.Text = "Thin";
            else if (rdThick.Checked)
            {
                lbCrust.Text = "Thick";
            }


        }
       void UpdateWhereToEat()
        {
            if (rdEatIn.Checked)
                lbWhereToEat.Text = "Eat In";
            else if (rdEatOut.Checked)
                lbWhereToEat.Text = "Eat Out";
        }
        void Update()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void frmPizzaMenu_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

            private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbSize_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void lbTotal_Click(object sender, EventArgs e)
        {
             
        }


        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rdThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdCru_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkt1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
          }

        private void chkt2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkt3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rdSmall_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void rdSmall_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void rdLarge_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rdEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void gpWhtoeat_Enter(object sender, EventArgs e)
        {

        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
               if(MessageBox.Show("Oreder Confirmed", "Sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    grpSize.Enabled = false;
                    grpToppings.Enabled = false;
                    grpCrust.Enabled = false;
                    grpSummary.Enabled = false;
                    grpWhereToEat.Enabled = false;

                }
        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
            chkMuchrooms.Checked = false;
            chkExtraChees.Checked = false;
            chkGreen.Checked = false;
            rdEatIn.Checked = false;
            rdEatOut.Checked = false;
            rdLarge.Checked = false;
            rdMeduim.Checked = false;
            rdSmall.Checked = false;
            rdThick.Checked = false;
            rdThin.Checked = false;
            grpSize.Enabled =      true;
            grpToppings.Enabled =  true;
            grpCrust.Enabled =     true;
            grpSummary.Enabled =   true;
            grpWhereToEat.Enabled =true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}

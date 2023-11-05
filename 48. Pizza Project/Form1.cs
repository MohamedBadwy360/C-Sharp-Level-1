using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48.Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);
        }

        float CalculateToppingsPrice()
        {
            float TroppingsPrice = 0;

            if (chkExtraCheese.Checked)
                TroppingsPrice += Convert.ToSingle(chkExtraCheese.Tag);
            if (chkGreenPeppers.Checked)
                TroppingsPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            if (chkMushrooms.Checked)
                TroppingsPrice += Convert.ToSingle(chkMushrooms.Tag);
            if (chkOlives.Checked)
                TroppingsPrice += Convert.ToSingle(chkOlives.Tag);
            if (chkOnion.Checked)
                TroppingsPrice += Convert.ToSingle(chkOnion.Tag);
            if (chkTomatoes.Checked)
                TroppingsPrice += Convert.ToSingle(chkTomatoes.Tag);

            return TroppingsPrice;
        }

        float GetSelectedCrustTypePrice()
        {
            if (rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else 
                return Convert.ToSingle(rbThick.Tag);    
        }

        float ClaculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() +
                GetSelectedCrustTypePrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + ClaculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThin.Checked)
            {
                lblCrustType.Text = "Thin";
                return;
            }
            else
            {
                lblCrustType.Text = "Thick";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";

            if (chkExtraCheese.Checked)
                Toppings += "Extra Cheese";
            if (chkGreenPeppers.Checked)
                Toppings += ", Green peppers";
            if (chkMushrooms.Checked)
                Toppings += ", Mushrooms";
            if (chkOlives.Checked)
                Toppings += ", Olives";
            if (chkOnion.Checked)
                Toppings += ", Onion";
            if (chkTomatoes.Checked)
                Toppings += "Tomatoes";

            if (Toppings.StartsWith(","))
                Toppings = Toppings.Substring(1, Toppings.Length - 1).Trim();

            if (Toppings == "")
                Toppings = " NoToppings";


            lblToppings.Text = Toppings;

        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat in";
                return;
            }
            else
            {
                lblWhereToEat.Text = "Eat out";
                return;
            }
        }
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbCrustType.Enabled = false;
                gbSize.Enabled = false;
                gbTroppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbCrustType.Enabled = true;
            gbSize.Enabled = true;
            gbTroppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;

            rbSmall.Checked = true;
            rbThin.Checked = true;
            rbEatIn.Checked = true;

            chkExtraCheese.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomatoes.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }
    }
}

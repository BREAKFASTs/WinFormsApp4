using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            txtCafeAmericano.Text = "0";
            txtCappucino.Text = "0";
            txtCaramelMacchiato.Text = "0";
            txtChaiLatte.Text = "0";
            txtFlatWhite.Text = "0";
            txtIcedCoffee.Text = "0";
            txtIcedMatchaLatte.Text = "0";
            txtMocha.Text = "0";
            txtNitroColdBrew.Text = "0";
            txtPumpkinSpiceLatte.Text = "0";
            txtStrawberryAcaiRefresher.Text = "0";
        }

        private void btnSubtractCafeAmericano_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtCafeAmericano, -1, 0, 999);
        }

        private void btnAddCafeAmericano_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtCafeAmericano, 1, 0, 999);
        }

        private void btnSubtractCaramelMacchiato_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtCaramelMacchiato, -1, 0, 999);
        }

        private void btnAddCaramelMacchiato_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtCaramelMacchiato, 1, 0, 999);
        }

        private void btnSubtractPumpkinSpiceLatte_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtPumpkinSpiceLatte, -1, 0, 999);
        }

        private void btnAddPumpkinSpiceLatte_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtPumpkinSpiceLatte, 1, 0, 999);
        }

        private void btnSubtractFlatWhite_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtFlatWhite, -1, 0, 999);
        }

        private void btnAddFlatWhite_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtFlatWhite, 1, 0, 999);
        }

        private void btnSubtractMocha_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtMocha, -1, 0, 999);
        }

        private void btnAddMocha_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtMocha, 1, 0, 999);
        }

        private void btnSubtractIcedCoffee_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtIcedCoffee, -1, 0, 999);
        }

        private void btnAddIcedCoffee_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtIcedCoffee, 1, 0, 999);
        }

        private void btnSubtractChaiLatte_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtChaiLatte, -1, 0, 999);
        }

        private void btnAddChaiLatte_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtChaiLatte, 1, 0, 999);
        }

        private void btnSubtractCappucino_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtCappucino, -1, 0, 999);
        }

        private void btnAddCapuccino_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtCappucino, 1, 0, 999);
        }

        private void btnSubtractIcedMatchaLatte_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtIcedMatchaLatte, -1, 0, 999);
        }

        private void btnAddIcedMatchaLatte_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtIcedMatchaLatte, 1, 0, 999);
        }

        private void btnSubtractStrawberryAcaiRefresher_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtStrawberryAcaiRefresher, -1, 0, 999);
        }

        private void btnAddStrawberryAcaiRefresher_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtStrawberryAcaiRefresher, 1, 0, 999);
        }

        private void btnSubtractNitroColdBrew_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtNitroColdBrew, -1, 0, 999);
        }

        private void btnAddNitroColdBrew_Click(object sender, EventArgs e)
        {
            UpdateQuantity(txtNitroColdBrew, 1, 0, 999);
        }

        // Helper method to update the quantity in TextBox
        private void UpdateQuantity(TextBox textBox, int change, int min, int max)
        {
            if (int.TryParse(textBox.Text, out int currentValue))
            {
                currentValue += change;
                if (currentValue < min)
                {
                    currentValue = min;
                }
                else if (currentValue > max)
                {
                    currentValue = max;
                }
                textBox.Text = currentValue.ToString();
            }
            else
            {
                textBox.Text = "0"; // Reset to 0 if invalid input
            }
        }

        // The following are the TextChanged event handlers
        private void txtCafeAmericano_TextChanged(object sender, EventArgs e) { }

        private void txtCaramelMacchiato_TextChanged(object sender, EventArgs e) { }

        private void txtPumpkinSpiceLatte_TextChanged(object sender, EventArgs e) { }

        private void txtFlatWhite_TextChanged(object sender, EventArgs e) { }

        private void txtMocha_TextChanged(object sender, EventArgs e) { }

        private void txtIcedCoffee_TextChanged(object sender, EventArgs e) { }

        private void txtChaiLatte_TextChanged(object sender, EventArgs e) { }

        private void txtCappucino_TextChanged(object sender, EventArgs e) { }

        private void txtIcedMatchaLatte_TextChanged(object sender, EventArgs e) { }

        private void txtStrawberryAcaiRefresher_TextChanged(object sender, EventArgs e) { }

        private void txtNitroColdBrew_TextChanged(object sender, EventArgs e) { }

        private void txtOrderInformation_TextChanged(object sender, EventArgs e) { }

        private void txtTotalPurchased_TextChanged(object sender, EventArgs e) { }

        private void btnClear_Click(object sender, EventArgs e) { }

        private void btnOrder_Click(object sender, EventArgs e) { }

    }
}

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
        // Prices for each product in Philippine Pesos (PHP)
        private Dictionary<string, decimal> productPrices = new Dictionary<string, decimal>
        {
            { "Cafe Americano", 150 },
            { "Caramel Macchiato", 180 },
            { "Pumpkin Spice Latte", 200 },
            { "Flat White", 170 },
            { "Mocha", 160 },
            { "Iced Coffee", 140 },
            { "Chai Latte", 160 },
            { "Cappuccino", 180 },
            { "Iced Matcha Latte", 190 },
            { "Strawberry Acai Refresher", 220 },
            { "Nitro Cold Brew", 250 }
        };
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
            int quantity = int.Parse(txtCafeAmericano.Text);
            if (quantity > 0)
            {
                txtCafeAmericano.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddCafeAmericano_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtCafeAmericano.Text);
            if (quantity < 999)
            {
                txtCafeAmericano.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnSubtractCaramelMacchiato_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtCaramelMacchiato.Text);
            if (quantity > 0)
            {
                txtCaramelMacchiato.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddCaramelMacchiato_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtCaramelMacchiato.Text);
            if (quantity < 999)
            {
                txtCaramelMacchiato.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnSubtractPumpkinSpiceLatte_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtPumpkinSpiceLatte.Text);
            if (quantity > 0)
            {
                txtPumpkinSpiceLatte.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddPumpkinSpiceLatte_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtPumpkinSpiceLatte.Text);
            if (quantity < 999)
            {
                txtPumpkinSpiceLatte.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnSubtractFlatWhite_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtFlatWhite.Text);
            if (quantity > 0)
            {
                txtFlatWhite.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddFlatWhite_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtFlatWhite.Text);
            if (quantity < 999)
            {
                txtFlatWhite.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnSubtractMocha_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtMocha.Text);
            if (quantity > 0)
            {
                txtMocha.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddMocha_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtMocha.Text);
            if (quantity < 999)
            {
                txtMocha.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnSubtractIcedCoffee_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtIcedCoffee.Text);
            if (quantity > 0)
            {
                txtIcedCoffee.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddIcedCoffee_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtIcedCoffee.Text);
            if (quantity < 999)
            {
                txtIcedCoffee.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnSubtractChaiLatte_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtChaiLatte.Text);
            if (quantity > 0)
            {
                txtChaiLatte.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddChaiLatte_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtChaiLatte.Text);
            if (quantity < 999)
            {
                txtChaiLatte.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnSubtractCappucino_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtCappucino.Text);
            if (quantity > 0)
            {
                txtCappucino.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddCapuccino_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtCappucino.Text);
            if (quantity < 999)
            {
                txtCappucino.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnSubtractIcedMatchaLatte_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtIcedMatchaLatte.Text);
            if (quantity > 0)
            {
                txtIcedMatchaLatte.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddIcedMatchaLatte_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtIcedMatchaLatte.Text);
            if (quantity < 999)
            {
                txtIcedMatchaLatte.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnSubtractStrawberryAcaiRefresher_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtStrawberryAcaiRefresher.Text);
            if (quantity > 0)
            {
                txtStrawberryAcaiRefresher.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddStrawberryAcaiRefresher_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtStrawberryAcaiRefresher.Text);
            if (quantity < 999)
            {
                txtStrawberryAcaiRefresher.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnSubtractNitroColdBrew_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtNitroColdBrew.Text);
            if (quantity > 0)
            {
                txtNitroColdBrew.Text = (quantity - 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        private void btnAddNitroColdBrew_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtNitroColdBrew.Text);
            if (quantity < 999)
            {
                txtNitroColdBrew.Text = (quantity + 1).ToString();
            }
            UpdateOrderQuantities(); // Refresh the order information
        }

        // Helper method to update the quantity in TextBox
        private void UpdateOrderQuantities()
        {
            StringBuilder orderDetails = new StringBuilder();
            decimal totalAmount = 0;

            // Get all product quantities and calculate total amount
            var quantities = new Dictionary<string, TextBox>
            {
                { "Cafe Americano", txtCafeAmericano },
                { "Caramel Macchiato", txtCaramelMacchiato },
                { "Pumpkin Spice Latte", txtPumpkinSpiceLatte },
                { "Flat White", txtFlatWhite },
                { "Mocha", txtMocha },
                { "Iced Coffee", txtIcedCoffee },
                { "Chai Latte", txtChaiLatte },
                { "Cappuccino", txtCappucino },
                { "Iced Matcha Latte", txtIcedMatchaLatte },
                { "Strawberry Acai Refresher", txtStrawberryAcaiRefresher },
                { "Nitro Cold Brew", txtNitroColdBrew }
            };

            foreach (var product in quantities)
            {
                string productName = product.Key;
                TextBox textBox = product.Value;
                int quantity = int.Parse(textBox.Text);

                // Get the price from the dictionary
                if (productPrices.ContainsKey(productName))
                {
                    decimal price = productPrices[productName];
                    decimal totalProductPrice = quantity * price;

                    // Add product details to order info
                    orderDetails.AppendLine($"{productName}: {quantity} x ₱{price} = ₱{totalProductPrice}");

                    // Add to the total amount
                    totalAmount += totalProductPrice;
                }
            }

            // Add the total amount to the order information
            orderDetails.AppendLine($"Total: ₱{totalAmount}");

            // Update the Order Information TextBox with the new values
            txtOrderInformation.Text = orderDetails.ToString();
        }

        private void txtOrderInformation_TextChanged(object sender, EventArgs e) { }

        private void txtTotalPurchased_TextChanged(object sender, EventArgs e) 
        {

        }

        private void btnClear_Click(object sender, EventArgs e) 
        {
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
            txtOrderInformation.Text = "";
        }

        private void btnOrder_Click(object sender, EventArgs e) 
        {
            MessageBox.Show("Order has been placed!", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

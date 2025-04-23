using BLL;
using BLL.EntityManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaionLayer.ProductForms
{
    public partial class UpdateProduct : Form
    {
        Product product;
        public UpdateProduct(string prodId)
        {
            product = ProductManager.GetProductById(prodId);
            InitializeComponent();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {

            logout.ForeColor = Color.White;


            // Temporarily disable event handlers
            prodStock.TextChanged -= prodStock_TextChanged;
            prodPrice.TextChanged -= prodPrice_TextChanged;
            prodDiscount.TextChanged -= prodDiscount_TextChanged;

            // Assign values
            prodName.Text = product.name;
            prodStock.Text = product.stockQuantity.ToString();
            prodPrice.Text = product.price.ToString(CultureInfo.InvariantCulture);
            prodDiscount.Text = product.description;
            prodImg.Text = product.imgUrl;
            prodDesc.Text = product.description;

            // Re-enable event handlers
            prodStock.TextChanged += prodStock_TextChanged;
            prodPrice.TextChanged += prodPrice_TextChanged;
            prodDiscount.TextChanged += prodDiscount_TextChanged;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();

            ProductListForm productListForm = new ProductListForm();
            productListForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(prodName.Text))
            {
                MessageBox.Show("Product Name cannot be empty. Please enter a valid product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(prodStock.Text))
            {
                MessageBox.Show("Product Stock cannot be empty. Please enter a valid Stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(prodPrice.Text))
            {
                MessageBox.Show("Product Price cannot be empty. Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(prodImg.Text))
            {
                MessageBox.Show("Product Image cannot be empty. Please enter a valid Image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product product = new Product()
            {
                id = this.product.id,
                name = prodName.Text,
                description = string.IsNullOrWhiteSpace(prodDesc.Text) ? null : prodDesc.Text,
                price = decimal.Parse(prodPrice.Text),
                discountPrice = string.IsNullOrWhiteSpace(prodDiscount.Text) ? (decimal?)null : decimal.Parse(prodDiscount.Text),
                imgUrl = prodImg.Text,
                stockQuantity = int.Parse(prodStock.Text)
            };


            int res = ProductManager.updateProduct(product);
            if (res > 0)
            {
                MessageBox.Show("Product Updated Successfully");
            }
            else
            {
                MessageBox.Show("No Changes Applied");
            }

            //Close();
            Hide();

            ProductListForm productListForm = new ProductListForm();
            productListForm.ShowDialog();
        }

        private void prodStock_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(prodStock.Text, out _))
            {
                MessageBox.Show("Stock must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prodStock.Text = string.Empty;
            }
        }

        private void prodPrice_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(prodPrice.Text, out _))
            {
                MessageBox.Show("Stock must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prodPrice.Text = string.Empty;
            }
        }

        private void prodDiscount_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(prodDiscount.Text, out _))
            {
                MessageBox.Show("Product Discount must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prodDiscount.Text = string.Empty;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "All Files|*.*";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    prodImg.Text = openFileDialog.FileName;
                }
            }
        }

        private void prodDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();

            Form1 form = new Form1();
            UserSession.Logout();
            form.ShowDialog();
        }
    }
}

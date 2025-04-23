using BLL;
using BLL.Entities;
using BLL.EntityManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaionLayer.CustomerForms
{
    public partial class ProductDetailsForm : Form
    {
        Product product;
        public ProductDetailsForm(string productId)
        {
            product = ProductManager.GetProductById(productId);
            InitializeComponent();
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            logout.ForeColor = Color.White;

            prodName.Text = product.name;
            prodPrice.Text = product.price.ToString();
            prodDiscount.Text = product.discountPrice == null ? "NA" : product.discountPrice.ToString();
            prodDesc.Text = product.description;
            prodPic.SizeMode = PictureBoxSizeMode.Zoom;
            prodPic.Image = Image.FromFile(product.imgUrl);

        }



        private void quantity_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(quantity.Text, out _))
            {
                MessageBox.Show("Requested Quantity must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantity.Text = string.Empty;
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(quantity.Text) || !int.TryParse(quantity.Text, out int ReQuantity) || ReQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity before adding to cart.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ReQuantity > product.stockQuantity)
            {
                MessageBox.Show("No Avilable Quantity");
                return;
            }

            CartItem oldCart = CartItmeManager.CHKCartExistance(UserSession.UserId, product.id);

            if (oldCart != null)
            {
                int noOfRows = CartItmeManager.UpdateCartQuantity(oldCart.Id, ReQuantity);
                if (noOfRows > 0)
                {
                    MessageBox.Show("Quantity Updated Successfully ! ");
                    //Close();
                    Hide();

                    CustomerProductList list = new CustomerProductList();
                    list.ShowDialog();
                    return;
                }
                else
                {
                    MessageBox.Show("Something went worng");
                    return;
                }
            }

            CartItem item = new CartItem()
            {
                ProductId = product.id,
                UserId = UserSession.UserId,
                Quantity = int.Parse(quantity.Text)
            };

            int res = CartItmeManager.AddToCart(item);
            if (res > 0)
            {
                MessageBox.Show("Item Added Successfully ");
                //Close();
                Hide();

                CustomerProductList list = new CustomerProductList();
                list.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("Something went worng");
                return;
            }


        }

        private void backToList_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();

            CustomerProductList form = new CustomerProductList();
            form.ShowDialog();

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

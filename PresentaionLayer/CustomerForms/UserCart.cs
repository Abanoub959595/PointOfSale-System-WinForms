using BLL;
using BLL.EntityList;
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
    public partial class UserCart : Form
    {
        public UserCart()
        {
            InitializeComponent();
        }
        CartItemList items;
        private void UserCart_Load(object sender, EventArgs e)
        {
            logout.ForeColor = Color.White;

            items = CartItmeManager.GetCartForUser(UserSession.UserId);
            LoadCartItemsIntoGrid();
        }
        private void LoadCartItemsIntoGrid()
        {
            cartData.Columns.Clear(); // Clear existing columns

            // Add necessary columns
            cartData.Columns.Add("CartId", "Cart ID"); // Hidden column to store Cart ID
            cartData.Columns["CartId"].Visible = false; // Hide it

            cartData.Columns.Add("ProductName", "Product Name");
            cartData.Columns.Add("Quantity", "Requested Quantity");
            cartData.Columns.Add("Price", "Price");

            // Add Image Column
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "ProductImage";
            imgColumn.HeaderText = "Image";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Adjust image size
            cartData.Columns.Add(imgColumn);

            // Add Delete Button Column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Action";
            deleteButtonColumn.Text = "Remove";
            deleteButtonColumn.UseColumnTextForButtonValue = true; // Display text
            cartData.Columns.Add(deleteButtonColumn);

            // Load cart items into DataGridView

            foreach (var item in items)
            {
                var product = ProductManager.GetProductById(item.ProductId); // Fetch product details

                if (product != null) // Ensure product exists
                {
                    int rowIndex = cartData.Rows.Add();
                    cartData.Rows[rowIndex].Cells["CartId"].Value = item.Id; // Store cart item ID
                    cartData.Rows[rowIndex].Cells["ProductName"].Value = product.name;
                    cartData.Rows[rowIndex].Cells["Quantity"].Value = item.Quantity;
                    cartData.Rows[rowIndex].Cells["Price"].Value = product.price * item.Quantity; // Total price

                    // Load and set image
                    if (!string.IsNullOrEmpty(product.imgUrl) && System.IO.File.Exists(product.imgUrl))
                    {
                        cartData.Rows[rowIndex].Cells["ProductImage"].Value = Image.FromFile(product.imgUrl);
                    }
                }
            }

            // Attach event for handling delete button click
            cartData.CellClick += CartData_CellClick;
        }
        private void CartData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == cartData.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Get cart item ID of the selected row
                string cartId = cartData.Rows[e.RowIndex].Cells["CartId"].Value.ToString();
                string productName = cartData.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();

                // Confirm deletion
                DialogResult result = MessageBox.Show($"Are you sure you want to remove '{productName}' from your cart?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Remove item from cart using cartId
                    CartItmeManager.RemoveFromCart(cartId);

                    // Refresh the grid after deletion
                    LoadCartItemsIntoGrid();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in items)
            {
                Product prod = ProductManager.GetProductById(item.ProductId);
                if (item.Quantity > prod.stockQuantity)
                {
                    MessageBox.Show($"Item {prod.name} will be decreased to {item.Quantity - prod.stockQuantity} Due to available stock");
                    CartItmeManager.UpdateCartQuantity(item.Id, prod.stockQuantity);
                }
            }

            OrderManager.CreateOrder(UserSession.UserId);
            //Close();
            Hide();

            CustomerProductList form = new CustomerProductList();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();

            CustomerProductList form = new CustomerProductList();
            form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void cartData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

using BLL.EntityManager;
using PresentaionLayer.AdminForms;
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
    public partial class CustomerProductList : Form
    {
        public CustomerProductList()
        {
            InitializeComponent();
        }

        private void CustomerProductList_Load(object sender, EventArgs e)
        {
            logout.ForeColor = Color.White;

            if (UserSession.IsAdmin)
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }



            LoadProductsIntoDataGridView();
        }

        private void LoadProductsIntoDataGridView()
        {
            prodData.Columns.Clear(); // Clear existing columns

            // Add a hidden ID column
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "id";
            idColumn.HeaderText = "Product ID";
            idColumn.Visible = false; // Hide the ID column
            prodData.Columns.Add(idColumn);

            // Add necessary columns
            prodData.Columns.Add("name", "Product Name");
            prodData.Columns.Add("price", "Price");
            prodData.Columns.Add("discountPrice", "Discount");
            prodData.Columns.Add("stockQuantity", "Stock");

            // Add an Image Column for displaying the image
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "ProductImage";
            imgColumn.HeaderText = "Image";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Adjust image size
            prodData.Columns.Add(imgColumn);

            // Add "View Details" Button Column
            DataGridViewButtonColumn viewDetailsButtonColumn = new DataGridViewButtonColumn();
            viewDetailsButtonColumn.Name = "ViewDetails";
            viewDetailsButtonColumn.HeaderText = "Details";
            viewDetailsButtonColumn.Text = "View Details";
            viewDetailsButtonColumn.UseColumnTextForButtonValue = true;
            prodData.Columns.Add(viewDetailsButtonColumn);

            // Load products into DataGridView
            foreach (var product in ProductManager.SelectAllAvilable()) // Assuming you fetch products like this
            {
                int rowIndex = prodData.Rows.Add();
                prodData.Rows[rowIndex].Cells["id"].Value = product.id;
                prodData.Rows[rowIndex].Cells["name"].Value = product.name;
                prodData.Rows[rowIndex].Cells["price"].Value = product.price;
                prodData.Rows[rowIndex].Cells["discountPrice"].Value = product.discountPrice == null ? "NA" : product.discountPrice;
                prodData.Rows[rowIndex].Cells["stockQuantity"].Value = product.stockQuantity;

                if (!string.IsNullOrEmpty(product.imgUrl) && System.IO.File.Exists(product.imgUrl))
                {
                    prodData.Rows[rowIndex].Cells["ProductImage"].Value = Image.FromFile(product.imgUrl);
                }
            }

            // Attach event handler for the button click
            prodData.CellClick += ProdData_CellClick;
        }

        // Handle button click event
        private void ProdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && prodData.Columns[e.ColumnIndex].Name == "ViewDetails")
            {
                string productId = prodData.Rows[e.RowIndex].Cells["id"].Value.ToString();

                //Open Product Details Form(Assuming you have a form for this)
                ProductDetailsForm detailsForm = new ProductDetailsForm(productId);
                detailsForm.ShowDialog();
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (CartItmeManager.GetCartForUser(UserSession.UserId).Count == 0)
            {
                MessageBox.Show("Cart Is Empty");
                return;
            }
            //Close();
            Hide();

            UserCart cart = new UserCart();
            cart.ShowDialog();

        }

        private void OrderDetaisl_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();

            UserOrders cart = new UserOrders();
            cart.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();

            Form1 form = new Form1();
            UserSession.Logout();
            form.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            AdminLayoutFrom form = new AdminLayoutFrom();
            form.ShowDialog();
        }
    }
}

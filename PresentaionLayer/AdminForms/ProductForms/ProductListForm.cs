using BLL.EntityManager;
using PresentaionLayer.AdminForms;
using PresentaionLayer.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaionLayer
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InsertProduct insertProduct = new InsertProduct();
            insertProduct.ShowDialog();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            logout.ForeColor = Color.White;
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


            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.Name = "Update";
            updateButtonColumn.HeaderText = "Update";
            updateButtonColumn.Text = "Update";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            prodData.Columns.Add(updateButtonColumn);

            // Add Delete Button Column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            prodData.Columns.Add(deleteButtonColumn);

            // Load products into DataGridView
            foreach (var product in ProductManager.SelectAll()) // Assuming you fetch products like this
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


            prodData.CellClick += ProdData_CellClick;

        }

        private void ProdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not the header row
            {
                string productId = prodData.Rows[e.RowIndex].Cells["id"].Value.ToString();

                if (prodData.Columns[e.ColumnIndex].Name == "Update")
                {
                    MessageBox.Show($"Updating product: {productId}");
                    // Call the function to update the product (e.g., open an edit form)
                    UpdateProduct(productId);
                }
                else if (prodData.Columns[e.ColumnIndex].Name == "Delete")
                {
                    var confirmResult = MessageBox.Show($"Are you sure you want to delete?",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        if (ProductManager.ValidToDelete(productId))
                        {
                            ProductManager.DeleteProduct(productId);
                            MessageBox.Show($"Product Deteted");
                        }else
                        {
                        MessageBox.Show($"Can not Delete That product");

                        }

                    }
                }
            }
        }

        private void UpdateProduct(string prodId)
        {
            UpdateProduct updateProduct = new UpdateProduct(prodId);
            updateProduct.ShowDialog();
        }

        private void backToList_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();

            AdminLayoutFrom from = new AdminLayoutFrom();
            from.ShowDialog();
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

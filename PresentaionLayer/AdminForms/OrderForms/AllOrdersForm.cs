using BLL;
using BLL.EntityManager;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaionLayer.AdminForms.OrderForms
{
    public partial class AllOrdersForm : Form
    {
        public AllOrdersForm()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();
            Form1 form = new Form1();
            UserSession.Logout();
            form.ShowDialog();
        }

        private void backToList_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();
            AdminLayoutFrom from = new AdminLayoutFrom();
            from.ShowDialog();
        }

        private void AllOrdersForm_Load(object sender, EventArgs e)
        {
            orderData.Dock = DockStyle.Fill;
            orderData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            LoadOrdersIntoDataGridView();
        }

        private void LoadOrdersIntoDataGridView()
        {
            orderData.Columns.Clear(); // Clear existing columns

            // Add hidden Order ID & User ID columns
            orderData.Columns.Add(new DataGridViewTextBoxColumn { Name = "orderId", HeaderText = "Order ID", Visible = false });
            orderData.Columns.Add(new DataGridViewTextBoxColumn { Name = "userId", HeaderText = "User ID", Visible = false });

            // Add other columns
            orderData.Columns.Add("orderDate", "Order Date");

            // Add a ComboBox column for Order Status
            var statusColumn = new DataGridViewComboBoxColumn
            {
                Name = "status",
                HeaderText = "Status",
                DataSource = new string[] { "Pending", "Processing", "Shipped", "Delivered", "Canceled" } // Define possible statuses
            };
            orderData.Columns.Add(statusColumn);

            // Add "View Details" Button Column
            var detailsButtonColumn = new DataGridViewButtonColumn
            {
                Name = "ViewDetails",
                HeaderText = "Actions",
                Text = "View Details",
                UseColumnTextForButtonValue = true
            };
            orderData.Columns.Add(detailsButtonColumn);

            // Load orders into DataGridView
            foreach (var order in OrderManager.SelectAllOrders()) // Assuming this fetches all orders
            {
                int rowIndex = orderData.Rows.Add();
                orderData.Rows[rowIndex].Cells["orderId"].Value = order.OrderId;
                orderData.Rows[rowIndex].Cells["userId"].Value = order.UserId;
                orderData.Rows[rowIndex].Cells["orderDate"].Value = order.OrderDate.ToString("yyyy-MM-dd HH:mm:ss");

                // Set current order status in the ComboBox
                ((DataGridViewComboBoxCell)orderData.Rows[rowIndex].Cells["status"]).Value = order.Status;
            }

            orderData.CellClick += OrderData_CellClick; // Handle button clicks
            orderData.CellValueChanged += OrderData_CellValueChanged; // Handle status change
        }

        private void OrderData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == orderData.Columns["ViewDetails"].Index && e.RowIndex >= 0)
            {
                string orderId = orderData.Rows[e.RowIndex].Cells["orderId"].Value.ToString();
                string userId = orderData.Rows[e.RowIndex].Cells["userId"].Value.ToString();
                string orderDate = orderData.Rows[e.RowIndex].Cells["orderDate"].Value.ToString();
                string status = orderData.Rows[e.RowIndex].Cells["status"].Value.ToString();

                // Get user details using UserManager.GetUserById()
                var user = UserManager.GetUserById(userId);

                if (user != null)
                {
                    MessageBox.Show($"Order ID: {orderId}\nUser: {user.name}\nEmail: {user.email}\nOrder Date: {orderDate}\nStatus: {status}",
                        "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OrderData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == orderData.Columns["status"].Index && e.RowIndex >= 0)
            {
                string orderId = orderData.Rows[e.RowIndex].Cells["orderId"].Value.ToString();
                string newStatus = orderData.Rows[e.RowIndex].Cells["status"].Value.ToString();

                // Call method to update the order status in database
                int success = OrderManager.UpdateOrderStatus(orderId, newStatus);
                
            }
        }
    }



}


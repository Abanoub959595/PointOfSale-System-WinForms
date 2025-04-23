using BLL;
using BLL.Entities;
using BLL.EntityList;
using BLL.EntityManager;
using BLL.Helper;
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
    public partial class UserOrders : Form
    {
        public UserOrders()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();

            CustomerProductList form = new CustomerProductList();
            form.ShowDialog();

        }

        private void cartData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        OrdersList orders;
        private void UserOrders_Load(object sender, EventArgs e)
        {
            logout.ForeColor = Color.White;

            orders = OrderManager.GetOrdersForUser(UserSession.UserId);
            LoadOrdersIntoDataGridView(UserSession.UserId);
        }
        private void LoadOrdersIntoDataGridView(string userId)
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

            // Load orders for the specific user into DataGridView
            var userOrders = OrderManager.GetOrdersForUser(userId); // Fetch only specific user's orders

            foreach (var order in userOrders)
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


        private void OrderData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == orderData.Columns["status"].Index && e.RowIndex >= 0)
            {
                string orderId = orderData.Rows[e.RowIndex].Cells["orderId"].Value.ToString();
                string previousStatus = OrderManager.GetOrderById(orderId).Status; // Fetch the current status from the database
                string newStatus = orderData.Rows[e.RowIndex].Cells["status"].Value.ToString();

                // Allow only "Pending" -> "Canceled"
                if (previousStatus == "Pending" && newStatus == "Canceled")
                {
                    int success = OrderManager.UpdateOrderStatus(orderId, newStatus);
                    if (success > 0)
                    {
                        MessageBox.Show("Order status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update order status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You can only change status from 'Pending' to 'Canceled'.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Revert to the previous status
                    orderData.Rows[e.RowIndex].Cells["status"].Value = previousStatus;
                }
            }
        }








        private void OrderData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == orderData.Columns["ViewDetails"].Index && e.RowIndex >= 0)
            {
                string orderId = orderData.Rows[e.RowIndex].Cells["orderId"].Value.ToString();
                string userId = orderData.Rows[e.RowIndex].Cells["userId"].Value.ToString();
                string orderDate = orderData.Rows[e.RowIndex].Cells["orderDate"].Value.ToString();
                string status = orderData.Rows[e.RowIndex].Cells["status"].Value.ToString();

                // Get user details
                var user = UserManager.GetUserById(userId);


                if (user != null)
                {
                    StringBuilder orderDetails = new StringBuilder();
                    orderDetails.AppendLine($"Order ID: {orderId}");
                    orderDetails.AppendLine($"User: {user.name}");
                    orderDetails.AppendLine($"Email: {user.email}");
                    orderDetails.AppendLine($"Order Date: {orderDate}");
                    orderDetails.AppendLine($"Status: {status}");
                    orderDetails.AppendLine("\nItems in this order:");

                    OrderItemList res = OrderItemsManager.GetItemPassedOnOrderId(orderId);

                    foreach (var item in res)
                    {
                        var itemData = ProductManager.GetProductById(item.ProductId);
                        orderDetails.AppendLine($"- {itemData.name} | Quantity: {item.Quantity} | Price: {itemData.price:C}");
                    }

                    MessageBox.Show(orderDetails.ToString(), "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Order details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

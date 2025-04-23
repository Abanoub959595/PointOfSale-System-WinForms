using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaionLayer.AdminForms.CustomerForms
{
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            logout.ForeColor = Color.White;

            this.BackColor = Color.FromArgb(240, 240, 240); // Light gray for modern UI

            // Style Header Panel
            Panel headerPanel = new Panel
            {
                Size = new Size(this.Width, 60),
                BackColor = Color.FromArgb(50, 50, 70), // Dark theme header
                Dock = DockStyle.Top
            };
            this.Controls.Add(headerPanel);

            // Title Label Styling
            Label titleLabel = new Label
            {
                Text = "Our Users",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point((this.Width - 150) / 2, 15) // Center Title
            };
            headerPanel.Controls.Add(titleLabel);

            // Style Back To List Button
            backToList.Size = new Size(140, 40);
            backToList.BackColor = Color.FromArgb(100, 149, 237); // Steel Blue
            backToList.ForeColor = Color.White;
            backToList.FlatStyle = FlatStyle.Flat;
            backToList.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            backToList.FlatAppearance.BorderSize = 0;
            backToList.Cursor = Cursors.Hand;
            backToList.Location = new Point(20, 10);
            headerPanel.Controls.Add(backToList);



            // DataGridView Styling
            userData.BackgroundColor = Color.White;
            userData.GridColor = Color.Gray;
            userData.DefaultCellStyle.BackColor = Color.White;
            userData.DefaultCellStyle.ForeColor = Color.Black;
            userData.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            userData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 70);
            userData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            userData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            userData.EnableHeadersVisualStyles = false;
            userData.RowTemplate.Height = 30;
            userData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust the table position
            userData.Location = new Point(20, 80);
            userData.Size = new Size(this.Width - 40, this.Height - 120);




            LoadUsersIntoDataGridView();
        }

        private void userData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadUsersIntoDataGridView()
        {
            userData.Columns.Clear(); // Clear existing columns

            // Add a hidden ID column
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "id";
            idColumn.HeaderText = "User ID";
            idColumn.Visible = false; // Hide the ID column
            userData.Columns.Add(idColumn);

            // Add necessary columns
            userData.Columns.Add("name", "Name");
            userData.Columns.Add("email", "Email");
            userData.Columns.Add("isActive", "Active");
            userData.Columns.Add("isCustomer", "Customer");
            userData.Columns.Add("isAdmin", "Admin");

            // Add Update Button Column
            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.Name = "Update";
            updateButtonColumn.HeaderText = "Update";
            updateButtonColumn.Text = "Update";
            updateButtonColumn.UseColumnTextForButtonValue = true;
            userData.Columns.Add(updateButtonColumn);


            foreach (var user in UserManager.SelectAll()) // Assuming UserManager.SelectAll() fetches users
            {

                int rowIndex = userData.Rows.Add();
                userData.Rows[rowIndex].Cells["id"].Value = user.id;
                userData.Rows[rowIndex].Cells["name"].Value = user.name;
                userData.Rows[rowIndex].Cells["email"].Value = user.email;
                userData.Rows[rowIndex].Cells["isActive"].Value = user.isActive ? "Yes" : "No";
                userData.Rows[rowIndex].Cells["isCustomer"].Value = user.isCustomer ? "Yes" : "No";
                userData.Rows[rowIndex].Cells["isAdmin"].Value = user.isAdmin ? "Yes" : "No";
            }

            userData.CellClick += UserData_CellClick; // Handle button clicks
        }


        private void UserData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ignore header clicks
            {
                string userId = userData.Rows[e.RowIndex].Cells["id"].Value.ToString();

                if (e.ColumnIndex == userData.Columns["Update"].Index)
                {
                    // Handle update logic
                    MessageBox.Show($"Update user with ID: {userId}");
                    UpdateCustomerData(userId);
                }
            }
        }


        private void UpdateCustomerData(string prodId)
        {
            //Close();
            Hide();
            UpdateCustomer updateCustomer = new UpdateCustomer(prodId);
            updateCustomer.ShowDialog();
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

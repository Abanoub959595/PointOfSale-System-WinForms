using PresentaionLayer.AdminForms.CustomerForms;
using PresentaionLayer.AdminForms.OrderForms;
using PresentaionLayer.CustomerForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaionLayer.AdminForms
{
    public partial class AdminLayoutFrom : Form
    {
        public AdminLayoutFrom()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close();
            Hide();

            CustomerListForm form = new CustomerListForm();
            form.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();

            ProductListForm form = new ProductListForm();
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

        private void AdminLayoutFrom_Load(object sender, EventArgs e)
        {
            logout.ForeColor = Color.White;

            if (UserSession.IsCustomer)
            {
                btnCustomer.Visible = true;
            }else 
            {
                btnCustomer.Visible = false;

            }



            this.BackColor = Color.FromArgb(30, 30, 45); // Dark gray background for modern UI

            // Create a panel to group buttons in the center
            Panel buttonPanel = new Panel
            {
                Size = new Size(400, 200),
                Location = new Point((this.Width - 400) / 2, (this.Height - 200) / 2),
                BackColor = Color.FromArgb(50, 50, 70),
                BorderStyle = BorderStyle.None
            };
            this.Controls.Add(buttonPanel);

            // Define button style
            Button[] buttons = { btnProducts, btnOrders, btnUsers };
            foreach (Button btn in buttons)
            {
                btn.Size = new Size(150, 50);
                btn.BackColor = Color.FromArgb(70, 130, 180); // Steel Blue
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                btn.Margin = new Padding(10);
            }

            // Arrange buttons inside the panel
            btnProducts.Location = new Point(20, 30);
            btnOrders.Location = new Point(180, 30);
            btnUsers.Location = new Point(100, 100);

            // Add buttons to the panel
            buttonPanel.Controls.Add(btnProducts);
            buttonPanel.Controls.Add(btnOrders);
            buttonPanel.Controls.Add(btnUsers);


            // Add hover effects
            btnProducts.MouseEnter += (s, ev) => { btnProducts.BackColor = Color.FromArgb(100, 149, 237); };
            btnProducts.MouseLeave += (s, ev) => { btnProducts.BackColor = Color.FromArgb(70, 130, 180); };

            btnOrders.MouseEnter += (s, ev) => { btnOrders.BackColor = Color.FromArgb(100, 149, 237); };
            btnOrders.MouseLeave += (s, ev) => { btnOrders.BackColor = Color.FromArgb(70, 130, 180); };

            btnUsers.MouseEnter += (s, ev) => { btnUsers.BackColor = Color.FromArgb(100, 149, 237); };
            btnUsers.MouseLeave += (s, ev) => { btnUsers.BackColor = Color.FromArgb(70, 130, 180); };


        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllOrdersForm form = new AllOrdersForm();
            form.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            CustomerProductList form = new CustomerProductList();
            form.ShowDialog();
        }
    }
}

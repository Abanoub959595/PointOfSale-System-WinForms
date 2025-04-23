namespace PresentaionLayer.AdminForms
{
    partial class AdminLayoutFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProducts = new Button();
            btnOrders = new Button();
            btnUsers = new Button();
            logout = new Button();
            btnCustomer = new Button();
            SuspendLayout();
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(115, 181);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(118, 57);
            btnProducts.TabIndex = 0;
            btnProducts.Text = "\U0001f6d2 Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(333, 181);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(118, 57);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "📦 Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(548, 181);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(118, 57);
            btnUsers.TabIndex = 2;
            btnUsers.Text = "👥 Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += button3_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Firebrick;
            logout.Location = new Point(620, 12);
            logout.Name = "logout";
            logout.Size = new Size(168, 42);
            logout.TabIndex = 37;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(12, 21);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(146, 33);
            btnCustomer.TabIndex = 40;
            btnCustomer.Text = "Customer Forms";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnAdmin_Click;
            // 
            // AdminLayoutFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCustomer);
            Controls.Add(logout);
            Controls.Add(btnUsers);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Name = "AdminLayoutFrom";
            Text = "AdminLayoutFrom";
            Load += AdminLayoutFrom_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnProducts;
        private Button btnOrders;
        private Button btnUsers;
        private Button logout;
        private Button btnCustomer;
    }
}
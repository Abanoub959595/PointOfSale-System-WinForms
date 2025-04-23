namespace PresentaionLayer.CustomerForms
{
    partial class CustomerProductList
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
            label1 = new Label();
            prodData = new DataGridView();
            btnCart = new Button();
            OrderDetaisl = new Button();
            logout = new Button();
            btnAdmin = new Button();
            ((System.ComponentModel.ISupportInitialize)prodData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(297, 12);
            label1.Name = "label1";
            label1.Size = new Size(201, 41);
            label1.TabIndex = 4;
            label1.Text = "Our Products";
            // 
            // prodData
            // 
            prodData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodData.Location = new Point(12, 72);
            prodData.Name = "prodData";
            prodData.RowHeadersWidth = 51;
            prodData.RowTemplate.Height = 29;
            prodData.Size = new Size(776, 282);
            prodData.TabIndex = 3;
            // 
            // btnCart
            // 
            btnCart.Location = new Point(652, 401);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(136, 37);
            btnCart.TabIndex = 5;
            btnCart.Text = "Your Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // OrderDetaisl
            // 
            OrderDetaisl.Location = new Point(12, 401);
            OrderDetaisl.Name = "OrderDetaisl";
            OrderDetaisl.Size = new Size(136, 37);
            OrderDetaisl.TabIndex = 6;
            OrderDetaisl.Text = "Your Orders";
            OrderDetaisl.UseVisualStyleBackColor = true;
            OrderDetaisl.Click += OrderDetaisl_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Firebrick;
            logout.Location = new Point(620, 11);
            logout.Name = "logout";
            logout.Size = new Size(168, 42);
            logout.TabIndex = 38;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(12, 11);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(120, 33);
            btnAdmin.TabIndex = 39;
            btnAdmin.Text = "Admin Forms";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // CustomerProductList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdmin);
            Controls.Add(logout);
            Controls.Add(OrderDetaisl);
            Controls.Add(btnCart);
            Controls.Add(label1);
            Controls.Add(prodData);
            Name = "CustomerProductList";
            Text = "CustomerProductList";
            Load += CustomerProductList_Load;
            ((System.ComponentModel.ISupportInitialize)prodData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView prodData;
        private Button btnCart;
        private Button OrderDetaisl;
        private Button logout;
        private Button btnAdmin;
    }
}
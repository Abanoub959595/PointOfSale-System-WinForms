namespace PresentaionLayer.CustomerForms
{
    partial class UserOrders
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
            btnBackToList = new Button();
            label1 = new Label();
            orderData = new DataGridView();
            backToList = new Button();
            logout = new Button();
            ((System.ComponentModel.ISupportInitialize)orderData).BeginInit();
            SuspendLayout();
            // 
            // btnBackToList
            // 
            btnBackToList.Location = new Point(30, 407);
            btnBackToList.Name = "btnBackToList";
            btnBackToList.Size = new Size(139, 44);
            btnBackToList.TabIndex = 11;
            btnBackToList.Text = "Back To List";
            btnBackToList.UseVisualStyleBackColor = true;
            btnBackToList.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(313, 28);
            label1.Name = "label1";
            label1.Size = new Size(185, 41);
            label1.TabIndex = 10;
            label1.Text = "Your Orders";
            label1.Click += label1_Click;
            // 
            // orderData
            // 
            orderData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderData.Location = new Point(30, 88);
            orderData.Name = "orderData";
            orderData.RowHeadersWidth = 51;
            orderData.RowTemplate.Height = 29;
            orderData.Size = new Size(776, 282);
            orderData.TabIndex = 9;
            orderData.CellContentClick += cartData_CellContentClick;
            // 
            // backToList
            // 
            backToList.Location = new Point(12, 12);
            backToList.Name = "backToList";
            backToList.Size = new Size(168, 42);
            backToList.TabIndex = 50;
            backToList.Text = "Back To List";
            backToList.UseVisualStyleBackColor = true;
            backToList.Click += backToList_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Firebrick;
            logout.Location = new Point(656, 12);
            logout.Name = "logout";
            logout.Size = new Size(168, 42);
            logout.TabIndex = 51;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // UserOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 479);
            Controls.Add(logout);
            Controls.Add(backToList);
            Controls.Add(btnBackToList);
            Controls.Add(label1);
            Controls.Add(orderData);
            Name = "UserOrders";
            Text = "UserOrders";
            Load += UserOrders_Load;
            ((System.ComponentModel.ISupportInitialize)orderData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackToList;
        private Label label1;
        private DataGridView orderData;
        private Button backToList;
        private Button logout;
    }
}
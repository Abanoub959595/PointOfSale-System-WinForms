namespace PresentaionLayer.CustomerForms
{
    partial class UserCart
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
            cartData = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            backToList = new Button();
            logout = new Button();
            ((System.ComponentModel.ISupportInitialize)cartData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(316, 15);
            label1.Name = "label1";
            label1.Size = new Size(151, 41);
            label1.TabIndex = 6;
            label1.Text = "Your Cart";
            label1.Click += label1_Click;
            // 
            // cartData
            // 
            cartData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cartData.Location = new Point(12, 75);
            cartData.Name = "cartData";
            cartData.RowHeadersWidth = 51;
            cartData.RowTemplate.Height = 29;
            cartData.Size = new Size(776, 282);
            cartData.TabIndex = 5;
            cartData.CellContentClick += cartData_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(649, 394);
            button1.Name = "button1";
            button1.Size = new Size(139, 44);
            button1.TabIndex = 7;
            button1.Text = "Place Order";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 394);
            button2.Name = "button2";
            button2.Size = new Size(139, 44);
            button2.TabIndex = 8;
            button2.Text = "Back To List";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // backToList
            // 
            backToList.Location = new Point(12, 12);
            backToList.Name = "backToList";
            backToList.Size = new Size(168, 42);
            backToList.TabIndex = 49;
            backToList.Text = "Back To List";
            backToList.UseVisualStyleBackColor = true;
            backToList.Click += backToList_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Firebrick;
            logout.Location = new Point(620, 12);
            logout.Name = "logout";
            logout.Size = new Size(168, 42);
            logout.TabIndex = 50;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // UserCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(backToList);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(cartData);
            Name = "UserCart";
            Text = "UserCart";
            Load += UserCart_Load;
            ((System.ComponentModel.ISupportInitialize)cartData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView cartData;
        private Button button1;
        private Button button2;
        private Button backToList;
        private Button logout;
    }
}
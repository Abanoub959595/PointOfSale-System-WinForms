namespace PresentaionLayer.AdminForms.OrderForms
{
    partial class AllOrdersForm
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
            logout = new Button();
            label1 = new Label();
            backToList = new Button();
            orderData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)orderData).BeginInit();
            SuspendLayout();
            // 
            // logout
            // 
            logout.BackColor = Color.Firebrick;
            logout.Location = new Point(620, 13);
            logout.Name = "logout";
            logout.Size = new Size(168, 42);
            logout.TabIndex = 10;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(315, 18);
            label1.Name = "label1";
            label1.Size = new Size(173, 41);
            label1.TabIndex = 9;
            label1.Text = "Our Orders";
            // 
            // backToList
            // 
            backToList.Location = new Point(12, 13);
            backToList.Name = "backToList";
            backToList.Size = new Size(168, 42);
            backToList.TabIndex = 8;
            backToList.Text = "Back To List";
            backToList.UseVisualStyleBackColor = true;
            backToList.Click += backToList_Click;
            // 
            // orderData
            // 
            orderData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderData.Location = new Point(12, 78);
            orderData.Name = "orderData";
            orderData.RowHeadersWidth = 51;
            orderData.RowTemplate.Height = 29;
            orderData.Size = new Size(776, 282);
            orderData.TabIndex = 7;
            // 
            // AllOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(label1);
            Controls.Add(backToList);
            Controls.Add(orderData);
            Name = "AllOrdersForm";
            Text = "AllOrdersForm";
            Load += AllOrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)orderData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logout;
        private Label label1;
        private Button backToList;
        private DataGridView orderData;
    }
}
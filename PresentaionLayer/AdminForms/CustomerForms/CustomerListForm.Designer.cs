namespace PresentaionLayer.AdminForms.CustomerForms
{
    partial class CustomerListForm
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
            backToList = new Button();
            userData = new DataGridView();
            logout = new Button();
            ((System.ComponentModel.ISupportInitialize)userData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(315, 17);
            label1.Name = "label1";
            label1.Size = new Size(155, 41);
            label1.TabIndex = 5;
            label1.Text = "Our Users";
            // 
            // backToList
            // 
            backToList.Location = new Point(12, 12);
            backToList.Name = "backToList";
            backToList.Size = new Size(168, 42);
            backToList.TabIndex = 4;
            backToList.Text = "Back To List";
            backToList.UseVisualStyleBackColor = true;
            backToList.Click += backToList_Click;
            // 
            // userData
            // 
            userData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userData.Location = new Point(12, 77);
            userData.Name = "userData";
            userData.RowHeadersWidth = 51;
            userData.RowTemplate.Height = 29;
            userData.Size = new Size(776, 282);
            userData.TabIndex = 3;
            userData.CellContentClick += userData_CellContentClick;
            // 
            // logout
            // 
            logout.BackColor = Color.Firebrick;
            logout.Location = new Point(620, 12);
            logout.Name = "logout";
            logout.Size = new Size(168, 42);
            logout.TabIndex = 6;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(label1);
            Controls.Add(backToList);
            Controls.Add(userData);
            Name = "CustomerListForm";
            Text = "CustomerListForm";
            Load += CustomerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)userData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button backToList;
        private DataGridView userData;
        private Button logout;
    }
}
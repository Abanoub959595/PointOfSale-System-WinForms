namespace PresentaionLayer
{
    partial class ProductListForm
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
            prodData = new DataGridView();
            btnAdd = new Button();
            label1 = new Label();
            backToList = new Button();
            logout = new Button();
            ((System.ComponentModel.ISupportInitialize)prodData).BeginInit();
            SuspendLayout();
            // 
            // prodData
            // 
            prodData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            prodData.Location = new Point(12, 69);
            prodData.Name = "prodData";
            prodData.RowHeadersWidth = 51;
            prodData.RowTemplate.Height = 29;
            prodData.Size = new Size(776, 282);
            prodData.TabIndex = 0;
            prodData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 371);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(281, 55);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add New Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(297, 9);
            label1.Name = "label1";
            label1.Size = new Size(201, 41);
            label1.TabIndex = 2;
            label1.Text = "Our Products";
            // 
            // backToList
            // 
            backToList.Location = new Point(12, 8);
            backToList.Name = "backToList";
            backToList.Size = new Size(168, 42);
            backToList.TabIndex = 5;
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
            logout.TabIndex = 35;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // ProductListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(backToList);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(prodData);
            Name = "ProductListForm";
            Text = "ProductListForm";
            Load += ProductListForm_Load;
            ((System.ComponentModel.ISupportInitialize)prodData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView prodData;
        private Button btnAdd;
        private Label label1;
        private Button backToList;
        private Button logout;
    }
}
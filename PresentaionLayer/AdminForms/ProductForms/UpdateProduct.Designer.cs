namespace PresentaionLayer.ProductForms
{
    partial class UpdateProduct
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
            btnBrowse = new Button();
            btnAdd = new Button();
            label1 = new Label();
            prodImg = new TextBox();
            prodStock = new TextBox();
            prodDiscount = new TextBox();
            prodPrice = new TextBox();
            prodDesc = new TextBox();
            prodName = new TextBox();
            pImg = new Label();
            pStock = new Label();
            pDiscount = new Label();
            pPrice = new Label();
            pDesc = new Label();
            pName = new Label();
            btnBack = new Button();
            logout = new Button();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(415, 192);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(287, 29);
            btnBrowse.TabIndex = 22;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkCyan;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(231, 333);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(321, 84);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Save Changes";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(279, 33);
            label1.Name = "label1";
            label1.Size = new Size(238, 41);
            label1.TabIndex = 29;
            label1.Text = "Update Product";
            // 
            // prodImg
            // 
            prodImg.Location = new Point(415, 194);
            prodImg.Name = "prodImg";
            prodImg.Size = new Size(287, 27);
            prodImg.TabIndex = 28;
            // 
            // prodStock
            // 
            prodStock.Location = new Point(415, 121);
            prodStock.Name = "prodStock";
            prodStock.Size = new Size(287, 27);
            prodStock.TabIndex = 18;
            prodStock.TextChanged += prodStock_TextChanged;
            // 
            // prodDiscount
            // 
            prodDiscount.Location = new Point(99, 271);
            prodDiscount.Name = "prodDiscount";
            prodDiscount.Size = new Size(287, 27);
            prodDiscount.TabIndex = 24;
            prodDiscount.TextChanged += prodDiscount_TextChanged;
            // 
            // prodPrice
            // 
            prodPrice.Location = new Point(98, 193);
            prodPrice.Name = "prodPrice";
            prodPrice.Size = new Size(288, 27);
            prodPrice.TabIndex = 20;
            prodPrice.TextChanged += prodPrice_TextChanged;
            // 
            // prodDesc
            // 
            prodDesc.Location = new Point(415, 271);
            prodDesc.Name = "prodDesc";
            prodDesc.Size = new Size(287, 27);
            prodDesc.TabIndex = 26;
            prodDesc.TextChanged += prodDesc_TextChanged;
            // 
            // prodName
            // 
            prodName.Location = new Point(99, 121);
            prodName.Name = "prodName";
            prodName.Size = new Size(288, 27);
            prodName.TabIndex = 16;
            // 
            // pImg
            // 
            pImg.AutoSize = true;
            pImg.Location = new Point(415, 171);
            pImg.Name = "pImg";
            pImg.Size = new Size(51, 20);
            pImg.TabIndex = 25;
            pImg.Text = "Image";
            // 
            // pStock
            // 
            pStock.AutoSize = true;
            pStock.Location = new Point(415, 98);
            pStock.Name = "pStock";
            pStock.Size = new Size(45, 20);
            pStock.TabIndex = 23;
            pStock.Text = "Stock";
            // 
            // pDiscount
            // 
            pDiscount.AutoSize = true;
            pDiscount.Location = new Point(99, 248);
            pDiscount.Name = "pDiscount";
            pDiscount.Size = new Size(103, 20);
            pDiscount.TabIndex = 21;
            pDiscount.Text = "Discount Price";
            // 
            // pPrice
            // 
            pPrice.AutoSize = true;
            pPrice.Location = new Point(98, 170);
            pPrice.Name = "pPrice";
            pPrice.Size = new Size(96, 20);
            pPrice.TabIndex = 19;
            pPrice.Text = "Product Price";
            // 
            // pDesc
            // 
            pDesc.AutoSize = true;
            pDesc.Location = new Point(415, 248);
            pDesc.Name = "pDesc";
            pDesc.Size = new Size(140, 20);
            pDesc.TabIndex = 17;
            pDesc.Text = "Product Description";
            // 
            // pName
            // 
            pName.AutoSize = true;
            pName.Location = new Point(100, 98);
            pName.Name = "pName";
            pName.Size = new Size(104, 20);
            pName.TabIndex = 15;
            pName.Text = "Product Name";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(660, 390);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 48);
            btnBack.TabIndex = 30;
            btnBack.Text = "Back To List";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Firebrick;
            logout.Location = new Point(620, 12);
            logout.Name = "logout";
            logout.Size = new Size(168, 42);
            logout.TabIndex = 36;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(btnBack);
            Controls.Add(btnBrowse);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(prodImg);
            Controls.Add(prodStock);
            Controls.Add(prodDiscount);
            Controls.Add(prodPrice);
            Controls.Add(prodDesc);
            Controls.Add(prodName);
            Controls.Add(pImg);
            Controls.Add(pStock);
            Controls.Add(pDiscount);
            Controls.Add(pPrice);
            Controls.Add(pDesc);
            Controls.Add(pName);
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            Load += UpdateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private Button btnAdd;
        private Label label1;
        private TextBox prodImg;
        private TextBox prodStock;
        private TextBox prodDiscount;
        private TextBox prodPrice;
        private TextBox prodDesc;
        private TextBox prodName;
        private Label pImg;
        private Label pStock;
        private Label pDiscount;
        private Label pPrice;
        private Label pDesc;
        private Label pName;
        private Button btnBack;
        private Button logout;
    }
}
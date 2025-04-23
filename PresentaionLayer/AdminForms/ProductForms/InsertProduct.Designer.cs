namespace PresentaionLayer.ProductForms
{
    partial class InsertProduct
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
            pName = new Label();
            pDesc = new Label();
            pPrice = new Label();
            pDiscount = new Label();
            pStock = new Label();
            pImg = new Label();
            prodName = new TextBox();
            prodDesc = new TextBox();
            prodPrice = new TextBox();
            prodDiscount = new TextBox();
            prodStock = new TextBox();
            prodImg = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            btnBrowse = new Button();
            backToList = new Button();
            logout = new Button();
            SuspendLayout();
            // 
            // pName
            // 
            pName.AutoSize = true;
            pName.Location = new Point(88, 83);
            pName.Name = "pName";
            pName.Size = new Size(104, 20);
            pName.TabIndex = 0;
            pName.Text = "Product Name";
            // 
            // pDesc
            // 
            pDesc.AutoSize = true;
            pDesc.Location = new Point(403, 233);
            pDesc.Name = "pDesc";
            pDesc.Size = new Size(140, 20);
            pDesc.TabIndex = 1;
            pDesc.Text = "Product Description";
            // 
            // pPrice
            // 
            pPrice.AutoSize = true;
            pPrice.Location = new Point(86, 155);
            pPrice.Name = "pPrice";
            pPrice.Size = new Size(96, 20);
            pPrice.TabIndex = 2;
            pPrice.Text = "Product Price";
            // 
            // pDiscount
            // 
            pDiscount.AutoSize = true;
            pDiscount.Location = new Point(87, 233);
            pDiscount.Name = "pDiscount";
            pDiscount.Size = new Size(103, 20);
            pDiscount.TabIndex = 3;
            pDiscount.Text = "Discount Price";
            // 
            // pStock
            // 
            pStock.AutoSize = true;
            pStock.Location = new Point(403, 83);
            pStock.Name = "pStock";
            pStock.Size = new Size(45, 20);
            pStock.TabIndex = 4;
            pStock.Text = "Stock";
            // 
            // pImg
            // 
            pImg.AutoSize = true;
            pImg.Location = new Point(403, 156);
            pImg.Name = "pImg";
            pImg.Size = new Size(51, 20);
            pImg.TabIndex = 5;
            pImg.Text = "Image";
            // 
            // prodName
            // 
            prodName.Location = new Point(87, 106);
            prodName.Name = "prodName";
            prodName.Size = new Size(288, 27);
            prodName.TabIndex = 1;
            // 
            // prodDesc
            // 
            prodDesc.Location = new Point(403, 256);
            prodDesc.Name = "prodDesc";
            prodDesc.Size = new Size(287, 27);
            prodDesc.TabIndex = 6;
            // 
            // prodPrice
            // 
            prodPrice.Location = new Point(86, 178);
            prodPrice.Name = "prodPrice";
            prodPrice.Size = new Size(288, 27);
            prodPrice.TabIndex = 3;
            prodPrice.TextChanged += prodPrice_TextChanged;
            // 
            // prodDiscount
            // 
            prodDiscount.Location = new Point(87, 256);
            prodDiscount.Name = "prodDiscount";
            prodDiscount.Size = new Size(287, 27);
            prodDiscount.TabIndex = 5;
            prodDiscount.TextChanged += prodDiscount_TextChanged;
            // 
            // prodStock
            // 
            prodStock.Location = new Point(403, 106);
            prodStock.Name = "prodStock";
            prodStock.Size = new Size(287, 27);
            prodStock.TabIndex = 2;
            prodStock.TextChanged += prodStock_TextChanged;
            // 
            // prodImg
            // 
            prodImg.Location = new Point(403, 179);
            prodImg.Name = "prodImg";
            prodImg.Size = new Size(287, 27);
            prodImg.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(230, 19);
            label1.Name = "label1";
            label1.Size = new Size(310, 41);
            label1.TabIndex = 14;
            label1.Text = "Adding New Product";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkCyan;
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(219, 318);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(321, 84);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(403, 177);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(287, 29);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // backToList
            // 
            backToList.Location = new Point(620, 396);
            backToList.Name = "backToList";
            backToList.Size = new Size(168, 42);
            backToList.TabIndex = 15;
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
            logout.TabIndex = 34;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // InsertProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(backToList);
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
            Name = "InsertProduct";
            Text = "InsertProduct";
            Load += InsertProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pName;
        private Label pDesc;
        private Label pPrice;
        private Label pDiscount;
        private Label pStock;
        private Label pImg;
        private TextBox prodName;
        private TextBox prodDesc;
        private TextBox prodPrice;
        private TextBox prodDiscount;
        private TextBox prodStock;
        private TextBox prodImg;
        private Label label1;
        private Button btnAdd;
        private Button btnBrowse;
        private Button backToList;
        private Button logout;
    }
}
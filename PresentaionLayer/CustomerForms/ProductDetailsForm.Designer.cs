namespace PresentaionLayer.CustomerForms
{
    partial class ProductDetailsForm
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
            prodDiscount = new TextBox();
            prodPrice = new TextBox();
            prodDesc = new TextBox();
            prodName = new TextBox();
            pImg = new Label();
            pDiscount = new Label();
            pPrice = new Label();
            pDesc = new Label();
            pName = new Label();
            prodPic = new PictureBox();
            btnAddToCart = new Button();
            quantity = new TextBox();
            label2 = new Label();
            backToList = new Button();
            logout = new Button();
            ((System.ComponentModel.ISupportInitialize)prodPic).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(296, 25);
            label1.Name = "label1";
            label1.Size = new Size(213, 41);
            label1.TabIndex = 43;
            label1.Text = "Product Data ";
            // 
            // prodDiscount
            // 
            prodDiscount.Enabled = false;
            prodDiscount.Location = new Point(73, 234);
            prodDiscount.Name = "prodDiscount";
            prodDiscount.Size = new Size(287, 27);
            prodDiscount.TabIndex = 39;
            // 
            // prodPrice
            // 
            prodPrice.Enabled = false;
            prodPrice.Location = new Point(72, 170);
            prodPrice.Name = "prodPrice";
            prodPrice.Size = new Size(288, 27);
            prodPrice.TabIndex = 35;
            // 
            // prodDesc
            // 
            prodDesc.Enabled = false;
            prodDesc.Location = new Point(72, 302);
            prodDesc.Name = "prodDesc";
            prodDesc.Size = new Size(287, 27);
            prodDesc.TabIndex = 41;
            // 
            // prodName
            // 
            prodName.Enabled = false;
            prodName.Location = new Point(72, 112);
            prodName.Name = "prodName";
            prodName.Size = new Size(288, 27);
            prodName.TabIndex = 31;
            // 
            // pImg
            // 
            pImg.AutoSize = true;
            pImg.Location = new Point(421, 89);
            pImg.Name = "pImg";
            pImg.Size = new Size(51, 20);
            pImg.TabIndex = 40;
            pImg.Text = "Image";
            // 
            // pDiscount
            // 
            pDiscount.AutoSize = true;
            pDiscount.Location = new Point(73, 211);
            pDiscount.Name = "pDiscount";
            pDiscount.Size = new Size(103, 20);
            pDiscount.TabIndex = 36;
            pDiscount.Text = "Discount Price";
            // 
            // pPrice
            // 
            pPrice.AutoSize = true;
            pPrice.Location = new Point(72, 147);
            pPrice.Name = "pPrice";
            pPrice.Size = new Size(96, 20);
            pPrice.TabIndex = 34;
            pPrice.Text = "Product Price";
            // 
            // pDesc
            // 
            pDesc.AutoSize = true;
            pDesc.Location = new Point(72, 279);
            pDesc.Name = "pDesc";
            pDesc.Size = new Size(140, 20);
            pDesc.TabIndex = 32;
            pDesc.Text = "Product Description";
            // 
            // pName
            // 
            pName.AutoSize = true;
            pName.Location = new Point(73, 89);
            pName.Name = "pName";
            pName.Size = new Size(104, 20);
            pName.TabIndex = 30;
            pName.Text = "Product Name";
            // 
            // prodPic
            // 
            prodPic.Location = new Point(421, 112);
            prodPic.Name = "prodPic";
            prodPic.Size = new Size(321, 226);
            prodPic.TabIndex = 44;
            prodPic.TabStop = false;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(421, 373);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(259, 59);
            btnAddToCart.TabIndex = 45;
            btnAddToCart.Text = "Add To Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // quantity
            // 
            quantity.Location = new Point(202, 405);
            quantity.Name = "quantity";
            quantity.Size = new Size(157, 27);
            quantity.TabIndex = 47;
            quantity.TextChanged += quantity_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 382);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 46;
            label2.Text = "Requested Quantity";
            // 
            // backToList
            // 
            backToList.Location = new Point(8, 12);
            backToList.Name = "backToList";
            backToList.Size = new Size(168, 42);
            backToList.TabIndex = 48;
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
            logout.TabIndex = 49;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // ProductDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(logout);
            Controls.Add(backToList);
            Controls.Add(quantity);
            Controls.Add(label2);
            Controls.Add(btnAddToCart);
            Controls.Add(prodPic);
            Controls.Add(label1);
            Controls.Add(prodDiscount);
            Controls.Add(prodPrice);
            Controls.Add(prodDesc);
            Controls.Add(prodName);
            Controls.Add(pImg);
            Controls.Add(pDiscount);
            Controls.Add(pPrice);
            Controls.Add(pDesc);
            Controls.Add(pName);
            Name = "ProductDetailsForm";
            Text = "ProductDetailsForm";
            Load += ProductDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)prodPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox prodDiscount;
        private TextBox prodPrice;
        private TextBox prodDesc;
        private TextBox prodName;
        private Label pImg;
        private Label pDiscount;
        private Label pPrice;
        private Label pDesc;
        private Label pName;
        private PictureBox prodPic;
        private Button btnAddToCart;
        private TextBox quantity;
        private Label label2;
        private Button backToList;
        private Button logout;
    }
}
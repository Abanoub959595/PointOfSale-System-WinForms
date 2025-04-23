namespace PresentaionLayer.AdminForms.CustomerForms
{
    partial class UpdateCustomer
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
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            IsActive = new CheckBox();
            groupBox1 = new GroupBox();
            isAdmin = new CheckBox();
            IsCustomer = new CheckBox();
            label2 = new Label();
            userEmail = new TextBox();
            label3 = new Label();
            userName = new TextBox();
            label1 = new Label();
            btnBack = new Button();
            btnUpdate = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            logout = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(userEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(userName);
            panel1.Location = new Point(61, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(634, 213);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(IsActive);
            groupBox2.Location = new Point(371, 87);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 123);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Activiation";
            // 
            // IsActive
            // 
            IsActive.AutoSize = true;
            IsActive.Location = new Point(13, 35);
            IsActive.Name = "IsActive";
            IsActive.Size = new Size(86, 24);
            IsActive.TabIndex = 33;
            IsActive.Text = "Is Active";
            IsActive.UseVisualStyleBackColor = true;
            IsActive.CheckedChanged += IsActive_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(isAdmin);
            groupBox1.Controls.Add(IsCustomer);
            groupBox1.Location = new Point(115, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Role";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // isAdmin
            // 
            isAdmin.AutoSize = true;
            isAdmin.Location = new Point(20, 31);
            isAdmin.Name = "isAdmin";
            isAdmin.Size = new Size(93, 24);
            isAdmin.TabIndex = 23;
            isAdmin.Text = "Is Admin ";
            isAdmin.UseVisualStyleBackColor = true;
            isAdmin.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // IsCustomer
            // 
            IsCustomer.AutoSize = true;
            IsCustomer.Location = new Point(20, 76);
            IsCustomer.Name = "IsCustomer";
            IsCustomer.Size = new Size(108, 24);
            IsCustomer.TabIndex = 24;
            IsCustomer.Text = "Is Customer";
            IsCustomer.UseVisualStyleBackColor = true;
            IsCustomer.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 19);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 22;
            label2.Text = "Email";
            // 
            // userEmail
            // 
            userEmail.Enabled = false;
            userEmail.Location = new Point(384, 42);
            userEmail.Name = "userEmail";
            userEmail.Size = new Size(177, 27);
            userEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 19);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 14;
            label3.Text = "User Name";
            // 
            // userName
            // 
            userName.Enabled = false;
            userName.Location = new Point(115, 42);
            userName.Name = "userName";
            userName.Size = new Size(177, 27);
            userName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(216, 21);
            label1.Name = "label1";
            label1.Size = new Size(300, 41);
            label1.TabIndex = 13;
            label1.Text = "Updating User Data";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(674, 390);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 48);
            btnBack.TabIndex = 32;
            btnBack.Text = "Back To List";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkCyan;
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(229, 322);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(321, 84);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Save Changes";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.Firebrick;
            logout.Location = new Point(620, 12);
            logout.Name = "logout";
            logout.Size = new Size(168, 42);
            logout.TabIndex = 33;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // UpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logout);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "UpdateCustomer";
            Text = "UpdateCustomer";
            Load += UpdateCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox userEmail;
        private Label label3;
        private Label label1;
        private TextBox userName;
        private GroupBox groupBox1;
        private CheckBox isAdmin;
        private CheckBox IsCustomer;
        private Button btnBack;
        private Button btnUpdate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private CheckBox IsActive;
        private Button logout;
    }
}
namespace PresentaionLayer
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panel2 = new Panel();
            label6 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            userConfirmPassword = new TextBox();
            userPassword = new TextBox();
            linkLabel2 = new LinkLabel();
            userName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            resgister = new Button();
            label1 = new Label();
            label3 = new Label();
            userEmail = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 53, 85);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 34);
            panel2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(12, 7);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 4;
            label6.Text = "E-Commerce";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(764, 0);
            button1.Name = "button1";
            button1.Size = new Size(37, 34);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(userConfirmPassword);
            panel1.Controls.Add(userPassword);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(userName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(resgister);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(userEmail);
            panel1.Location = new Point(125, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(529, 341);
            panel1.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(321, 150);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 58;
            label5.Text = "Confirm Password";
            // 
            // userConfirmPassword
            // 
            userConfirmPassword.Location = new Point(321, 173);
            userConfirmPassword.Name = "userConfirmPassword";
            userConfirmPassword.Size = new Size(177, 27);
            userConfirmPassword.TabIndex = 47;
            userConfirmPassword.UseSystemPasswordChar = true;
            // 
            // userPassword
            // 
            userPassword.Location = new Point(52, 173);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(177, 27);
            userPassword.TabIndex = 46;
            userPassword.UseSystemPasswordChar = true;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Silver;
            linkLabel2.Location = new Point(177, 307);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(156, 20);
            linkLabel2.TabIndex = 53;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Already Have Account";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // userName
            // 
            userName.Location = new Point(52, 102);
            userName.Name = "userName";
            userName.Size = new Size(177, 27);
            userName.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 150);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 51;
            label4.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 79);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 56;
            label2.Text = "Email";
            // 
            // resgister
            // 
            resgister.Location = new Point(166, 269);
            resgister.Name = "resgister";
            resgister.Size = new Size(177, 35);
            resgister.TabIndex = 48;
            resgister.Text = "Register";
            resgister.UseVisualStyleBackColor = true;
            resgister.Click += resgister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(208, 23);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 49;
            label1.Text = "Register";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 79);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 50;
            label3.Text = "User Name";
            // 
            // userEmail
            // 
            userEmail.Location = new Point(321, 102);
            userEmail.Name = "userEmail";
            userEmail.Size = new Size(177, 27);
            userEmail.TabIndex = 45;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 534);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label6;
        private Button button1;
        private Panel panel1;
        private Label label5;
        private TextBox userConfirmPassword;
        private TextBox userPassword;
        private LinkLabel linkLabel2;
        private TextBox userName;
        private Label label4;
        private Label label2;
        private Button resgister;
        private Label label1;
        private Label label3;
        private TextBox userEmail;
    }
}
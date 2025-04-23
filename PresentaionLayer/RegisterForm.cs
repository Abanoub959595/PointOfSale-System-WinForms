using BLL;
using BLL.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentaionLayer
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userNameValue = userName.Text.Trim();
            string emailValue = userEmail.Text.Trim();
            string passwordValue = userPassword.Text;
            string confirmPasswordValue = userConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(userNameValue))
            {
                MessageBox.Show("User Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(emailValue))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (passwordValue.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(passwordValue, @"[A-Z]"))
            {
                MessageBox.Show("Password must contain at least one uppercase letter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(passwordValue, @"[0-9]"))
            {
                MessageBox.Show("Password must contain at least one number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordValue != confirmPasswordValue)
            {
                MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User()
            {
                name = userNameValue,
                email = emailValue,
                password = PasswordHasher.HashPassword(passwordValue)
            };

            var users = UserManager.SelectAll();
            foreach (var item in users)
            {
                if (item.email == emailValue)
                {
                    MessageBox.Show("Email Already Exists ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int res = UserManager.Register(user);


            MessageBox.Show($"{res} created");

        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void resgister_Click(object sender, EventArgs e)
        {
            string userNameValue = userName.Text.Trim();
            string emailValue = userEmail.Text.Trim();
            string passwordValue = userPassword.Text;
            string confirmPasswordValue = userConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(userNameValue))
            {
                MessageBox.Show("User Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(emailValue))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (passwordValue.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(passwordValue, @"[A-Z]"))
            {
                MessageBox.Show("Password must contain at least one uppercase letter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(passwordValue, @"[0-9]"))
            {
                MessageBox.Show("Password must contain at least one number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwordValue != confirmPasswordValue)
            {
                MessageBox.Show("Passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User()
            {
                name = userNameValue,
                email = emailValue,
                password = PasswordHasher.HashPassword(passwordValue)
            };

            var users = UserManager.SelectAll();
            foreach (var item in users)
            {
                if (item.email == emailValue)
                {
                    MessageBox.Show("Email Already Exists ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            int res = UserManager.Register(user);

            Close();
            Form1 form = new Form1();
            form.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}

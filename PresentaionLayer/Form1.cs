using BLL;
using BLL.Helper;
using PresentaionLayer.AdminForms;
using PresentaionLayer.CustomerForms;

namespace PresentaionLayer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.Transparent;
            panel3.Parent = this; // Set the panel's parent to the form or another control

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLayoutFrom p = new AdminLayoutFrom();
            p.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = UserManager.GetUserByEmail(email.Text);
            if (user == null || !PasswordHasher.VerifyPassword(password.Text, user.password))
            {
                MessageBox.Show("Email Or Password Not Valid");
                return;
            }

            if (!user.isActive)
            {
                MessageBox.Show("Not Active");
                return;
            }

            UserSession.Login(user);

            if (UserSession.IsAdmin)
            {
                AdminLayoutFrom from = new AdminLayoutFrom();
                //Close();
                from.Show();
            }
            else
            {
                CustomerProductList form = new CustomerProductList();
                //Close();
                form.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Parent = this;
            panel3.BackColor = Color.Transparent;

        }
    }
}
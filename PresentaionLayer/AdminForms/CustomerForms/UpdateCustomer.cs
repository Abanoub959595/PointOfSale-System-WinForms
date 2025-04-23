using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaionLayer.AdminForms.CustomerForms
{
    public partial class UpdateCustomer : Form
    {
        User userData;
        public UpdateCustomer(string userId)
        {
            userData = UserManager.GetUserById(userId);
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();
            CustomerListForm form = new CustomerListForm();
            form.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var res = UserManager.UpdateUserData(userData.id, IsActive.Checked, isAdmin.Checked, IsCustomer.Checked);
            MessageBox.Show($"{res}");
            if (res > 0)
            {
                MessageBox.Show("Data Updated Successfully");
            }
            else
            {
                MessageBox.Show("Something went worng!");
            }
            //Close();
            Hide();
            CustomerListForm customerListForm = new CustomerListForm();
            customerListForm.ShowDialog();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!isAdmin.Checked && !IsCustomer.Checked)
            {
                // Ensure at least one checkbox remains checked
                CheckBox changedCheckBox = sender as CheckBox;
                changedCheckBox.Checked = true;
                MessageBox.Show("At least one role must be selected!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!isAdmin.Checked && !IsCustomer.Checked)
            {
                // Ensure at least one checkbox remains checked
                CheckBox changedCheckBox = sender as CheckBox;
                changedCheckBox.Checked = true;
                MessageBox.Show("At least one role must be selected!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            logout.ForeColor = Color.White;
            userEmail.Text = userData.email;
            userName.Text = userData.name;
            IsCustomer.Checked = userData.isCustomer;
            isAdmin.Checked = userData.isAdmin;
            IsActive.Checked = userData.isActive;

            this.BackColor = Color.FromArgb(240, 240, 240); // Light Gray Background
        }

        private void IsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            //Close();
            Hide();
            Form1 form = new Form1();
            UserSession.Logout();
            form.ShowDialog();
        }
    }
}

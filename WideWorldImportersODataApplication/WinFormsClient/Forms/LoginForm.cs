using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsClient.Helper;

namespace WinFormsClient.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "Administrator" && tbPassword.Text == "Password")
            {
                CurrentUserHelper.currentUserName = tbName.Text;
                CurrentUserHelper.currentUserPassword = tbPassword.Text;
                lbResult.ForeColor = Color.Green;
                DialogResult = DialogResult.OK;
                MessageBox.Show("Successfully logged in");

            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}

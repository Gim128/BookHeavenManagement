using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHeavenManagement.Services;

namespace BookHeavenManagement.Forms.Auth
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _authService.Authenticate(txtUsername.Text, txtPassword.Text);
                if (user != null)
                {
                    var mainForm = new MainForm(user);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

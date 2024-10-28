using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogIn.Entity;

namespace LogIn
{
    public partial class LogInForm : Form
    {
        public User User { get; set; }
        public List<User> Users { get; set; }
        public LogInForm()
        {

            InitializeComponent();
        }
        public LogInForm(User user)
        {
            this.User = user;
            InitializeComponent();
        }



        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPassword.Text;
            var userData = Users.FirstOrDefault(a => a.Username == username);
            if (userData == null)
            {
                lblError.Text = "User does not exist!";
                return;
            }
            if (username.ToLower() == userData.Username.ToLower())
            {
                if(password == userData.Password)
                {
                    DashboardForm dashboardForm = new DashboardForm(userData);
                    this.Hide();
                    dashboardForm.ShowDialog();
                    
                }
                else
                {
                    lblError.Text = "Invalid Password!";
                    lblForgotPass.Visible = true;
                    btnForgotPass.Visible = true;
                    btnForgotPass.Enabled = true;
                }

            }
           
        }

        private void ForgotPassPortal_Click(object sender, EventArgs e)
        {
            ForgotPass ForgotPass = new ForgotPass();
            this.Hide();
            ForgotPass.ShowDialog();
        }
    }
}

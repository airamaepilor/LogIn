using LogIn.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LogIn
{
    public partial class ForgotPass : Form
    {
        public User User { get; set; }
        public List<User> Users { get; set; }
        public ForgotPass()
        {
            Users = new List<User>();
            User = new User();
            InitializeComponent();
        }

        public Boolean Accept = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            string uName = txtUsername.Text;
            string pass = txtPassword.Text;
            var userData = Users.FirstOrDefault(a => a.Username == uName);
            if (uName == null)
            {
                Validation.Text = "User does not exist!";
                return;
            }
            if (uName.ToLower() == userData.Username.ToLower())
            {
                lblPassword.Visible = true;
                txtPassword.Visible = true;
                lblConfirmation.Visible = true;
                txtConfirmation.Visible = true;
                lblForgotPass.Text = "Fill in to change your password:";
                btnSave.Text = "Update";
                if (pass == txtConfirmation.Text)
                {
                    userData.Password = pass;
                    Validation.Text = "Password successfully changed.";
                    LogInForm loginform = new LogInForm();
                    this.Hide();
                    loginform.ShowDialog();
                }
                else
                {
                    Validation.Text = "Password doesn't match!!";
                }
            }
            Validation.Text = "User does not exist!!";
        }




        private void btnLogInPortal_Click(object sender, EventArgs e)
        {
            LogInForm loginform = new LogInForm();
            this.Hide();
            loginform.ShowDialog();
        }
    }
}


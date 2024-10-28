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
    public partial class RegisterForm : Form
    {
        public User User { get; set; }
        public List<User> Users { get; set; }
        public RegisterForm()
        {
            Users = new List<User>();
            User = new User();
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Register_Click(object sender, EventArgs e)
        {
            /* User.Name = txtName.Text;
             User.Username = txtUsername.Text;
             User.Password = txtPassword.Text;
             if (User.Password != txtConfirmation.Text)
             {
                 Validation.Text = "Password doesn't match!!";
             }
             LogInForm logInForm = new LogInForm(User);*/

            var loginForm = new LogInForm
            {
                Users = Users
            };
            this.Hide();
            loginForm.ShowDialog();

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            
            string fname = txtName.Text;
            string uName = txtUsername.Text;
            string pass = txtPassword.Text;
            if (pass != txtConfirmation.Text)
            {
                Validation.Text = "Password doesn't match!!";
            }
            User.Name = fname;
            User.Username = uName;
            User.Password = pass;
            Users.Add(User);

            BaseEntity.ClearForm(this);
            lblSuccess.Text = $"User {fname} has been succesfully registered";


          

            
        }

    }
}

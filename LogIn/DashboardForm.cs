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
    public partial class DashboardForm : Form
    {
        public User User { get; set; }
        public DashboardForm(User user)
        {
            this.User = user;
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            NameHolder.Text = User.Name;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInForm loginform = new LogInForm();
            this.Hide();
            loginform.ShowDialog();
        }
    }
}

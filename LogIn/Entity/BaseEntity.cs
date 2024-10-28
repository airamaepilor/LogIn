using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LogIn.Entity
{
    public abstract class BaseEntity
    {
        public static void ClearForm(Form form) 
        {
            foreach (Control control in form.Controls)
            {
                if(control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
               
            }

        }
    }
}

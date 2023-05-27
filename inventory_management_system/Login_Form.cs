using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management_system
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void login_form_login_button_Click(object sender, EventArgs e)
        {
            if(login_form_username_textBox.Text=="stz" && login_form_password_textBox.Text=="stz123")
            {
                this.Hide();

                Admin_Form af = new Admin_Form();
                af.Show();
                af.BringToFront();
            }
            else
            {
                MessageBox.Show("WRONG USERNAME AND PASSWORD");
            }

        }

        private void admin_form_exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

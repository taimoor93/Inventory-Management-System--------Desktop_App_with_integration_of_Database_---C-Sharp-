using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inventory_management_system
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void admin_product_button_Click(object sender, EventArgs e)
        {
            if(product_dropdown_panel.Height == 50)
            {
                product_dropdown_panel.Height = 150;
            }
            else
            {
                this.product_dropdown_panel.Height = 50;
            }
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void display_button_Click(object sender, EventArgs e)
        {
            manage_Product_UserControl.Hide();
            dashboard_UserControl.Hide();

            display_Product_UserControl.Show();
            display_Product_UserControl.BringToFront();

        }

        private void manage_product_button_Click(object sender, EventArgs e)
        {
            display_Product_UserControl.Hide();
            dashboard_UserControl.Hide();

            manage_Product_UserControl.Show();
            manage_Product_UserControl.BringToFront();
        }

        private void admin_form_whole_panel_Paint(object sender, PaintEventArgs e)
        {
            manage_Product_UserControl.Hide();
            display_Product_UserControl.Hide();
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            manage_Product_UserControl.Hide();
            display_Product_UserControl.Hide();

            dashboard_UserControl.Show();
            dashboard_UserControl.BringToFront();
        }

        // dropdown for menu bar 
        /*
        private void Dropdown_panel()
        {
            product_dropdown_panel.Visible = false;
        }
        private void hideDropdown()
        {
            if(product_dropdown_panel.Visible == true)
            {
                product_dropdown_panel.Visible = false;
            }
        }
        private void showDropdown(Panel subMenu)
        {
            if (subMenu.Visible == false )
            {
                hideDropdown();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        */
    }
}

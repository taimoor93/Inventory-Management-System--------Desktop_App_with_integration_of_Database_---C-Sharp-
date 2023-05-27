using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inventory_management_system
{
    public partial class Display_Product_UserControl : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\inventory_management_system\inventory_management_system\Database.mdf;Integrated Security=True");

        public Display_Product_UserControl()
        {
            InitializeComponent();
        }

        private void display_product_panel_Paint(object sender, PaintEventArgs e)
        {
            display_data_in_Grid_View_Product();
        }

        public void display_data_in_Grid_View_Product()
        {
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Product";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            admin_product_dataGridView.DataSource = dt;

            con.Close();
        }

        private void admin_form_exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_product_search_textBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        int count = 0;

        private void admin_form_product_search_button_Click(object sender, EventArgs e)
        {
            con.Open();
            /*, Product_Name='" + admin_product_search_textBox.Text + "', Brand_Name='" + admin_product_search_textBox.Text + "', Quantity='" + admin_product_search_textBox.Text + "', Rate='" + admin_product_search_textBox.Text + "' , Total_Quantity='" + admin_product_search_textBox.Text + "'*/
            count = 0;

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Product where Bar_Code='"+admin_product_search_textBox.Text+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            admin_product_dataGridView.DataSource = dt;

            con.Close();


            if(count == 0)
            {
                MessageBox.Show("RECORD NOT FOUND ");
            }

        }
    }
}

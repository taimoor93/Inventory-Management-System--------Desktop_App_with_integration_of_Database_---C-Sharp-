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
    public partial class Manage_Product_UserControl : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\inventory_management_system\inventory_management_system\Database.mdf;Integrated Security=True");

        public Manage_Product_UserControl()
        {
            InitializeComponent();
        }

        private void admin_product_panel_Paint(object sender, PaintEventArgs e)
        {
            display_data_in_Grid_View_Product();
        }

        private void admin_product_add_button_Click(object sender, EventArgs e)
        {
            int total_amount, quantity, rate;

            quantity = Convert.ToInt32(quantity_textBox.Text);
            rate = Convert.ToInt32(rate_textBox.Text);
            total_amount = quantity * rate;

            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Product values('" + bar_code_textBox.Text + "','" + product_name_textBox.Text + "','" + brand_name_textBox.Text + "','" + quantity_textBox.Text + "','" + rate_textBox.Text + "','" + total_amount + "') ";
                cmd.ExecuteNonQuery();

                con.Close();

                display_data_in_Grid_View_Product();

                MessageBox.Show("RECORD INSERT SUCCESSFULLY ");

                Clear_Product();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "YOU WRITTEN ANYTHING WRONG");
            }
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

        public void Clear_Product()
        {
            bar_code_textBox.Clear();
            product_name_textBox.Clear();
            brand_name_textBox.Clear();
            quantity_textBox.Clear();
            rate_textBox.Clear();
        }

        private void admin_product_update_button_Click(object sender, EventArgs e)
        {
            int total_amount, quantity, rate;

            quantity = Convert.ToInt32(quantity_textBox.Text);
            rate = Convert.ToInt32(rate_textBox.Text);
            total_amount = quantity * rate;

            try
            {
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Product SET  Product_Name='" + product_name_textBox.Text + "',Brand_Name='" + brand_name_textBox.Text + "',Quantity='" + quantity_textBox.Text + "',Rate='" + rate_textBox.Text + "',Total_Quantity='" + total_amount + "' where Bar_Code='" + bar_code_textBox.Text + "' ";
                cmd.ExecuteNonQuery();

                con.Close();

                display_data_in_Grid_View_Product();

                MessageBox.Show("RECORD UPDATED SUCCESSFULLY ");

                Clear_Product();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "YOU WRITTEN ANYTHING WRONG");
            }
        }

        private void admin_product_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bar_code_textBox.Text = admin_product_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            product_name_textBox.Text = admin_product_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            brand_name_textBox.Text = admin_product_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            quantity_textBox.Text = admin_product_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            rate_textBox.Text = admin_product_dataGridView.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void admin_product_delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "delete from Product where Bar_Code='" + bar_code_textBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();

                con.Close();

                display_data_in_Grid_View_Product();

                MessageBox.Show("RECORD DELETED  SUCCESSFULLY ");

                Clear_Product();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "YOU WRITTEN ANYTHING WRONG");
            }
        }

        private void admin_form_exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

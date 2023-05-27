using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_management_system
{
    public partial class Dashboard_UserControl : UserControl
    {
        public Dashboard_UserControl()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(125,Color.LightGray);
        }

        private void admin_form_exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_UserControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(slider_1_1_pictureBox.Visible == true)
            {
                slider_1_1_pictureBox.Visible = false;
                image_slider_1_2_pictureBox.Visible = true;
            }
            else if (image_slider_1_2_pictureBox.Visible == true)
            {
                image_slider_1_2_pictureBox.Visible = false;
                image_slider_1_3_pictureBox.Visible = true;
            }
            else if(image_slider_1_3_pictureBox.Visible == true)
            {
                image_slider_1_3_pictureBox.Visible = false;
                slider_1_1_pictureBox.Visible = true;
            }
        }

      
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(slider_2__1_pictureBox.Visible == true)
            {
                slider_2__1_pictureBox.Visible = false;
                slider_2__2_pictureBox.Visible = true;
            }
            else if(slider_2__2_pictureBox.Visible == true)
            {
                slider_2__2_pictureBox.Visible = false;
                slider_2__1_pictureBox.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (slider_3_1_pictureBox.Visible == true)
            {
                slider_3_1_pictureBox.Visible = false;
                slider_3_2_pictureBox.Visible = true;
            }
            else if (slider_3_2_pictureBox.Visible == true)
            {
                slider_3_2_pictureBox.Visible = false;
                slider_3_3_pictureBox.Visible = true;
            }
            else if (slider_3_3_pictureBox.Visible == true)
            {
                slider_3_3_pictureBox.Visible = false;
                slider_3_1_pictureBox.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            time_label.Text = DateTime.Now.ToLongTimeString();
            date_label.Text = DateTime.Now.ToLongDateString();

            timer1.Start();
            timer2.Start();
            timer3.Start();
        }
    }
}

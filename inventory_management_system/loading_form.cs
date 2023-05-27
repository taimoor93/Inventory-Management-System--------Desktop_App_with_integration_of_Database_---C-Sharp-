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
    public partial class loading_form : Form
    {
        public loading_form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Width += 2;
                if(pictureBox1.Width >= 800)
                {
                    timer1.Stop();

                    Login_Form lf = new Login_Form();
                    lf.Show();
                    lf.BringToFront();
                    this.Hide();
                }
            }
            catch(Exception)
            {
                return;
            }


        }

        private void loading_form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

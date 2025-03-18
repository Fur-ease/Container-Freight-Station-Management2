using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Container_Freight_Station_Management
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                // No need to handle the "No" case explicitly since the form will just continue to run
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnaddcontainer_Click(object sender, EventArgs e)
        {
            dashboard1.Hide();
            Addcontainer A = new Addcontainer();
            A.Show();

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Show();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load_2(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load_3(object sender, EventArgs e)
        {

        }
    }
}

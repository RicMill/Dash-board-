using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dash_board_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void filebutton_Click(object sender, EventArgs e)
        {

            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Location = new Point(currentX, currentY);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private bool isSideBarHidden = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (isSideBarHidden) //Sidebar is currently opened
            {
                //hide the sidebar
                for (int i = Sidebarcontainer.Width; i >= 125; i -= 20)
                {
                    Sidebarcontainer.Width = i;
                    Refresh();
                    System.Threading.Thread.Sleep(2);//Adjust the delay as needed
                }
                isSideBarHidden = false;

            }
            else //Sidebar is currently closed
            {
                //Show the sidebar
                for (int i = Sidebarcontainer.Width; i <= 580; i += 20)
                {
                    Sidebarcontainer.Width = i;
                    Refresh();

                    System.Threading.Thread.Sleep(2); // Adjust the display as needed

                }
                isSideBarHidden = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Location = new Point(currentX, currentY);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Location = new Point(currentX, currentY);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Location = new Point(currentX, currentY);
        }

        private void filebutton_Click_1(object sender, EventArgs e)
        {
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
            this.Location = new Point(currentX, currentY);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Location = new Point(currentX, currentY);

        }

        private void filebutton_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Location = new Point(currentX, currentY);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

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
            this.Location = new Point(currentX, currentY);
        }

        private void filebutton_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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

        private void button6_Click(object sender, EventArgs e)
        {
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Location = new Point(currentX, currentY);
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

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
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

        private void button7_Click(object sender, EventArgs e)
        {

        }
        private bool isDarkMode = false;

        private void ToggleDarkMode()
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                // Set dark mode colors
                this.BackColor = System.Drawing.Color.FromArgb(31, 31, 31);
                this.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                // Set light mode colors
                this.BackColor = System.Drawing.SystemColors.Control;
                this.ForeColor = System.Drawing.SystemColors.ControlText;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }
    }

}

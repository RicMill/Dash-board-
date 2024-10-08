﻿using System;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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

        private void filebutton_Click(object sender, EventArgs e)
        {
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
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

        private void button6_Click(object sender, EventArgs e)
        {
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Location = new Point(currentX, currentY);
        }
    }
}

namespace Dash_board_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click_1(object sender, EventArgs e)
        {


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Shapes1_Click(object sender, EventArgs e)
        {

        }

        private void Sidebarcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel34_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private bool isSideBarHidden = true;
        private void button2_Click_2(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {

            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();
            this.Location = new Point(currentX, currentY);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int currentX = this.Location.X;
            int currentY = this.Location.Y;
            this.Hide();
            Form6 form6 = new Form6();
            form6.ShowDialog();
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

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_2019
{
    public partial class January : Form
    {

        private bool isCollapsed;
        public January()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            February next = new February();
            next.Show();
            this.Hide();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            December last = new December();
            last.Show();
            this.Hide();
        }
        private void button35_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            loginPage pre = new loginPage();
            pre.Show();
            this.Hide();
        }

        private void January_Load(object sender, EventArgs e)
        {
            timer1.Start();
            textBox1.Text = DateTime.Now.ToShortTimeString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }


        private void button31_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Input inp = new Input();
            inp.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                panel1.Height += 10;

                if (panel1.Size == panel1.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }

            else
            {
                panel1.Height -= 10;

                if (panel1.Size == panel1.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }

        }
        private void button36_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void button37_Click(object sender, EventArgs e)
        {
            All abc = new All();
            abc.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            All abc = new All();
            abc.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            All abc = new All();
            abc.Show();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

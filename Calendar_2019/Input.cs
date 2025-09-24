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
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            panel1.BackColor = Color.FromArgb(130, Color.Black);
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appoinment app = new Appoinment();
            app.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Event eve = new Event();
            eve.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Meeting met = new Meeting();
            met.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calendar_2019
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            panel1.BackColor = Color.FromArgb(130, Color.Purple);
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100, 100);

        }

        public string conString = "Data Source=SANA-AZMAT-KHAN\\SQLEXPRESS;Initial Catalog=Calendar_2019;Integrated Security=True";



        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.White;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.DarkOrchid;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Purple;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.White;
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.DarkOrchid;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Purple;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.ForeColor = Color.White;
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.DarkOrchid;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Purple;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.ForeColor = Color.White;
        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.DarkOrchid;
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Purple;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox5.ForeColor = Color.White;
        }

        private void textBox5_MouseHover(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.DarkOrchid;
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.Purple;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.ForeColor = Color.White;
        }

        private void textBox6_MouseHover(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.DarkOrchid;
        }

        private void textBox6_MouseLeave(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.Purple;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox7.ForeColor = Color.White;
        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.DarkOrchid;

        }

        private void textBox7_MouseLeave(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.Purple;
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox8.ForeColor = Color.White;
        }

        private void textBox8_MouseHover(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.DarkOrchid;
        }

        private void textBox8_MouseLeave(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.Purple;
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox9.ForeColor = Color.White;
        }

        private void textBox9_MouseHover(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.DarkOrchid;
        }

        private void textBox9_MouseLeave(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.Purple;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.Lime;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.Green;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gold;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.Yellow;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.OrangeRed;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();


            SqlCommand cmd = new SqlCommand("insert into eventss(Eve_ID,Eve_Title,Eve_Description,Date_Start,Date_End,Time_Begin,Time_End,Eve_Venue,U_ID) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox9.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox2.Text + "')", con);
                int i = (int)cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    string message = "Event Added Successfully";
                    string title = "";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Please Fill Correctly"); }
                con.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

                SqlCommand cmd = new SqlCommand("delete from eventss where Eve_ID= '" + textBox1.Text + "'", con);
                int i = (int)cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    string message = "Event Added Successfully";
                    string title = "";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Sorry! Event Not Deleted. Please Enter The Evwnt ID"); }
                con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlCommand cmd = new SqlCommand("update eventss set Eve_Title='" + textBox3.Text + "',Eve_Description='" + textBox9.Text + "',Date_Start='" + textBox4.Text + "',Date_End='" + textBox6.Text + "',Time_Begin='" + textBox5.Text + "',Time_End='" + textBox7.Text + "',Eve_Venue='" + textBox8.Text + "',U_ID= '" + textBox2.Text + "' where Eve_ID= '" + textBox1.Text + "'", con);
                int i = (int)cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    string message = "Event Added Successfully";
                    string title = "";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Please Fill Correctly"); }
                con.Close();
            }

        private void Event_Load(object sender, EventArgs e)
        {
            //timer1.Start();
           // textBox5.Text = DateTime.Now.ToShortTimeString();
           // textBox7.Text = DateTime.Now.ToLongTimeString();
         //   textBox4.Text = DateTime.Now.ToLongDateString();
         //   textBox6.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // textBox7.Text = DateTime.Now.ToLongTimeString();
           // textBox5.Text = DateTime.Now.ToLongTimeString();
           // timer1.Start();
        }
        }
        }


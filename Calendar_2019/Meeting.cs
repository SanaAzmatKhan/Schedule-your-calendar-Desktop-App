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
    public partial class Meeting : Form
    {
        public Meeting()
        {
            InitializeComponent();
             this.BackColor = Color.White;
             panel1.BackColor = Color.FromArgb(130, Color.Navy); 
        }
        protected override void OnPaint(PaintEventArgs e) {

            e.Graphics.DrawLine(Pens.Yellow, 0, 0, 100 , 100);
        
        }

        public string conString = "Data Source=SANA-AZMAT-KHAN\\SQLEXPRESS;Initial Catalog=Calendar_2019;Integrated Security=True";

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Meeting_Load(object sender, EventArgs e)
        {
            

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
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlCommand cmd = new SqlCommand("update meetingss set M_ID='" + textBox1.Text + "',Client_ID='" + textBox3.Text + "',Client_Name='" + textBox4.Text + "',Client_contatct='" + textBox5.Text + "',Client_email='" + textBox6.Text + "',Date_Start='" + textBox7.Text + "',Date_End='" + textBox8.Text + "',Time_begin='" + textBox9.Text + "',Time_end='" + textBox10.Text + "',M_attendees='" + textBox13.Text + "',M_Summary='" + textBox11.Text + "',M_Venue='" + textBox12.Text + "',U_ID='" + textBox2.Text + "' where M_ID='" + textBox1.Text + "'", con);
            int i = (int)cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    string message = "Meeting Updated Successfully";
                    string title = "";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";

            }
                else { MessageBox.Show("Sorry! Meeting Not Updated. Please fill Correctly"); }
                con.Close();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (textBox1.Text == "") {
                MessageBox.Show("Please Enter Meeting ID");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Please Enter Client ID");
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please Enter Client Name");
            }
            SqlCommand cmd = new SqlCommand("insert into meetingss(M_ID,Client_ID,Client_Name,Client_contatct,Client_email,Date_Start,Date_End,Time_begin,Time_end,M_attendees,M_Summary,M_Venue,U_ID) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox13.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox2.Text + "') ", con);
                int i = (int)cmd.ExecuteNonQuery();



                if (i > 0)
                {
                    string message = "Meeting Added Successfully";
                    string title = "";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                textBox13.Text = "";

            }
                else { MessageBox.Show("Sorry! Meeting Not Added. Please fill Correctly"); }
                con.Close();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox1.ForeColor = Color.White;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.RoyalBlue;
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.MidnightBlue;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.White;
        }

        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.RoyalBlue;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.MidnightBlue;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.ForeColor = Color.White;
        }

        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.RoyalBlue;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.MidnightBlue;
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.ForeColor = Color.White;
        }

        private void textBox4_MouseHover(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.RoyalBlue;
        }

        private void textBox4_MouseLeave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.MidnightBlue;
        }

        private void textBox5_Click(object sender, EventArgs e)
        {

            textBox5.Text = "";
            textBox5.ForeColor = Color.White;
        }

        private void textBox5_MouseHover(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.RoyalBlue;
        }

        private void textBox5_MouseLeave(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.MidnightBlue;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.ForeColor = Color.White;
        }

        private void textBox6_MouseHover(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.RoyalBlue;
        }

        private void textBox6_MouseLeave(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.MidnightBlue;
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox7.ForeColor = Color.White;
        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.RoyalBlue;
        }

        private void textBox7_MouseLeave(object sender, EventArgs e)
        {
            textBox7.BackColor = Color.MidnightBlue;

        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox8.ForeColor = Color.White;
        }

        private void textBox8_MouseHover(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.RoyalBlue;

        }

        private void textBox8_MouseLeave(object sender, EventArgs e)
        {
            textBox8.BackColor = Color.MidnightBlue;

        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox9.ForeColor = Color.White;
;
        }

        private void textBox9_MouseHover(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.RoyalBlue;
        }

        private void textBox9_MouseLeave(object sender, EventArgs e)
        {
            textBox9.BackColor = Color.MidnightBlue;
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox10.ForeColor = Color.White;
        }

        private void textBox10_MouseHover(object sender, EventArgs e)
        {
            textBox10.BackColor = Color.RoyalBlue;
        }

        private void textBox10_MouseLeave(object sender, EventArgs e)
        {
            textBox10.BackColor = Color.MidnightBlue;
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
            textBox11.ForeColor = Color.White;
        }

        private void textBox11_MouseHover(object sender, EventArgs e)
        {
            textBox11.BackColor = Color.RoyalBlue;
        }

        private void textBox11_MouseLeave(object sender, EventArgs e)
        {
            textBox11.BackColor = Color.MidnightBlue;
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox12.ForeColor = Color.White;
        }

        private void textBox12_MouseHover(object sender, EventArgs e)
        {
            textBox12.BackColor = Color.RoyalBlue;

        }

        private void textBox12_MouseLeave(object sender, EventArgs e)
        {
            textBox12.BackColor = Color.MidnightBlue;
        }
        private void textBox13_Click(object sender, EventArgs e)
        {
            textBox13.Text = "";
            textBox13.ForeColor = Color.White;
        }

        private void textBox13_MouseHover(object sender, EventArgs e)
        {
            textBox13.BackColor = Color.RoyalBlue;

        }

        private void textBox13_MouseLeave(object sender, EventArgs e)
        {
            textBox13.BackColor = Color.MidnightBlue;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
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

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();


            if (con.State == System.Data.ConnectionState.Open)
            {
                
                SqlCommand cmd = new SqlCommand("delete from meetingss where M_ID = '" + textBox1.Text + "'", con);
                int i = (int)cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    string message = "Meeting Deleted Successfully";
                    string title = "";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
                }
                else { MessageBox.Show("Sorry! Meeting Not Deleted. Enter Meeting ID"); }
                con.Close();
            }
        }
    }
}
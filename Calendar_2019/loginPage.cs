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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
            textBox2.PasswordChar='*';
        }

      //Connection String

        SqlConnection con = new SqlConnection(@"Data Source=SANA-AZMAT-KHAN\SQLEXPRESS;Initial Catalog=Calendar_2019;Persist Security Info=True;User ID=sa;Password=72628637");


        private void label1_Click(object sender, EventArgs e)
        {

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {

                con.Open();

                string q = "select U_ID, U_Name, U_Password from usser where U_ID= '" + textBox1.Text + "' and  U_Name = '" + textBox3.Text + "' and U_Password='" + textBox2.Text + "' ";


                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                adp.Fill(data);

                if (data.Rows.Count > 0)
                {
                    /*  MessageBox.Show("Login Successfully");
                      January start = new January();
                      start.Show();
                      this.Hide(); */

                    January start = new January();
                    start.Show();

                    string message = "Welcome to Calendar 2019";
                      string title = "Log In";

                      MessageBoxButtons buttons = MessageBoxButtons.OK;
                      DialogResult result = MessageBox.Show(message,title, buttons, MessageBoxIcon.Information);

                      if (result == DialogResult.OK)
                      {
                          this.Hide();
                      }
               }
                else
                {
                    MessageBox.Show("Please Enter Correct Values");
                    
                }
                con.Close();
            }

            else
            {
                MessageBox.Show("Please Fill Correctly");
            }
           ;
        }
                private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.BackColor= Color.Linen ;
        }
        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Linen;
        }
        private void textBox3_MouseHover(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Linen;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
            
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.ForeColor = Color.Black;
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
           
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Gainsboro;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Gainsboro;
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Gainsboro;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Sienna;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SaddleBrown;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
    }
}

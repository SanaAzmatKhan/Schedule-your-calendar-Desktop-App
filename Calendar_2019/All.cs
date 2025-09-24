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
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=SANA-AZMAT-KHAN\\SQLEXPRESS;Initial Catalog=Calendar_2019;Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from appoinments", con);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from eventss", con);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from meetingss", con);
            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;
        }
    }
}

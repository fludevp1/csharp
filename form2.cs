using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\source\repos\WinFormsApp4\WinFormsApp4\Database1.mdf;Integrated Security=True";
            SqlConnection s = new SqlConnection(con);
            s.Open();
            SqlCommand cmd = new SqlCommand("select * from detail where id = @id",s);
            cmd.Parameters.AddWithValue("id", textBox1.Text);
            SqlDataReader r;
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                textBox2.Text = r["fname"].ToString();
                textBox3.Text = r["lname"].ToString();
                textBox4.Text = r["city"].ToString();
                textBox5.Text = r["country"].ToString();
            }
            else
            {
                MessageBox.Show("data not found");
            }

;
            
        }
    }
}

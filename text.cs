using System.Data.SqlClient;


namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = textBox1.Text;
            string l = textBox2.Text;
            string c = textBox3.Text;
            string cc = comboBox1.Text;

            if (f.Equals(""))
            {
                MessageBox.Show("first name should not be empty");
            }else if
                (l.Equals(""))
                {
                    MessageBox.Show("last name should not be empty");
                }
            else if
                (c.Equals(""))
            {
                MessageBox.Show("city name should not be empty");
            }
            else if
                (cc.Equals(""))
            {
                MessageBox.Show("country should not be empty");
            }
            else
            {
                string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\admin\source\repos\WinFormsApp4\WinFormsApp4\Database1.mdf;Integrated Security=True";
                SqlConnection s = new SqlConnection(con);
                string q = "insert into detail (fname,lname,city,country)values('" + f + "','" + l + "','" + c + "','" + cc + "')";
                SqlCommand cmd = new SqlCommand(q, s);
                s.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("data has been inseretd");
                }


            }
        }
        }
    }

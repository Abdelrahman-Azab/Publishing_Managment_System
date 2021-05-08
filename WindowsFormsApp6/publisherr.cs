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

namespace WindowsFormsApp6
{
    public partial class publisherr : Form
    {
        public publisherr()
        {
            InitializeComponent();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con2.Open();
            string sqlselectquery = "Select author_n,category_paper,article from paper where name_paper ='" + comboBox1.Text + "'";
            SqlCommand cmdd = new SqlCommand(sqlselectquery, con2);
            SqlDataReader da1 = cmdd.ExecuteReader();
            while (da1.Read())
            {
                textBox1.Text = (da1["author_n"].ToString());
                textBox3.Text = (da1["category_paper"].ToString());
                textBox2.Text = (da1["article"].ToString());
            }
            da1.Close();
            con2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string update_query = @"update paper Set accept='" + textBox5.Text + "' where name_paper='" + comboBox1.Text+ "'";
            SqlCommand comm = new SqlCommand(update_query, con);
            comm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thank You ,Waiting the admin for accept");
            Hide();
            Form1 f = new Form1();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string delete_query = @"delete paper where name_paper='" + comboBox1.Text + "' ";
            SqlCommand comm = new SqlCommand(delete_query, con);
            comm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thank You!!");
            Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string sqlselectquery2 = "Select name_paper from paper where accept ='" + textBox4.Text + "' ";
            SqlCommand cmddr = new SqlCommand(sqlselectquery2, con);
            cmddr.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmddr);
            da2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["name_paper"].ToString());
            }
            con.Close();
        }
    }
}

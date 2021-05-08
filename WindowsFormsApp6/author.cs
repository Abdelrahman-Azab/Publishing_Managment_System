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
    public partial class author : Form
    {

        String name_a;
        public author()
        {
            InitializeComponent();
        }
        public author(String nameofform)
        {
            name_a = nameofform;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();

            //SqlCommand cmd = new SqlCommand("INSERT INTO paper(name_paper,category_paper,publisher_name,author_n,article,price) VALUES(@name_paper,@category_paper,@publisher_name,@author_n,@article,@price)", con);
            SqlCommand cmd = new SqlCommand("insert_author", con);

            cmd.Parameters.Add("@name_paper", textBox1.Text);
            if (checkBox1.Checked == true)
            {
                cmd.Parameters.Add("@category_paper", checkBox1.Text);
            }
            else if (checkBox2.Checked == true)
            {
                cmd.Parameters.Add("@category_paper", checkBox2.Text);
            }
            else if (checkBox3.Checked == true)
            {
                cmd.Parameters.Add("@category_paper", checkBox3.Text);
            }
            else if (checkBox4.Checked == true)
            {
                cmd.Parameters.Add("@category_paper", checkBox4.Text);
            }
            else if (checkBox5.Checked == true)
            {
                cmd.Parameters.Add("@category_paper", checkBox5.Text);
            }
            else if (checkBox6.Checked == true)
            {
                cmd.Parameters.Add("@category_paper", checkBox6.Text);
            }
            else if (checkBox7.Checked == true)
            {
                cmd.Parameters.Add("@category_paper", checkBox7.Text);
            }
            else if (checkBox8.Checked == true)
            {
                cmd.Parameters.Add("@category_paper", checkBox8.Text);
            }
            cmd.Parameters.Add("@article", textBox2.Text);
            cmd.Parameters.Add("@price", textBox4.Text);
            cmd.Parameters.Add("@publisher_name", comboBox1.SelectedItem.ToString());
            cmd.Parameters.Add("@author_n", name_a);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thank you!,Waiting the Accept from Publisher");
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string sqlselectquery2 = "Select publisher_name from paper where category_paper ='" + checkBox1.Text + "'";
            SqlCommand cmddr = new SqlCommand(sqlselectquery2, con);
            cmddr.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmddr);
            da2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["publisher_name"].ToString());
            }
            con.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string sqlselectquery2 = "Select publisher_name from paper where category_paper ='" + checkBox2.Text + "'";
            SqlCommand cmddr = new SqlCommand(sqlselectquery2, con);
            cmddr.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmddr);
            da2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["publisher_name"].ToString());
            }
            con.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string sqlselectquery2 = "Select publisher_name from paper where category_paper ='" + checkBox3.Text + "'";
            SqlCommand cmddr = new SqlCommand(sqlselectquery2, con);
            cmddr.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmddr);
            da2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["publisher_name"].ToString());
            }
            con.Close();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string sqlselectquery2 = "Select publisher_name from paper where category_paper ='" + checkBox4.Text + "'";
            SqlCommand cmddr = new SqlCommand(sqlselectquery2, con);
            cmddr.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmddr);
            da2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["publisher_name"].ToString());
            }
            con.Close();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string sqlselectquery2 = "Select publisher_name from paper where category_paper ='" + checkBox5.Text + "'";
            SqlCommand cmddr = new SqlCommand(sqlselectquery2, con);
            cmddr.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmddr);
            da2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["publisher_name"].ToString());
            }
            con.Close();

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string sqlselectquery2 = "Select publisher_name from paper where category_paper ='" + checkBox6.Text + "'";
            SqlCommand cmddr = new SqlCommand(sqlselectquery2, con);
            cmddr.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmddr);
            da2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["publisher_name"].ToString());
            }
            con.Close();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string sqlselectquery2 = "Select publisher_name from paper where category_paper ='" + checkBox7.Text + "'";
            SqlCommand cmddr = new SqlCommand(sqlselectquery2, con);
            cmddr.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmddr);
            da2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["publisher_name"].ToString());
            }
            con.Close();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            string sqlselectquery2 = "Select publisher_name from paper where category_paper ='" + checkBox8.Text + "'";
            SqlCommand cmddr = new SqlCommand(sqlselectquery2, con);
            cmddr.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmddr);
            da2.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["publisher_name"].ToString());
            }
            con.Close();
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con2.Open();
            string sqlselectquery = "Select price from paper where publisher_name ='" + comboBox1.Text + "'";
            SqlCommand cmdd = new SqlCommand(sqlselectquery, con2);
            SqlDataReader da1 = cmdd.ExecuteReader();           
            while (da1.Read())
            {
                textBox4.Text = (da1["price"].ToString());
            }
            da1.Close();
            con2.Close();
        }

 
    }
}

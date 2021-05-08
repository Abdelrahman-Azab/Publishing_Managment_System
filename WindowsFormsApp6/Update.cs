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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            if (checkBox3.Checked == true)
            {
               
                string update_query = @"update viewer Set viewer_name='" + textBox1.Text + "',viewer_password='" + textBox4.Text + "',viewer_email='" + textBox3.Text + "',viewer_mobile='" + textBox6.Text+"',viewer_gender='"+checkBox1.Text+"'where viewer_name='"+textBox7.Text+"'";
                SqlCommand comm = new SqlCommand(update_query, con);
                comm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thank you, Data Updated Succesfully");
            }
           else if (checkBox4.Checked == true)
            {

                string update_query = @"update author Set author_name='" + textBox1.Text + "',author_password='" + textBox4.Text + "',author_email='" + textBox3.Text + "',author_mobile='" + textBox6.Text + "',aurhor_gender='" + checkBox1.Text + "'where author_name='" + textBox7.Text + "'";
                SqlCommand cmd = new SqlCommand("update_query", con);
                cmd.Parameters.Add("@author_name", textBox1.Text);
                cmd.Parameters.Add("@author_password", textBox4.Text);
                cmd.Parameters.Add("@author_email", textBox3.Text);
                cmd.Parameters.Add("@author_mobile", textBox6.Text);
                cmd.Parameters.Add("@aurhor_gender", checkBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thank you, Data Updated Succesfully");
            }
            else if (checkBox5.Checked == true)
            {

                string update_query = @"update publisher Set publisher_name='" + textBox1.Text + "',publisher_password='" + textBox4.Text + "',publisher_email='" + textBox3.Text + "',publisher_mobile='" + textBox6.Text + "',publisher_gender='" + checkBox1.Text + "'where publisher_name='" + textBox7.Text + "'";
                SqlCommand comm = new SqlCommand(update_query, con);
                comm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thank you, Data Updated Succesfully");
            }
            Hide();
            Form1 f = new Form1();
            f.Show();

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

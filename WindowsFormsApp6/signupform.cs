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
    public partial class signupform : Form
    {
        public signupform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            if (checkBox4.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO author(author_name,author_password,author_email,author_mobile,aurhor_gender) VALUES(@author_name,@author_password,@author_email,@author_mobile,@aurhor_gender)", con);
                cmd.Parameters.Add("@author_name", textBox1.Text + ' ' + textBox2.Text);
                cmd.Parameters.Add("@author_password", textBox4.Text);
                cmd.Parameters.Add("@author_email", textBox3.Text);
                cmd.Parameters.Add("@author_mobile", textBox6.Text);
                if (checkBox1.Checked==true)
                {
                    cmd.Parameters.Add("@aurhor_gender",checkBox1.Text);
                }
               else if (checkBox2.Checked == true)
                {
                    cmd.Parameters.Add("@aurhor_gender", checkBox2.Text);
                }
                cmd.ExecuteNonQuery();
            }
           else if (checkBox3.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO viewer(viewer_name,viewer_password,viewer_email,viewer_mobile,viewer_gender) VALUES(@viewer_name,@viewer_password,@viewer_email,@viewer_mobile,@viewer_gender)", con);

                cmd.Parameters.Add("@viewer_name", textBox1.Text + ' ' + textBox2.Text);
                cmd.Parameters.Add("@viewer_password", textBox4.Text);
                cmd.Parameters.Add("@viewer_email", textBox3.Text);
                cmd.Parameters.Add("@viewer_mobile", textBox6.Text);
                if (checkBox1.Checked == true)
                {
                    cmd.Parameters.Add("@viewer_gender", checkBox1.Text);
                }
                else if (checkBox2.Checked == true)
                {
                    cmd.Parameters.Add("@viewer_gender", checkBox2.Text);
                }
                cmd.ExecuteNonQuery();
            }
            else if (checkBox5.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO publisher(publisher_name,publisher_password,publisher_email,publisher_mobile,publisher_gender) VALUES(@publisher_name,@publisher_password,@publisher_email,@publisher_mobile,@publisher_gender)", con);
            
                cmd.Parameters.Add("@publisher_name", textBox1.Text + ' ' + textBox2.Text);
                cmd.Parameters.Add("@publisher_password", textBox4.Text);
                cmd.Parameters.Add("@publisher_email", textBox3.Text);
                cmd.Parameters.Add("@publisher_mobile", textBox6.Text);
                if (checkBox1.Checked == true)
                {
                    cmd.Parameters.Add("@publisher_gender", checkBox1.Text);
                }
                else if (checkBox2.Checked == true)
                {
                    cmd.Parameters.Add("@publisher_gender", checkBox2.Text);
                }
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data Added Successfully!");
            Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}

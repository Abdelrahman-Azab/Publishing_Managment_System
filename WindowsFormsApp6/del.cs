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
    public partial class del : Form
    {
        public del()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            if (checkBox1.Checked==true)
            {
                string delete_query = @"delete viewer where viewer_name='" + textBox7.Text + "' ";
                SqlCommand comm = new SqlCommand(delete_query, con);
                comm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thank You ,Data Delete Sucessfully");
                Hide();
                Form1 f = new Form1();
                f.Show();

            }
            else if(checkBox4.Checked==true)
            {
                string delete_query = @"delete author where author_name='" + textBox7.Text + "' ";
                SqlCommand comm = new SqlCommand(delete_query, con);
                comm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thank You ,Data Delete Sucessfully");
                Hide();
                Form1 f = new Form1();
                f.Show();
            }
            else if(checkBox5.Checked==true)
            {
                string delete_query = @"delete publisher where publisher_name='" + textBox7.Text + "' ";
                SqlCommand comm = new SqlCommand(delete_query, con);
                comm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thank You ,Data Delete Sucessfully");
                Hide();
                Form1 f = new Form1();
                f.Show();
            }
            else if(checkBox3.Checked==true)
            {
                string delete_query = @"delete paper where name_paper='" + textBox7.Text + "' ";
                SqlCommand comm = new SqlCommand(delete_query, con);
                comm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thank You ,Data Delete Sucessfully");
                Hide();
                Form1 f = new Form1();
                f.Show();
            }
            
        }
    }
}

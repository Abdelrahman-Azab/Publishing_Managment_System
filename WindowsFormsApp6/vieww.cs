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
    public partial class vieww : Form
    {
        string sqlselectquery;
        public vieww()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            conn.Open();
         
            if (checkBox1.Checked==true)
            {
               sqlselectquery = "Select article from paper where name_paper like('"+textBox2.Text+"')";
            }
            else if(checkBox2.Checked == true)
            {
                sqlselectquery = "Select article from paper where category_paper like('" + textBox2.Text + "')";
            }
            else
            {
               sqlselectquery = "Select article from paper where publisher_name like('" + textBox2.Text + "')";
            }
            SqlCommand cmd = new SqlCommand(sqlselectquery, conn);
            SqlDataReader da = cmd.ExecuteReader();

            if (da.Read())
            {
                textBox1.Text = (da["article"].ToString());
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for Reading !!");
            Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

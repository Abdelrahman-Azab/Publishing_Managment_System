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
    public partial class loginforma : Form
    {
        public loginforma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            conn.Open();
            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "Select * from author where author_password=@author_password and author_name=@author_name and author_email=@author_email";
            cmdd.Parameters.AddWithValue("@author_password", textBox2.Text);
            cmdd.Parameters.AddWithValue("@author_name", textBox1.Text);
            cmdd.Parameters.AddWithValue("@author_email", textBox3.Text);
            cmdd.Connection = conn;
            SqlDataReader drr = cmdd.ExecuteReader();
            if (drr.HasRows)
            {
                button1.Text = "Right Password,Welcome!";
                button1.ForeColor = System.Drawing.Color.Green;
                Hide();
                author a = new author(textBox1.Text);
                a.Show();

            }
            else
            {
                button1.Text = "Sorry,Wrong!!";
                button1.ForeColor = System.Drawing.Color.Red;
            }

            drr.Close();
            conn.Close();
        }

       
    }
}

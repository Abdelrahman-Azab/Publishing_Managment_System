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
    public partial class loginformp : Form
    {
        public loginformp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from publisher where publisher_password=@publisher_password and publisher_name=@publisher_name and publisher_email=@publisher_email";
            cmd.Parameters.AddWithValue("@publisher_password", textBox2.Text);
            cmd.Parameters.AddWithValue("@publisher_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@publisher_email", textBox3.Text);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                button1.Text = "Right Password,Welcome!";
                button1.ForeColor = System.Drawing.Color.Green;
                Hide();
                publisherr p = new publisherr();
                p.Show();

            }
            else
            {
                button1.Text = "Sorry,Wrong!!";
                button1.ForeColor = System.Drawing.Color.Red;
            }
            dr.Close();
            con.Close();
        }
    }
}

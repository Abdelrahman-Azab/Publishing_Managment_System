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
    public partial class loginformv : Form
    {
        public loginformv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "Select * from viewer where viewer_password=@viewer_password and viewer_name=@viewer_name and viewer_email=@viewer_email" ;
            cmd.CommandText = "validate" ;
            cmd.Parameters.AddWithValue("@viewer_password", textBox2.Text);
            cmd.Parameters.AddWithValue("@viewer_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@viewer_email", textBox3.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                button1.Text = "Right Password,Welcome!";
                button1.ForeColor = System.Drawing.Color.Green;
                Hide();
                vieww v = new vieww();
                v.Show();

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

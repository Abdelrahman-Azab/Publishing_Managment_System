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
    public partial class loginformadm : Form
    {
        public loginformadm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IRDCSG7;Initial Catalog=Project;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from admin where admin_password=@admin_password and admin_name=@admin_name and admin_email=@admin_email";
            cmd.Parameters.AddWithValue("@admin_password", textBox2.Text);
            cmd.Parameters.AddWithValue("@admin_name", textBox1.Text);
            cmd.Parameters.AddWithValue("@admin_email", textBox3.Text);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                button1.Text = "Right Password,Welcome!";
                button1.ForeColor = System.Drawing.Color.Green;
                Hide();
                adm d = new adm();
                d.Show();

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class adm : Form
    {
        public adm()
        {
            InitializeComponent();
        }

        private void loginlabel_Click(object sender, EventArgs e)
        {
            Hide();
            signupform sup = new signupform();
            sup.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
            Update up = new Update();
            up.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            del jo = new del();
            jo.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Hide();
            seerequests se = new seerequests();
            se.Show();
        }
    }
}

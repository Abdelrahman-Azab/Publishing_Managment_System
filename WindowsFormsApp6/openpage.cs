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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            loginformv lv = new loginformv();
            lv.Show();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            loginforma la = new loginforma();
            la.Show();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            loginformp lp = new loginformp();
            lp.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Hide();
            loginformadm d = new loginformadm();
            d.Show();

        }
    }
}

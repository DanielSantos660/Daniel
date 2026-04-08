using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista1
{
    public partial class ex21 : Form
    {
        public ex21()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n, sn, nc;
            n = textBox1.Text;
            sn = textBox2.Text;

            nc = n + " " + sn;

            label5.Text = nc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            label5.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

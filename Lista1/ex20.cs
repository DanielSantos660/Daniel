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
    public partial class ex20 : Form
    {
        public ex20()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, a;
            char s;
            m = int.Parse(textBox1.Text);
            a = m / 10000;
            s = m.ToString()[2];

            label5.Text = (2000 + a).ToString();
            label4.Text = s + "º sem";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label5.Text = string.Empty;
            label4.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

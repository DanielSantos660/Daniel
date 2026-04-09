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
    public partial class ex07 : Form
    {
        public ex07()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            label10.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double t, v, d, l;
            t = double.Parse(textBox1.Text);
            v = double.Parse(textBox2.Text);

            d = t * v;
            l = d / 12;

            label10.Text = v.ToString() + "Km/h";
            label11.Text = t.ToString() + "h";
            label12.Text = d.ToString() + "Km";
            label13.Text = Math.Round(l,2).ToString() + "L";
        }
    }
}

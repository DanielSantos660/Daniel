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
    public partial class ex10 : Form
    {
        public ex10()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, l, h, v;
            l = double.Parse(textBox1.Text);
            h = double.Parse(textBox2.Text);    
            c = double.Parse(textBox3.Text);

            v = c * l * h;

            label5.Text = v.ToString() + "cm";
            label7.Text = c.ToString() + " x " + l.ToString() + " x " + h.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            label5.Text = string.Empty;
            label7.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}

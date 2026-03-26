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
    public partial class ex09 : Form
    {
        public ex09()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            d = double.Parse(textBox4.Text);

            label20.Text = a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
            label18.Text = a.ToString() + " + " + c.ToString() + " = " + (a + c).ToString();
            label17.Text = a.ToString() + " + " + d.ToString() + " = " + (a + d).ToString();
            label16.Text = b.ToString() + " + " + c.ToString() + " = " + (b + c).ToString();
            label15.Text = b.ToString() + " + " + d.ToString() + " = " + (b + d).ToString();
            label14.Text = c.ToString() + " + " + d.ToString() + " = " + (c + d).ToString();

            label4.Text = a.ToString() + " x " + b.ToString() + " = " + (a * b).ToString();
            label8.Text = a.ToString() + " x " + c.ToString() + " = " + (a * c).ToString();
            label9.Text = a.ToString() + " x " + d.ToString() + " = " + (a * d).ToString();
            label10.Text = b.ToString() + " x " + c.ToString() + " = " + (b * c).ToString();
            label11.Text = b.ToString() + " x " + d.ToString() + " = " + (b * d).ToString();
            label12.Text = c.ToString() + " x " + d.ToString() + " = " + (c * d).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            label20.Text = "A + B =";
            label18.Text = "A + C =";
            label17.Text = "A + D =";
            label16.Text = b.ToString() + " + " + c.ToString() + " = " + (b + c).ToString();
            label15.Text = b.ToString() + " + " + d.ToString() + " = " + (b + d).ToString();
            label14.Text = c.ToString() + " + " + d.ToString() + " = " + (c + d).ToString();

            label4.Text = a.ToString() + " x " + b.ToString() + " = " + (a * b).ToString();
            label8.Text = a.ToString() + " x " + c.ToString() + " = " + (a * c).ToString();
            label9.Text = a.ToString() + " x " + d.ToString() + " = " + (a * d).ToString();
            label10.Text = b.ToString() + " x " + c.ToString() + " = " + (b * c).ToString();
            label11.Text = b.ToString() + " x " + d.ToString() + " = " + (b * d).ToString();
            label12.Text = c.ToString() + " x " + d.ToString() + " = " + (c * d).ToString();
        }
    }
}

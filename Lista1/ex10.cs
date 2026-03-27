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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, l, h, v;
            c = double.Parse(textBox1.Text);
            l = double.Parse(textBox2.Text);    
            h = double.Parse(textBox3.Text);

            v = c * l * h;

            label5.Text = v.ToString() + "cm";
            label7.Text = c.ToString() + " x " + l.ToString() + " x " + h.ToString();
        }
    }
}

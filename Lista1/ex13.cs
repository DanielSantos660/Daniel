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
    public partial class ex13 : Form
    {
        public ex13()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);

            label5.Text = (n1*n1).ToString();
            label4.Text = (n2*n2).ToString();

            label8.Text = ((n1*n1)+(n2*n2)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            label5.Text = string.Empty; 
            label4.Text = string.Empty;
            label8.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
        }
    }
}

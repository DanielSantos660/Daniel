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
    public partial class ex02 : Form
    {
        public ex02()
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
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, soma;

            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            soma = n1 + n2;

            label3.Text = soma.ToString();

        }
    }
}

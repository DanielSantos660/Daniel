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
    public partial class ex17 : Form
    {
        public ex17()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
            //código totalmente estético, ele busca a imagem da pasta Resources e redimensiona, deixando em melhor qualidade
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int int1, int2;
            double div;
            int1 = int.Parse(textBox1.Text);
            int2 = int.Parse(textBox2.Text);

            div = int1 / int2;

            label3.Text = div.ToString();
            label4.Text = (int1 % int2).ToString();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = string.Empty;
            label4.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

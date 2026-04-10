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
    public partial class ex01 : Form
    {
        public ex01()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
            //código totalmente estético, ele busca a imagem da pasta Resources e redimensiona, deixando em melhor qualidade
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pi = 3.14159F, raio, area;

            raio = float.Parse(textBox1.Text);
            area = pi * (raio * raio);

            label5.Text = raio.ToString();
            label6.Text = Math.Round(area, 2).ToString() + "cm";
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label5.Text = string.Empty;
            label6.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

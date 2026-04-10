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
    public partial class ex18 : Form
    {
        public ex18()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
            //código totalmente estético, ele busca a imagem da pasta Resources e redimensiona, deixando em melhor qualidade
        }



        private void button1_Click(object sender, EventArgs e)
        {
            double salb, cont, imp, sall;
            salb = double.Parse(textBox1.Text);
            cont = (10.0 / 100.0) * salb;
            imp = (5.0 / 100.0) * (salb - cont);
            sall = salb - (cont + imp);

            label3.Text = "R$" + Math.Round(cont, 2).ToString();
            label8.Text = "R$" + Math.Round(imp, 2).ToString();
            label10.Text = "R$" + Math.Round(sall, 2).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = string.Empty;
            label8.Text = string.Empty;
            label10.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

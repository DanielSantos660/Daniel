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
    public partial class ex14 : Form
    {
        public ex14()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
            //código totalmente estético, ele busca a imagem da pasta Resources e redimensiona, deixando em melhor qualidade
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Val1, Val2, Media;
            Val1 = double.Parse(textBox1.Text);
            Val2 = double.Parse(textBox2.Text);

            Media = (Val1 + Val2) / 2;

            label5.Text = Math.Round(Media, 2).ToString();
            label9.Text = "(" + Val1.ToString() + " + " + Val2.ToString() + ") / 2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            label5.Text = string.Empty;
            label9.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

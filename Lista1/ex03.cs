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
    public partial class ex03 : Form
    {
        public ex03()
        {
            InitializeComponent();
            button2.Image = new Bitmap(Properties.Resources.icon__9_, new Size(40, 40));
            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double HT, VH, PD, SB, SL, TD;
            HT = double.Parse(textBox1.Text);
            VH = double.Parse(textBox2.Text);
            PD = double.Parse(textBox3.Text);

            SB = HT * VH;
            TD = (PD / 100) * SB;

            SL = SB - TD;

            SB = Math.Round(SB, 2);
            TD = Math.Round(TD, 2);
            SL = Math.Round(SL, 2);

            label3.Text = HT.ToString();
            label8.Text = "R$" + SB.ToString();
            label10.Text = "R$" + SL.ToString();
            label12.Text = "R$" + TD.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
            label3.Text = string.Empty;
            label8.Text = string.Empty;
            label10.Text = string.Empty;
            label12.Text = string.Empty;
        }

       
    }
}

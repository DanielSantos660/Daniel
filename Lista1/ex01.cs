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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pi = 3.14159F, raio, area;

            raio = float.Parse(textBox1.Text);
            area = pi * (2 * raio);

            label5.Text = raio.ToString();
            label6.Text = Math.Round(area,2).ToString()+"cm";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

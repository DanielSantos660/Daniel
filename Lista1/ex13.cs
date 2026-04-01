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
    }
}

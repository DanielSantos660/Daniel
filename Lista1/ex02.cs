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
            button3.BackgroundImage = null;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            button3.Image = new Bitmap(Properties.Resources.icon__8_, new Size(40, 40));
            button3.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void ex02_Load(object sender, EventArgs e)
        {

        }
    }
}

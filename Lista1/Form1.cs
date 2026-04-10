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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ex01 ex01 = new ex01(); //cria uma instância de onjeto para o ex01
            ex01.FormClosed += (s, args) => this.Show(); //Adiciona um evento para mostrar o Form1 novamente quando o ex01 for fechado
            this.Hide();
            ex01.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ex02 ex02 = new ex02(); 
            ex02.FormClosed += (s, args) => this.Show(); 
            this.Hide();
            ex02.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ex03 ex03 = new ex03(); 
            ex03.FormClosed += (s, args) => this.Show(); 
            this.Hide();
            ex03.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ex04 ex04 = new ex04();
            ex04.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex04.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ex05 ex05 = new ex05();
            ex05.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex05.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ex06 ex06 = new ex06();
            ex06.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex06.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ex07 ex07 = new ex07();
            ex07.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex07.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ex08 ex08 = new ex08();
            ex08.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex08.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ex09 ex09 = new ex09();
            ex09.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex09.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ex10 ex10 = new ex10();
            ex10.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex10.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ex11 ex11 = new ex11();
            ex11.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex11.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ex12 ex12 = new ex12();
            ex12.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex12.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ex13 ex13 = new ex13();
            ex13.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex13.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ex14 ex14 = new ex14();
            ex14.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex14.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ex15 ex15 = new ex15();
            ex15.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex15.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ex16 ex16 = new ex16();
            ex16.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex16.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ex17 ex17 = new ex17();
            ex17.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex17.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ex18 ex18 = new ex18();
            ex18.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex18.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ex19 ex19 = new ex19();
            ex19.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex19.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ex20 ex20 = new ex20();
            ex20.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex20.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ex21 ex21 = new ex21();
            ex21.FormClosed += (s, args) => this.Show();
            this.Hide();
            ex21.Show();
        }
    }
}

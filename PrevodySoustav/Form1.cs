using Prevody;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrevodySoustav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dec = int.Parse(textBox1.Text);
            label1.Text = Prevod.DecBin(dec).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bin = textBox1.Text;
            label1.Text = Prevod.BinDec(bin).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int dec = int.Parse(textBox1.Text);
            label1.Text = Prevod.DecHex(dec);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string hex = textBox1.Text;
            label1.Text = Prevod.HexDec(hex).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string bin = textBox1.Text;
            label1.Text = Prevod.BinHex(bin);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string hex = textBox1.Text;
            label1.Text = Prevod.HexBin(hex);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

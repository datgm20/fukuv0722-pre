using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuv0722_pre
{
    public partial class Form1 : Form
    {
        int vx = 0;
        int vy = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx * int.Parse(textBox1.Text);
            label1.Top += vy * int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx = -1;
            vy = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx = 1;
            vy = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 1;
        }
    }
}

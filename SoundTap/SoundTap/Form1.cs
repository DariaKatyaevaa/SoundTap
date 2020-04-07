using SoundTap.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundTap
{
    public partial class Form1 : Form
    {
        private Sintezator sintezator = new Sintezator();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(60);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(61);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(62);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(63);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(64);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(65);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(66);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(67);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(68);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(69);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(70);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(71);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sintezator.PlayNote(72);
        }
    }
}

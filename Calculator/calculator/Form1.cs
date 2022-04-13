using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double r1, r2, sum, min, mul, div;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                r1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                op = "-";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                r1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                op = "*";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                r1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                op = "/";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                r2 = double.Parse(textBox1.Text);
                switch(op)
                {
                    case "+":
                        textBox1.Text = (r1 + r2).ToString();
                        break;

                    case "-":
                        textBox1.Text = (r1 - r2).ToString();
                        break;

                    case "*":
                        textBox1.Text = (r1 * r2).ToString();
                        break;

                    case "/":
                        textBox1.Text = (r1 / r2).ToString();
                        break;
                        return;



                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
       
        private void button16_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="")
            {
                r1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                op = "+";
            }
        }
    }
}

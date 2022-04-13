using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_Number
{
    public partial class Form1 : Form
    {
        Random r;
        int computer_number;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
            r = new Random();
            computer_number = r.Next(0, 100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int user_number = Convert.ToInt32(textBox1.Text);
            if(user_number==computer_number)
            {
                label1.Text = "you win ";
                label2.Text = Convert.ToString(count);
            }
                else if (user_number>computer_number)
                {
                    label1.Text = "go down";
                count++;
                }
            else if (user_number< computer_number)
            {
                label1.Text = "go up";
                count++;
            }
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

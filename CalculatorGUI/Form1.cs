using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class Form1 : Form
    {

        string input = string.Empty;
        string num1 = string.Empty;
        string num2 = string.Empty;
        char op;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";

            input += "0";

            this.textBox1.Text += input;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            input += "1";

            this.textBox1.Text += input;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            input += "2";

            this.textBox1.Text += input;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            input += "3";

            this.textBox1.Text += input;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            input += "4";

            this.textBox1.Text += input;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            input += "5";

            this.textBox1.Text += input;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            input += "6";

            this.textBox1.Text += input;

        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            input += "7";

            this.textBox1.Text += input;

        }

        private void button8_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            input += "8";

            this.textBox1.Text += input;

        }

        private void button9_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            input += "9";

            this.textBox1.Text += input;

        }

        private void buttondot_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            input += ".";

            this.textBox1.Text += input;

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";

            this.input = string.Empty;

            this.num1 = string.Empty;

            this.num2 = string.Empty;

        }

        private void buttondiv_Click(object sender, EventArgs e)
        {

            num1 = input;

            op = '/';

            input = string.Empty;


        }

        private void buttonmult_Click(object sender, EventArgs e)
        {

            num1 = input;

            op = '*';

            input = string.Empty;

        }

        private void buttonmin_Click(object sender, EventArgs e)
        {

            num1 = input;

            op = '-';

            input = string.Empty;

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {

            num1 = input;

            op = '+';

            input = string.Empty;

        }

        private void buttonenter_Click(object sender, EventArgs e)
        {

            num2 = input;

            double num11, num22;

            double.TryParse(num1, out num11);

            double.TryParse(num2, out num22);

            if (op == '+')
            {

                result = num11 + num22;

                textBox1.Text = result.ToString();

            }

            else if (op == '-')
            {

                result = num11 - num22;

                textBox1.Text = result.ToString();

            }

            else if (op == '*')
            {

                result = num11 * num22;

                textBox1.Text = result.ToString();

            }

            else if (op == '/')
            {

                if (num22 != 0)
                {

                    result = num11 / num22;

                    textBox1.Text = result.ToString();

                } else
                {

                    textBox1.Text = "Error: Cannot divide by 0!";

                }

            }

        }
    }
}

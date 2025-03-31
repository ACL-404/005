using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005
{
    public partial class Form1: Form
    {
        private string input = string.Empty;
        private string operand1 = string.Empty;
        private string operand2 = string.Empty;
        private char operation;
        private double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = "";
            }
            TEXTB1.Text = TEXTB1.Text + "1";
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = "";
            }
            TEXTB1.Text = TEXTB1.Text + "2";
        }

        private void BT3_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = "";
            }
            TEXTB1.Text = TEXTB1.Text + "3";
        }

        private void BT4_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = "";
            }
            TEXTB1.Text = TEXTB1.Text + "4";
        }

        private void BT5_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = "";
            }
            TEXTB1.Text = TEXTB1.Text + "5";
        }
       
        private void BT6_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = "";
            }
            TEXTB1.Text = TEXTB1.Text + "6";
        }

        private void BT7_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = "";
            }
            TEXTB1.Text = TEXTB1.Text + "7";
        }

        private void BT8_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = "";
            }
            TEXTB1.Text = TEXTB1.Text + "8";
        }

        private void BT9_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = "";
            }
            TEXTB1.Text = TEXTB1.Text + "9";
        }

        private void BT0_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = ""; 
            }
                TEXTB1.Text = TEXTB1.Text + "0";
        }

        private void BTp_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = TEXTB1.Text + ".";
        }

        private void BTr_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = "";
        }

        private void BTadd_Click(object sender, EventArgs e)
        {
            operand1 = TEXTB1.Text;
            operation = '+';
            input = string.Empty;
            TEXTB1.Text = "";
        }

        private void BTMinus_Click(object sender, EventArgs e)
        {
            operand1 = TEXTB1.Text;
            operation = '-';
            input = string.Empty;
            TEXTB1.Text = "";
        }

        private void BTPlus_Click(object sender, EventArgs e)
        {
            operand1 = TEXTB1.Text;
            operation = '*';
            input = string.Empty;
            TEXTB1.Text = "";
        }

        private void BTDivide_Click(object sender, EventArgs e)
        {
            operand1 = TEXTB1.Text;
            operation = '/';
            input = string.Empty;
            TEXTB1.Text = "";
        }

        private void BTa_Click(object sender, EventArgs e)
        {
            operand2 = TEXTB1.Text;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        TEXTB1.Text = "DIV/Zero!";
                        return;
                    }
                    break;
            }
            TEXTB1.Text = result.ToString();
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }
    }
}

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
    public partial class Form1 : Form
    {
        private string input = string.Empty;
        private string operand1 = string.Empty;
        private string operand2 = string.Empty;
        private char operation;
        private double result = 0.0;
        private Stack<string> history = new Stack<string>(); 
        private Stack<string> undoHistory = new Stack<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void SaveState()
        {
            history.Push(TEXTB1.Text);
        }
        private void Add_namber(string number)
        {
            SaveState();
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = "";
            }
            TEXTB1.Text = TEXTB1.Text + number;
        }
        private void BT1_Click(object sender, EventArgs e)
        {
            Add_namber("1");
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            Add_namber("2");
        }

        private void BT3_Click(object sender, EventArgs e)
        {
            Add_namber("3");
        }

        private void BT4_Click(object sender, EventArgs e)
        {
            Add_namber("4");
        }

        private void BT5_Click(object sender, EventArgs e)
        {
            Add_namber("5");
        }

        private void BT6_Click(object sender, EventArgs e)
        {
            Add_namber("6");
        }

        private void BT7_Click(object sender, EventArgs e)
        {
            Add_namber("7");
        }

        private void BT8_Click(object sender, EventArgs e)
        {
            Add_namber("8");
        }

        private void BT9_Click(object sender, EventArgs e)
        {
            Add_namber("9");
        }

        private void BT0_Click(object sender, EventArgs e)
        {
            Add_namber("0");
        }

        private void BTp_Click(object sender, EventArgs e)
        {
            SaveState();
            TEXTB1.Text = TEXTB1.Text + ".";
        }

        private void BTr_Click(object sender, EventArgs e)
        {
            SaveState();
            TEXTB1.Text = "";
        }

        private void BTadd_Click(object sender, EventArgs e)
        {
            SaveState();
            operand1 = TEXTB1.Text;
            operation = '+';
            input = string.Empty;
            TEXTB1.Text = "";
        }

        private void BTMinus_Click(object sender, EventArgs e)
        {
            SaveState();
            operand1 = TEXTB1.Text;
            operation = '-';
            input = string.Empty;
            TEXTB1.Text = "";
        }

        private void BTPlus_Click(object sender, EventArgs e)
        {
            SaveState();
            operand1 = TEXTB1.Text;
            operation = '*';
            input = string.Empty;
            TEXTB1.Text = "";
        }

        private void BTDivide_Click(object sender, EventArgs e)
        {
            SaveState();
            operand1 = TEXTB1.Text;
            operation = '/';
            input = string.Empty;
            TEXTB1.Text = "";
        }

        private void BTa_Click(object sender, EventArgs e)
        {
            SaveState();
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

        private void BTpur_Click(object sender, EventArgs e)
        {
            SaveState();
            double num;
            if (double.TryParse(TEXTB1.Text, out num))
            {
                num = num / 100;
                TEXTB1.Text = num.ToString();
            }
        }

        private void BTback_Click(object sender, EventArgs e)
        {

            if (history.Count > 0)
            {
                undoHistory.Push(TEXTB1.Text); // 保存當前狀態到撤銷堆疊
                TEXTB1.Text = history.Pop(); // 恢復上一個狀態
            }
        }

        private void back1st_Click(object sender, EventArgs e)
        {

            if (undoHistory.Count > 0)
            {
                TEXTB1.Text = undoHistory.Pop();
            }
        }
    }
}
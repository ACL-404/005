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
        public Form1()
        {
            InitializeComponent();
        }

        private void BT1_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = TEXTB1.Text + "1";
        }

        private void BT2_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = TEXTB1.Text + "2";
        }

        private void BT3_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = TEXTB1.Text + "3";
        }

        private void BT4_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = TEXTB1.Text + "4";
        }

        private void BT5_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = TEXTB1.Text + "5";
        }

        private void BT6_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = TEXTB1.Text + "6";
        }

        private void BT7_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = TEXTB1.Text + "7";
        }

        private void BT8_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = TEXTB1.Text + "8";
        }

        private void BT9_Click(object sender, EventArgs e)
        {
            TEXTB1.Text = TEXTB1.Text + "9";
        }

        private void BT0_Click(object sender, EventArgs e)
        {
            if (TEXTB1.Text == "0")
            {
                TEXTB1.Text = ""; //這個簡單的判斷式，會預先檢查輸入文字框是不是只有一個「0」？是的話，就先清除掉裡面的數字內容
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
    }
}

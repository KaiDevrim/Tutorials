using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterCalculatorTest
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        double result = 0.0;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 1;
            this.textBox1.Text += input;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 2;
            this.textBox1.Text += input;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 3;
            this.textBox1.Text += input;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 4;
            this.textBox1.Text += input;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 5;
            this.textBox1.Text += input;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 6;
            this.textBox1.Text += input;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 7;
            this.textBox1.Text += input;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 8;
            this.textBox1.Text += input;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 9;
            this.textBox1.Text += input;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 0;
            this.textBox1.Text += input;    
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

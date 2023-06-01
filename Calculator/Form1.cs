using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox.Text = "0";
        }

        public double i;
        public double num1, num2, num3;

        private double Factorial(double n)
        {
            int res = 1;
            for (int j = 1; j <= n; j++)
            {
                res *= j;
            }
            return res;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "0";
            else
                textBox.Text += 0;
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "1";
            else
                textBox.Text += 1;
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "2";
            else
                textBox.Text += 2;
        }
        private void three_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "3";
            else
                textBox.Text += 3;
        }
        private void four_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "4";
            else
                textBox.Text += 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "5";
            else
                textBox.Text += 5;
        }
        private void six_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "6";
            else
                textBox.Text += 6;
        }
        private void seven_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "7";
            else
                textBox.Text += 7;
        }
        private void eight_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "8";
            else
                textBox.Text += 8;
        }
        private void nine_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "9";
            else
                textBox.Text += 9;
        }
        private void point_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
                textBox.Text = "0,";
            else
                textBox.Text += ",";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            i = 1;
            num1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            textBox.Focus();
        }
        private void div_Click(object sender, EventArgs e)
        {
            i = 2;
            num1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            textBox.Focus();
        }
        private void mul_Click(object sender, EventArgs e)
        {
            i = 3;
            num1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            textBox.Focus();
        }
        private void defect_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || textBox.Text == "")
                textBox.Text = "0";
            else
            {
                i = 4;
                num1 = Convert.ToDouble(textBox.Text);
                textBox.Text = "";
                textBox.Focus();
            }
        }
        private void one_div_x_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox.Text);
            num2 = 1 / num1;
            textBox.Text = num2.ToString();
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox.Text);
            num2 = Math.Sqrt(num1);
            textBox.Text = num2.ToString();
        }
        private void pow_two_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2 = Math.Pow(num1, 2);
            textBox.Text = num2.ToString();
        }
        private void pow_three_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2 = Math.Pow(num1, 3);
            textBox.Text = num2.ToString();
        }
        private void pow_x_y_Click(object sender, EventArgs e)
        {
            i = 5;
            num1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            textBox.Focus();
        }

        private void sqrt_3_Click(object sender, EventArgs e)
        {
            num1 = Double.Parse(textBox.Text);
            num2 = Math.Pow(num1, (double)1 / 3);
            textBox.Text = num2.ToString();
        }
        private void sqrt_y_Click(object sender, EventArgs e)
        {
            i = 6;
            num1 = Convert.ToDouble(textBox.Text);
            textBox.Text = "";
            textBox.Focus();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox.ReadOnly = true;
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сбToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void свернутьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void закрытьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engeneerpanel.Location = new Point(0, 80);
            engeneerpanel.Visible = true;
            
        }

        private void engeneerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engeneerpanel.Visible = false;
        }

        private void actorial_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox.Text);
            num1 = Factorial(n);
            textBox.Text = num1.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }
        private void rovno_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                num2 = Double.Parse(textBox.Text);
                num3 = num1 + num2;
                textBox.Text = num3.ToString();
            }
            if (i == 2)
            {
                num2 = Double.Parse(textBox.Text);
                num3 = num1 / num2;
                textBox.Text = num3.ToString();
            }
            if (i == 3)
            {
                num2 = Double.Parse(textBox.Text);
                num3 = num1 * num2;
                textBox.Text = num3.ToString();
            }
            if (i == 4)
            {
                num2 = Double.Parse(textBox.Text);
                num3 = num1 - num2;
                textBox.Text = num3.ToString();
            }
            if (i == 5)
            {
                num2 = Double.Parse(textBox.Text);
                num3 = Math.Pow(num1, num2);
                textBox.Text = num3.ToString();
            }
            if (i == 6)
            {
                num2 = Double.Parse(textBox.Text);
                num3 = Math.Pow(num1, (double)1 / num2);
                textBox.Text = num3.ToString();
            }
        }
    }
}

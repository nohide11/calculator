using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kal_kyliator
{
    public partial class Form1 : Form
    {
        public string D;
        public string numberFirst;
        public string numberSecond;
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void O_Click(object sender, EventArgs e)
        {
            if (n2 == true)
            {
                n2 = false;
                textBox1.Text = "0";
                textBox1.Clear();
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else textBox1.Text += B.Text;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;

            numberFirst = textBox1.Text;
            n2 = true;


        }

        private void output_Click(object sender, EventArgs e)
        {
            double dn1, dn2;
            dn1 = Convert.ToDouble(numberFirst);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
                textBox1.Text = Convert.ToString(dn1 + dn2);
            else if (D == "-")
                textBox1.Text = Convert.ToString(dn1 - dn2);
            else if (D == "X")
                textBox1.Text = Convert.ToString(dn1 * dn2);
            else if (D == "/")
                textBox1.Text = Convert.ToString(dn1 / dn2);
            n2 = true;
        }

        private void bel_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(",")) 
                textBox1.Text += ",";
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            double dn = Convert.ToDouble(textBox1.Text);
            double res = 0;

            if (D == "sqrt")
                res = Math.Sqrt(dn);
            else if (D == "X^2")
                res = Math.Pow(dn, 2);
            else if (D == "1/X")
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "Infinity";
                    n2 = true;
                }
                else
                    res = 1 / dn;
            else if (D == "+/-")
                res = -dn;

            if (textBox1.Text != "Infinity")
                textBox1.Text = Convert.ToString(res);
        }

        private void procent_Click(object sender, EventArgs e)
        {
            double dn = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Convert.ToDouble(numberFirst) * dn / 100);
        }
    }
}

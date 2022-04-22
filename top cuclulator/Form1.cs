using System;
using System.Windows.Forms;

namespace top_cuclulator
{
    public partial class Form1 : Form
    {
        public string MainText;
        public string znak;
        public Double number1;
        public Double number2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (number2 != 0)
            {
                textBox1.Clear();
                number1 = 0;
                number2 = 0;
                MainText = null;
            }
            textBox1.Text += "1";
            if (number1 != 0)
            {
                MainText += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (number2 != 0)
            {
                textBox1.Clear();
                number1 = 0;
                number2 = 0;
                MainText = null;
            }
            textBox1.Text += "2";
            if (number1 != 0)
            {
                MainText += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (number2 != 0)
            {
                textBox1.Clear();
                number1 = 0;
                number2 = 0;
                MainText = null;
            }
            textBox1.Text += "3";
            if (number1 != 0)
            {
                MainText += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (number2 != 0)
            {
                textBox1.Clear();
                number1 = 0;
                number2 = 0;
                MainText = null;
            }
            textBox1.Text += "4";
            if (number1 != 0)
            {
                MainText += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (number2 != 0)
            {
                textBox1.Clear();
                number1 = 0;
                number2 = 0;
                MainText = null;
            }
            textBox1.Text += "5";
            if (number1 != 0)
            {
                MainText += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (number2 != 0)
            {
                textBox1.Clear();
                number1 = 0;
                number2 = 0;
                MainText = null;
            }
            textBox1.Text += "6";
            if (number1 != 0)
            {
                MainText += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (number2 != 0)
            {
                textBox1.Clear();
                number1 = 0;
                number2 = 0;
                MainText = null;
            }
            textBox1.Text += "7";
            if (number1 != 0)
            {
                MainText += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (number2 != 0)
            {
                textBox1.Clear();
                number1 = 0;
                number2 = 0;
                MainText = null;
            }
            textBox1.Text += "8";
            if (number1 != 0)
            {
                MainText += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (number2 != 0)
            {
                textBox1.Clear();
                number1 = 0;
                number2 = 0;
                MainText = null;
            }
            textBox1.Text += "9";
            if (number1 != 0)
            {
                MainText += "9";
            }
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            if (number2 != 0)
            {
                textBox1.Clear();
                number1 = 0;
                number2 = 0;
                MainText = null;
            }
            textBox1.Text += "0";
            if (number1 != 0)
            {
                MainText += "0";
            }
        }
        private void delit_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "\r\n/\r\n";
                znak = "/";
            }
            catch
            {

            }
        }

        private void umnozit_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "\r\n+\r\n";
                znak = "*";
            }
            catch
            {

            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            try
            {

                number1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "\r\n-\r\n";
                znak = "-";
            }
            catch
            {

            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += "\r\n+\r\n";
                znak = "+";
            }
            catch
            { 
            
            }

        }

        private void ravno_Click(object sender, EventArgs e)
        {

            number2 = Convert.ToDouble(MainText);

            textBox1.Text += "\r\n=" + "\r\n" + Convert.ToString(pocschet());

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        public double pocschet()
        {
            double answer = 0;
            switch (znak)
            {
                case "/":
                    answer = number1 / number2;

                    break;
                case "*":
                    answer = number1 * number2;

                    break;
                case "+":
                    answer = number1 + number2;

                    break;
                case "-":
                    answer = number1 - number2;

                    break;

            }

            return answer;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            number1 = 0;
            number2 = 0;
            MainText = null;
        }


    }
}

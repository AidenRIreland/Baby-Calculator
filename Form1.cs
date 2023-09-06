using System.DirectoryServices;
using System.Security.Cryptography.X509Certificates;

namespace Baby_Calculator
{
    
    public partial class Form1 : Form
    {
        public int Operation;
        public int Int1;
        public int Int2;
        public int Box = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Box != 2) 
            {
                textBox1.Text += "1";
            }
            else
            {
                textBox2.Text += "1";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Int1 = int.Parse(textBox1.Text);
            Box = 2;
            Operation = 4;
            label1.Text = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Int1 = int.Parse(textBox1.Text);
            Box = 2;
            Operation = 1;
            label1.Text = "+";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Box != 2)
            {
                textBox1.Text += "2";
            }
            else
            {
                textBox2.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Box != 2)
            {
                textBox1.Text += "3";
            }
            else
            {
                textBox2.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Box != 2)
            {
                textBox1.Text += "4";
            }
            else
            {
                textBox2.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Box != 2)
            {
                textBox1.Text += "5";
            }
            else
            {
                textBox2.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Box != 2)
            {
                textBox1.Text += "6";
            }
            else
            {
                textBox2.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Box != 2)
            {
                textBox1.Text += "7";
            }
            else
            {
                textBox2.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Box != 2)
            {
                textBox1.Text += "8";
            }
            else
            {
                textBox2.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Box != 2)
            {
                textBox1.Text += "9";
            }
            else
            {
                textBox2.Text += "9";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Box != 2)
            {
                textBox1.Text += "0";
            }
            else
            {
                textBox2.Text += "0";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Clear all values and set everything to default
            
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label1.Text = "";
            label2.Text = "";
            Box = 0;
            Int1 = 0;
            Operation = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            int num1 = Int1;
            int num2 = int.Parse(textBox2.Text);
            label2.Text = "=";
            if ( Operation == 1)
            {
                int Result = num1 + num2;
                textBox3.Text += Result;
            }
            if (Operation == 2)
            {
                int Result = num1 - num2;
                textBox3.Text += Result;
            }
            if (Operation == 3)
            {
                int Result = num1 * num2;
                textBox3.Text += Result;
            }
            if (Operation == 4)
            {
                int Result = num1 / num2;
                textBox3.Text += Result;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Int1 = int.Parse(textBox1.Text);
            Box = 2;
            Operation = 2;
            label1.Text = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Int1 = int.Parse(textBox1.Text);
            Box = 2;
            Operation = 3;
            label1.Text = "*";
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
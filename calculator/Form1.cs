namespace calculator
{
    public partial class Form1 : Form
    {
        bool flag = false;
        char o;
        public double x = 0;
        public double y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag)
            {
               textBox1.Text = textBox1.Text + "0";
            }
            else {
                textBox3.Text = textBox3.Text + "0";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                x = Convert.ToDouble(textBox3.Text);
                flag = true;
                 o = '+';
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
             x = Convert.ToDouble(textBox3.Text);
            flag = true;
            o = '-';

        }

        private void button3_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox3.Text);
            flag = true;
            o = '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox3.Text);
            flag = true;
            o = '/';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            switch(o)
            {
                case '+':
                    textBox2.Text = (x + y).ToString();
                    break;
                case '-':
                    textBox2.Text = (x - y).ToString();
                    break;
                case '*':
                    textBox2.Text = (x * y).ToString();
                    break;
                case '/':
                    textBox2.Text = (x / y).ToString();
                    break;

            }
            MessageBox.Show("please give nada the full mark :)");
            flag = false;
            textBox1.Text = "0";
            textBox3.Text = "0";
            textBox2.Text = "0"; 
        }

        private void but1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = textBox1.Text + "1";
            }
            else
            {
                textBox3.Text = textBox3.Text + "1";
            }
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = textBox1.Text + "2";
            }
            else
            {
                textBox3.Text = textBox3.Text + "2";
            }
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = textBox1.Text + "3";
            }
            else
            {
                textBox3.Text = textBox3.Text + "3";
            }
        }

        private void but4_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = textBox1.Text + "4";
            }
            else
            {
                textBox3.Text = textBox3.Text + "4";
            }
        }

        private void but5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = textBox1.Text + "5";
            }
            else
            {
                textBox3.Text = textBox3.Text + "5";
            }
        }

        private void but6_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = textBox1.Text + "6";
            }
            else
            {
                textBox3.Text = textBox3.Text + "6";
            }
        }

        private void but7_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = textBox1.Text + "7";
            }
            else
            {
                textBox3.Text = textBox3.Text + "7";
            }
        }

        private void but8_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = textBox1.Text + "8";
            }
            else
            {
                textBox3.Text = textBox3.Text + "8";
            }
        }

        private void but9_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = textBox1.Text + "9";
            }
            else
            {
                textBox3.Text = textBox3.Text + "9";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                textBox1.Text = textBox1.Text + ".";
            }
            else
            {
                textBox3.Text = textBox3.Text + ".";
            }

        }
    }
}
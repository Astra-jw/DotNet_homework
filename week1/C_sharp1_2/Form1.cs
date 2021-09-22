using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            double a = Double.Parse(s1);
            string s3 = comboBox1.Text;
            char d = Char.Parse(s3);
            string s2 = textBox2.Text;
            double b = Double.Parse(s2);
            double c;
            switch (d)
            {
                case '+':
                    c = a + b;
                    textBox3.Text = Convert.ToString(c);
                    break;
                case '-':
                    c = a - b;
                    textBox3.Text = Convert.ToString(c);
                    break;
                case '*':
                    c = a * b;
                    textBox3.Text = Convert.ToString(c);
                    break;
                case '/':
                    if (b == 0) { MessageBox.Show("分母不能为零！"); }
                    c = a / b;
                    textBox3.Text = Convert.ToString(c);
                    break;
                default:
                    break;
            }

        }
    }
}

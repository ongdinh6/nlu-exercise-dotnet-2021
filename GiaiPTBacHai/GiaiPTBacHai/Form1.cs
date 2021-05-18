using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaiPTBacHai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private double delta(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            return delta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
            double a,b,c;
            try
            {
                a = double.Parse(this.textBoxA.Text);
                b = double.Parse(this.textBox1.Text);
                c = double.Parse(this.textBox2.Text);

                if (a == 0) throw new FormatException();
                double del = delta(a, b, c);
                if (del == 0) result.Append("Phương trình có 1 nghiệm kép là: x1=x2=" + (-b)/(2*a));
                if (del < 0) result.Append("Phương trình vô nghiệm");
                if (del > 0) result.Append("Phương trình có 2 nghiệm phân biệt x1=" + (-b + Math.Sqrt(del)) / (2 * a) + " và x2=" + (-b - Math.Sqrt(del)) / (2 * a));

                this.richTextBox1.Text = result.ToString();

            }
            catch (FormatException ex)
            {
                this.richTextBox1.Text = "Các hệ số phương trình không hợp";
                if(!ex.Equals(null))
                this.richTextBox1.Text = ex.Message;

            }

            
               
            
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

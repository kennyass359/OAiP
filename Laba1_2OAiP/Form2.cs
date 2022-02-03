using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba1_2OAiP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)// +
        {
            label4.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)//-
        {
            label4.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)//*
        {
            label4.Text = "*";
        }

        private void button4_Click(object sender, EventArgs e)// /
        {
            label4.Text = "/";
        }

        private void button5_Click(object sender, EventArgs e)// %
        {
            label4.Text = "%";
        }

        private void button6_Click(object sender, EventArgs e)// вычисление
        {
            if (label4.Text == null)
            {
                MessageBox.Show("Выберите действие для исполнения", "Ошибка");
            }
            else
            {
                if (label4.Text == "+")
                {
                    MessageBox.Show($"{Convert.ToInt32(textBox1.Text)}+{Convert.ToInt32(textBox2.Text)}={Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)}", "Результат");
                }
                else if (label4.Text == "-")
                {
                    MessageBox.Show($"{Convert.ToInt32(textBox1.Text)}-{Convert.ToInt32(textBox2.Text)}={Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)}", "Результат");
                }
                else if (label4.Text == "*")
                {
                    MessageBox.Show($"{Convert.ToInt32(textBox1.Text)}*{Convert.ToInt32(textBox2.Text)}={Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)}", "Результат");
                }
                else if (label4.Text == "/")
                {
                    MessageBox.Show($"{Convert.ToInt32(textBox1.Text)}/{Convert.ToInt32(textBox2.Text)}={Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)}", "Результат");
                }
                else if (label4.Text == "%")
                {
                    MessageBox.Show($"{Convert.ToInt32(textBox1.Text)}%{Convert.ToInt32(textBox2.Text)}={Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text)}", "Результат");
                }
            }
        }
    }
}

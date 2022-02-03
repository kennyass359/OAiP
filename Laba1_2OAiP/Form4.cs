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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked == false) && (radioButton2.Checked == false))
            {
                MessageBox.Show("Выберите, что вычислять", "Ошибка");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    MessageBox.Show($"Наименьшее количество спасательных шлюпок должно быть: {Math.Ceiling(775/Convert.ToDouble(textBox1.Text))}", "Результат");
                }
                else
                {
                    MessageBox.Show($"На 20 спасательных шлюпках поместятся: {(((20 * Convert.ToInt32(textBox1.Text))<750) ? Convert.ToString(20 * Convert.ToInt32(textBox1.Text)) : "750")}", "Результат");
                }
            }
        }
    }
}

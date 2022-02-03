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
    public partial class Form3 : Form
    {
        double radian;
        string message;
        public Form3()
        {
            InitializeComponent();
        }

        double degree_to_radian(double degree) => Math.PI * degree / 180.0;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false))
            {
                MessageBox.Show("Выберите, то что необходимо вычислить", "Ошибка");
            }
            else
            {   if (radioButton1.Checked)
                {
                    radian = degree_to_radian(Convert.ToDouble(textBox1.Text));
                }
                else
                {
                    radian = Convert.ToDouble(textBox1.Text);
                }
                if (checkBox1.Checked)
                {
                    message += $"\nСинус угла равен: {Math.Sin(radian)}";
                }
                if (checkBox2.Checked)
                {
                    message += $"\nКосинус угла равен: {Math.Cos(radian)}";
                }
                if (checkBox3.Checked)
                {
                    message += $"\nТангенс уга равен: {Math.Tan(radian)}";
                }
                if (checkBox4.Checked)
                {
                    message += $"\nКотангенс равен: {1.0 / Math.Tan(radian)}";
                }
                MessageBox.Show(message, "Результат");
                message = null;
            }
        }
    }
}

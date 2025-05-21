using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Цих
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a, b, c;
            bool rez1 = int.TryParse(textBox1.Text, out a);
            if (rez1 == false) // если возникла ли ошибка преобразования
            {
                MessageBox.Show("Неверный формат числа " + textBox1.Text + "!");
                return; // заканчиваем работу метода
            }
            bool rez2 = int.TryParse(textBox2.Text, out b);
            if (rez2 == false) // если возникла ли ошибка преобразования
            { 
                MessageBox.Show("Неверный формат числа " + textBox2.Text + "!");
                return;
            }
            c = (a * 5 - b * 3) * 2;
            label6.Text = c.ToString();
            return;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

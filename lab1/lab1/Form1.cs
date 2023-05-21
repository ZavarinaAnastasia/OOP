using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "3,4"; // Начальное значение X
            textBox2.Text = "0,74"; // Начальное значение Y
            textBox3.Text = "19,43";// Начальное значение Z
                                    // Вывод строки в многострочный редактор
            textBox4.Text = "Лаб. раб. N1. Ст. гр. 22-ИБ418 Завариной А.А.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения X
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox4.Text += Environment.NewLine +
            "X = " + x.ToString();
            // Считывание значения Y
            double y = double.Parse(textBox2.Text);
            // Вывод значения Y в окно
            textBox4.Text += Environment.NewLine +
            "Y = " + y.ToString();
            // Считывание значения Z
            double z = double.Parse(textBox3.Text);
            // Вывод значения Z в окно
            textBox4.Text += Environment.NewLine +
            "Z = " + z.ToString();
            // Вычисляем арифметическое выражение
            double a = Math.Tan(x + y) * Math.Tan(x + y);
            double b = Math.Exp(y - z);
            double c = Math.Sqrt(Math.Cos(x * x) +
           Math.Sin(z * z));
            double u = a - b * c;
            // Выводим результат в окно
            textBox4.Text += Environment.NewLine + "Результат U = " + u.ToString();
        }
    }
}

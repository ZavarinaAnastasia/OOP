using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1"; // Начальное значение X0
            textBox2.Text = "4"; // Начальное значение Xk
            textBox3.Text = "0,2";// Начальное значение Dx
            textBox5.Text = "0,75";// Начальное значение A
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox5.Text);

            textBox4.Text = "Лаб. раб. N3. Ст. гр. 22-ИБ418 Заварина А.А." + Environment.NewLine;
            for (double i = x0; i <= xk; i += dx)
            {
                double y = a * Math.Log(i);
                textBox4.Text += "x = " + Convert.ToString(i) + "; y = " + Convert.ToString(y) + Environment.NewLine;
            }
        }
    }
}

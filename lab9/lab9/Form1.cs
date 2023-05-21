using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image.Save(saveFileDialog1.FileName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = textBox1.Text;
            QRCodeEncoder coder = new QRCodeEncoder();
            //Bitmap qrcode = coder.Encode(textBox1.Text);
            Bitmap qrcode = coder.Encode(txt, Encoding.UTF8);
            pictureBox1.Image = qrcode as Image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap decImg = new Bitmap(pictureBox1.Image);
                QRCodeBitmapImage qrImg = new QRCodeBitmapImage(decImg);
                QRCodeDecoder decoder = new QRCodeDecoder();
                //decoder.decode(qrImg);
                textBox2.Text = decoder.Decode(qrImg, Encoding.UTF8);
            }
            catch (Exception err)
            {
                MessageBox.Show(
                "нет распознаваемого образа, ошибка - \n\r" + err);
            }
        }
    }
}
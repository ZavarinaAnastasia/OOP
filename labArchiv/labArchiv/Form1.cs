using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;

namespace labArchiv
{
    public partial class Form1 : Form
    {
        FolderBrowserDialog bd = new FolderBrowserDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = bd.SelectedPath;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Zip files (*.zip)|*.zip";
            if (textBox1.Text != "" && sfd.ShowDialog() == DialogResult.OK)
            {
                ZipFile zf = new ZipFile(sfd.FileName);
                zf.AddDirectory(bd.SelectedPath);
                zf.Save();
                MessageBox.Show("Архивация прошла успешно.", "Выполнено");
            }
        }
    }
}

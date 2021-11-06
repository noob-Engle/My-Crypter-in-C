using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace exe_to_base64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog B1 = new OpenFileDialog();
            B1.ShowDialog();
            textBox1.Text = B1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String B2 = Convert.ToBase64String(File.ReadAllBytes(textBox1.Text));
            textBox2.Text = B2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("no text copy", "Ereer");
            }
            else {
                Clipboard.SetText(textBox2.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.baidu.com");
        }
    }
}

using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAINPROJECT
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CenterTextBox();
        }
        private void CenterTextBox()
        {
            int x = (Width - textBox1.Width) / 2+50;
            int y = (Height - textBox1.Height) / 2;
            label1.Location = new Point(x-(label1.Width/2), y - textBox1.Height-20);
            label2.Location = new System.Drawing.Point(x - label2.Width, y);
            textBox1.Location = new System.Drawing.Point(x, y);
            label3.Location = new Point(x - label3.Width, y - textBox2.Height + 60);
            textBox2.Location = new System.Drawing.Point(x , y-textBox2.Height+60);
            button1.Location = new System.Drawing.Point(x - (button1.Width / 2), y + 100);
        }

        private void Form4_Resize(object sender, EventArgs e)
        {
            CenterTextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text != "" && textBox1.Text == textBox2.Text)
            {
                Properties.Settings.Default.Password = textBox2.Text;
                Properties.Settings.Default.Save();
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
            }
            else if(textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Введите пароль");
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}

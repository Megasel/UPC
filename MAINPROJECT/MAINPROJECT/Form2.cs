using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAINPROJECT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panel1.Visible = false;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CenterTextBox();
        }
        private void CenterTextBox()
        {
            // Рассчитываем положение TextBox
            int x = (Width - textBox1.Width) / 2;
            int y = (Height - textBox1.Height) / 2;
            label1.Location = new System.Drawing.Point(x - label1.Width, y);
            // Устанавливаем положение TextBox
            textBox1.Location = new System.Drawing.Point(x, y);
            //окно нового пароля
            x = (Width - textBox3.Width) / 2 - 100;
            y = (Height - textBox3.Height) / 2;
            label3.Location = new Point(x, y);
            textBox3.Location = new Point(x + label3.Width+10, y);
            x = (Width - textBox2.Width) / 2 - 100;
            y = (Height - textBox2.Height) / 2;
            label2.Location = new Point(x, y-label3.Height-30);            
            textBox2.Location = new Point(x + label3.Width+10 , y - label3.Height - 30);
            button3.Location = new Point((Width - button3.Width)/2,((Height - button3.Height)+150)/2);
        }
        private void Form2_Resize(object sender, EventArgs e)
        {
            CenterTextBox();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text != null)
            {
                if (textBox1.Text == Properties.Settings.Default.Password)
                {
                    
                    Hide();
                    Form1 frm1 = new Form1();
                    frm1.Show();
                }
                else
                {
                    Console.WriteLine(Properties.Settings.Default.Password);
                    MessageBox.Show("Неверный пароль");
                    textBox1.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == Properties.Settings.Default.Password)
            {
                Properties.Settings.Default.Password = textBox3.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Пароль изменен");
            }
            else
            {
                MessageBox.Show("Неверный старый пароль");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == Properties.Settings.Default.Password)
            {
                Form frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("key");
            if (panel1.Visible == true && e.KeyCode == Keys.Escape)
            {
                panel1.Visible = false;
            }
            if (panel1.Visible == false && e.KeyCode == Keys.Enter)
            {
                button4.Click += button4_Click;
            }
        }

        
    }
}

using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAINPROJECT
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void CenterTextBox()
        {
            // Рассчитываем положение TextBox
            int x = (Width - textBox1.Width) / 2;
            int y = (Height - textBox1.Height) / 2;
            x -= 60;
            label1.Location = new Point(x, y-textBox1.Height);
            label2.Location = new System.Drawing.Point(x - label2.Width, y);
            textBox1.Location = new System.Drawing.Point(x, y);
            label3.Location = new Point(x + textBox1.Width, y);
            textBox2.Location = new System.Drawing.Point(x + (label3.Width+16) + textBox2.Width, y);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CenterTextBox();
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            CenterTextBox();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            if (form1 != null)
            {
                form1.idStart = int.Parse(textBox1.Text);
                form1.idEnd = int.Parse(textBox2.Text);
            }            
            this.Close();
            form1.Export();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e) { }
        
            
        
        
    }
}

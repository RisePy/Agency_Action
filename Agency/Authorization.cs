using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agency
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "a" && textBox2.Text == "a")
            {
                User user = new User();
                user.Show();
                this.Hide();
            }
            else if(textBox1.Text == "t" && textBox2.Text == "t")
            {
                Tour tour = new Tour();
                tour.Show();
                this.Hide();
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Одно или несколько полей не заполнены! Попробуйте ещё раз!", "Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Указаные не верные данные! Попробуйте ещё раз!","Ошибка авторизации!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

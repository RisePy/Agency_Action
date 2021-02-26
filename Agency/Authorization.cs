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
            if(textBox1.Text == "t" && textBox2.Text == "t")
            {
                Tour tour = new Tour();
                tour.Show();
                this.Hide();
            }
        }
    }
}

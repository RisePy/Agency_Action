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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void authorizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization autho = new Authorization();
            autho.Show();
            this.Hide();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.userDB);

        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "companyDB.Company". При необходимости она может быть перемещена или удалена.
            this.companyTableAdapter.Fill(this.companyDB.Company);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "userDB.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.userDB.Users);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.companyBindingSource.AddNew();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.usersBindingSource.AddNew();
        }
    }
}

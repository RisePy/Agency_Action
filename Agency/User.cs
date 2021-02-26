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

        private void button7_Click(object sender, EventArgs e) // Создание новой строки в таблице Company
        {
            this.companyBindingSource.AddNew();
        }

        private void button8_Click(object sender, EventArgs e) // Создание новой строки в таблице Users
        {
            this.usersBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e) // Добавление данных в таблицу Users
        {
            if (имяMaskedTextBox.Text == "" || фамилияMaskedTextBox.Text == "" || дата_рожденияDateTimePicker.Text == "")
            {
                this.Validate();
                this.usersBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.userDB);
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.userDB);
            }
        }

        private void button2_Click(object sender, EventArgs e) // Изменение данных в таблице Users
        {
            if (имяMaskedTextBox.Text == "" || фамилияMaskedTextBox.Text == "" || дата_рожденияDateTimePicker.Text == "")
            {
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.usersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.userDB);
            }
        }

        private void button3_Click(object sender, EventArgs e) // Удаление данных в таблице Users
        {
            this.Validate();
            this.usersBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.userDB);
        }

        private void button4_Click(object sender, EventArgs e) // Добавление данных в таблицу Company
        {
            if(название_компанииTextBox.Text == "" || адресTextBox.Text == "" || телефонMaskedTextBox.Text == "")
            {
                this.Validate();
                this.companyBindingSource.RemoveCurrent();
                this.tableAdapterManager1.UpdateAll(this.companyDB);
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.companyBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.companyDB);
            }
        }

        private void button5_Click(object sender, EventArgs e) // Изменение данных в таблице Company
        {
            if (название_компанииTextBox.Text == "" || адресTextBox.Text == "" || телефонMaskedTextBox.Text == "")
            {
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.companyBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.companyDB);
            }
        }

        private void button6_Click(object sender, EventArgs e) // Удаление данных в таблице Company
        {
            this.Validate();
            this.companyBindingSource.RemoveCurrent();
            this.tableAdapterManager1.UpdateAll(this.companyDB);
        }
    }
}

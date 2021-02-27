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
    public partial class Tour : Form
    {
        public Tour()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization autho = new Authorization();
            autho.Show();
            this.Hide();
        }

        private void tour_infoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tour_infoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tour_infoDB);

        }

        private void Tour_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "costDB.Cost". При необходимости она может быть перемещена или удалена.
            this.costTableAdapter.Fill(this.costDB.Cost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Price_listDB._Price_list". При необходимости она может быть перемещена или удалена.
            this.price_listTableAdapter.Fill(this._Price_listDB._Price_list);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDB.Hotel". При необходимости она может быть перемещена или удалена.
            this.hotelTableAdapter.Fill(this.hotelDB.Hotel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDB.Hotel". При необходимости она может быть перемещена или удалена.
            this.hotelTableAdapter.Fill(this.hotelDB.Hotel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "locationDB.Location". При необходимости она может быть перемещена или удалена.
            this.locationTableAdapter.Fill(this.locationDB.Location);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "travel_package._Travel_package". При необходимости она может быть перемещена или удалена.
            this.travel_packageTableAdapter.Fill(this.travel_package.Travel_package);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tour_infoDB.Tour_info". При необходимости она может быть перемещена или удалена.
            this.tour_infoTableAdapter.Fill(this.tour_infoDB.Tour_info);

        }

        private void button4_Click(object sender, EventArgs e) // Добавить данные в таблицу Tour info
        {
            
            if (название_тураTextBox.Text == "" || ценаMaskedTextBox.Text == "" || доступность_тураComboBox.Text == "")
            {
                this.Validate();
                this.tour_infoBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.tour_infoDB);
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.Validate();
                this.tour_infoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tour_infoDB);
            }
        }
        private void button5_Click(object sender, EventArgs e) // Изменить данные в таблице Tour info
        {
            
            if (название_тураTextBox.Text == "" || ценаMaskedTextBox.Text == "" || доступность_тураComboBox.Text == "")
            {
                
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.tour_infoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tour_infoDB);
            }
        }
        private void button6_Click(object sender, EventArgs e) // Удалить данные в таблице Tour info
        {
            this.Validate();
            this.tour_infoBindingSource.RemoveCurrent();
            this.tableAdapterManager.UpdateAll(this.tour_infoDB);
        }

        private void button1_Click(object sender, EventArgs e) // Добавить данные в таблицу Travel package
        {
            
            if (продолжительностьMaskedTextBox.Text == "" || типMaskedTextBox.Text == "" || транспортMaskedTextBox.Text == "" || точка_отправленияMaskedTextBox.Text == "")
            {
                this.Validate();
                this.travel_packageBindingSource.RemoveCurrent();
                this.tableAdapterManager1.UpdateAll(this.travel_package);
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.travel_packageBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.travel_package);
            }
            
        }
        private void button2_Click(object sender, EventArgs e) // Изменить данные в Travel package
        {
            if (продолжительностьMaskedTextBox.Text == "" || типMaskedTextBox.Text == "" || транспортMaskedTextBox.Text == "" || точка_отправленияMaskedTextBox.Text == "")
            {

                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.travel_packageBindingSource.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.travel_package);
            }
        }
        private void button3_Click(object sender, EventArgs e) // Удалить данные из таблицы Travle package
        {
            this.Validate();
            this.locationBindingSource.RemoveCurrent();
            this.tableAdapterManager2.UpdateAll(this.locationDB);
        }

        private void button7_Click(object sender, EventArgs e) // Добавить данные в таблицу Location
        {
            
            if(название_тураTextBox1.Text == "" || странаTextBox.Text == "" || городTextBox.Text == "")
            {
                this.Validate();
                this.locationBindingSource.RemoveCurrent();
                this.tableAdapterManager2.UpdateAll(this.locationDB);
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.locationBindingSource.EndEdit();
                this.tableAdapterManager2.UpdateAll(this.locationDB);
            }

        }
        private void button8_Click(object sender, EventArgs e) // Изменить данные из Location
        {
            if(название_тураTextBox1.Text == "" || странаTextBox.Text == "" || городTextBox.Text == "")
            {
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.locationBindingSource.EndEdit();
                this.tableAdapterManager2.UpdateAll(this.locationDB);
            }
        }
        private void button9_Click(object sender, EventArgs e) // Удалить данные из таблицы Location
        {
            this.Validate();
            this.locationBindingSource.RemoveCurrent();
            this.tableAdapterManager2.UpdateAll(this.locationDB);
        }

        private void button12_Click(object sender, EventArgs e) // Добавить данные в таблицу Hotel
        {
            
            if(название_тураTextBox.Text == "" || ценаMaskedTextBox.Text == "" || доступность_тураComboBox.Text == "")
            {
                this.Validate();
                this.hotelBindingSource.RemoveCurrent();
                this.tableAdapterManager3.UpdateAll(this.hotelDB);
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.hotelBindingSource.EndEdit();
                this.tableAdapterManager3.UpdateAll(this.hotelDB);
            }
        }
        private void button11_Click(object sender, EventArgs e) // Изменить данные из таблицы Hotel
        {
            if (название_тураTextBox.Text == "" || ценаMaskedTextBox.Text == "" || доступность_тураComboBox.Text == "")
            {
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.hotelBindingSource.EndEdit();
                this.tableAdapterManager3.UpdateAll(this.hotelDB);
            }
        }
        private void button10_Click(object sender, EventArgs e) // Удалить данные из таблицы Hotel
        {
            this.Validate();
            this.hotelBindingSource.RemoveCurrent();
            this.tableAdapterManager3.UpdateAll(this.hotelDB);
        }

        private void button15_Click(object sender, EventArgs e) // Добавить данные в таблицу Price-list
        {
            
            if (название_прайс_листаTextBox.Text == "" || название_тураTextBox2.Text == "" || услугиTextBox.Text == "")
            {
                this.Validate();
                this.price_listBindingSource.RemoveCurrent();
                this.tableAdapterManager4.UpdateAll(this._Price_listDB);
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.price_listBindingSource.EndEdit();
                this.tableAdapterManager4.UpdateAll(this._Price_listDB);
            }
        }
        private void button14_Click(object sender, EventArgs e) // Изменить данные из таблицы Price-list
        {
            if (название_прайс_листаTextBox.Text == "" || название_тураTextBox2.Text == "" || услугиTextBox.Text == "")
            {
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.price_listBindingSource.EndEdit();
                this.tableAdapterManager4.UpdateAll(this._Price_listDB);
            }
        }
        private void button13_Click(object sender, EventArgs e) // Удалить данные из таблицы Price-list
        {
            this.Validate();
            this.price_listBindingSource.RemoveCurrent();
            this.tableAdapterManager4.UpdateAll(this._Price_listDB);
        }

        private void button18_Click(object sender, EventArgs e) // Добавить данные в таблицу Cost
        {
            this.Validate();
            this.costBindingSource.EndEdit();
            this.tableAdapterManager5.UpdateAll(this.costDB);
            if (название_прайс_листаTextBox1.Text == "" || дата_отправления_клиентаDateTimePicker.Text == "")
            {
                this.Validate();
                this.costBindingSource.RemoveCurrent();
                this.tableAdapterManager5.UpdateAll(this.costDB);
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.costBindingSource.EndEdit();
                this.tableAdapterManager5.UpdateAll(this.costDB);
            }
        }
        private void button17_Click(object sender, EventArgs e) // Изменить данные из таблицы Cost
        {
            if (название_прайс_листаTextBox1.Text == "" || дата_отправления_клиентаDateTimePicker.Text == "")
            {
                MessageBox.Show("Одно или несколько значений не указаны!", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Validate();
                this.costBindingSource.EndEdit();
                this.tableAdapterManager5.UpdateAll(this.costDB);
            }
        }
        private void button16_Click(object sender, EventArgs e) // Удалить данные из таблицы Cost
        {
            this.Validate();
            this.costBindingSource.RemoveCurrent();
            this.tableAdapterManager5.UpdateAll(this.costDB);
        }



        private void button19_Click(object sender, EventArgs e) // добавить строку в таблице Tour info
        {
            this.tour_infoBindingSource.AddNew();
        }

        private void button20_Click(object sender, EventArgs e) // добавить строку в таблице Travel package
        {
            this.travel_packageBindingSource.AddNew(); 
        }

        private void button21_Click(object sender, EventArgs e) // добавить строку в таблице Location
        {
            this.locationBindingSource.AddNew();
        }

        private void button22_Click(object sender, EventArgs e) // добавить строку в таблице Hotel
        {
            this.hotelBindingSource.AddNew();
        }

        private void button23_Click(object sender, EventArgs e) // добавить строку в таблице Price-list
        {
            this.price_listBindingSource.AddNew();
        }

        private void button24_Click(object sender, EventArgs e) // добавить строку в таблице Cost
        {
            this.costBindingSource.AddNew();
        }


        
    }
}

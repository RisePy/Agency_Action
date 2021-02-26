
namespace Agency
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label название_компанииLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label телефонLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDB = new Agency.UserDB();
            this.имяMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.фамилияMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.название_компанииTextBox = new System.Windows.Forms.TextBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyDB = new Agency.CompanyDB();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.телефонMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.companyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.usersTableAdapter = new Agency.UserDBTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Agency.UserDBTableAdapters.TableAdapterManager();
            this.companyTableAdapter = new Agency.CompanyDBTableAdapters.CompanyTableAdapter();
            this.tableAdapterManager1 = new Agency.CompanyDBTableAdapters.TableAdapterManager();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            название_компанииLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            idLabel.Location = new System.Drawing.Point(7, 313);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 19);
            idLabel.TabIndex = 16;
            idLabel.Text = "id:";
            // 
            // имяLabel
            // 
            имяLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            имяLabel.AutoSize = true;
            имяLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            имяLabel.Location = new System.Drawing.Point(7, 354);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(40, 19);
            имяLabel.TabIndex = 18;
            имяLabel.Text = "Имя:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            фамилияLabel.AutoSize = true;
            фамилияLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            фамилияLabel.Location = new System.Drawing.Point(7, 398);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(75, 19);
            фамилияLabel.TabIndex = 20;
            фамилияLabel.Text = "Фамилия:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            дата_рожденияLabel.Location = new System.Drawing.Point(8, 446);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(115, 19);
            дата_рожденияLabel.TabIndex = 22;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // название_компанииLabel
            // 
            название_компанииLabel.AutoSize = true;
            название_компанииLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            название_компанииLabel.Location = new System.Drawing.Point(3, 24);
            название_компанииLabel.Name = "название_компанииLabel";
            название_компанииLabel.Size = new System.Drawing.Size(147, 19);
            название_компанииLabel.TabIndex = 9;
            название_компанииLabel.Text = "Название компании:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            адресLabel.Location = new System.Drawing.Point(5, 79);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(53, 19);
            адресLabel.TabIndex = 11;
            адресLabel.Text = "Адрес:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            телефонLabel.Location = new System.Drawing.Point(5, 128);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(68, 19);
            телефонLabel.TabIndex = 13;
            телефонLabel.Text = "Телефон:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(385, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button2.Location = new System.Drawing.Point(472, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button3.Location = new System.Drawing.Point(561, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorizationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // authorizationToolStripMenuItem
            // 
            this.authorizationToolStripMenuItem.Name = "authorizationToolStripMenuItem";
            this.authorizationToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.authorizationToolStripMenuItem.Text = "Authorization";
            this.authorizationToolStripMenuItem.Click += new System.EventHandler(this.authorizationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(678, 543);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(idLabel);
            this.tabPage1.Controls.Add(this.idTextBox);
            this.tabPage1.Controls.Add(имяLabel);
            this.tabPage1.Controls.Add(this.имяMaskedTextBox);
            this.tabPage1.Controls.Add(фамилияLabel);
            this.tabPage1.Controls.Add(this.фамилияMaskedTextBox);
            this.tabPage1.Controls.Add(дата_рожденияLabel);
            this.tabPage1.Controls.Add(this.дата_рожденияDateTimePicker);
            this.tabPage1.Controls.Add(this.usersDataGridView);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(670, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "id", true));
            this.idTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.idTextBox.Location = new System.Drawing.Point(102, 310);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 26);
            this.idTextBox.TabIndex = 17;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.userDB;
            // 
            // userDB
            // 
            this.userDB.DataSetName = "UserDB";
            this.userDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // имяMaskedTextBox
            // 
            this.имяMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.имяMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Имя", true));
            this.имяMaskedTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.имяMaskedTextBox.Location = new System.Drawing.Point(102, 351);
            this.имяMaskedTextBox.Name = "имяMaskedTextBox";
            this.имяMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.имяMaskedTextBox.TabIndex = 19;
            // 
            // фамилияMaskedTextBox
            // 
            this.фамилияMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.фамилияMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Фамилия", true));
            this.фамилияMaskedTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.фамилияMaskedTextBox.Location = new System.Drawing.Point(102, 395);
            this.фамилияMaskedTextBox.Name = "фамилияMaskedTextBox";
            this.фамилияMaskedTextBox.Size = new System.Drawing.Size(200, 26);
            this.фамилияMaskedTextBox.TabIndex = 21;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(129, 440);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.дата_рожденияDateTimePicker.TabIndex = 23;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(6, 6);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(658, 298);
            this.usersDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(название_компанииLabel);
            this.tabPage2.Controls.Add(this.название_компанииTextBox);
            this.tabPage2.Controls.Add(адресLabel);
            this.tabPage2.Controls.Add(this.адресTextBox);
            this.tabPage2.Controls.Add(телефонLabel);
            this.tabPage2.Controls.Add(this.телефонMaskedTextBox);
            this.tabPage2.Controls.Add(this.companyDataGridView);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(670, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Company";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // название_компанииTextBox
            // 
            this.название_компанииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Название компании", true));
            this.название_компанииTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.название_компанииTextBox.Location = new System.Drawing.Point(156, 21);
            this.название_компанииTextBox.Name = "название_компанииTextBox";
            this.название_компанииTextBox.Size = new System.Drawing.Size(100, 26);
            this.название_компанииTextBox.TabIndex = 10;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "Company";
            this.companyBindingSource.DataSource = this.companyDB;
            // 
            // companyDB
            // 
            this.companyDB.DataSetName = "CompanyDB";
            this.companyDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Адрес", true));
            this.адресTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.адресTextBox.Location = new System.Drawing.Point(91, 76);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(136, 26);
            this.адресTextBox.TabIndex = 12;
            // 
            // телефонMaskedTextBox
            // 
            this.телефонMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Телефон", true));
            this.телефонMaskedTextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.телефонMaskedTextBox.Location = new System.Drawing.Point(91, 125);
            this.телефонMaskedTextBox.Name = "телефонMaskedTextBox";
            this.телефонMaskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.телефонMaskedTextBox.TabIndex = 14;
            // 
            // companyDataGridView
            // 
            this.companyDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyDataGridView.AutoGenerateColumns = false;
            this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.companyDataGridView.DataSource = this.companyBindingSource;
            this.companyDataGridView.Location = new System.Drawing.Point(314, 3);
            this.companyDataGridView.Name = "companyDataGridView";
            this.companyDataGridView.Size = new System.Drawing.Size(350, 508);
            this.companyDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Название компании";
            this.dataGridViewTextBoxColumn5.HeaderText = "Название компании";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn7.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button6.Location = new System.Drawing.Point(41, 348);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 34);
            this.button6.TabIndex = 8;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button5.Location = new System.Drawing.Point(41, 304);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 34);
            this.button5.TabIndex = 7;
            this.button5.Text = "Изменить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button4.Location = new System.Drawing.Point(41, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Agency.UserDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CompanyTableAdapter = this.companyTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Agency.CompanyDBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(268, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 37);
            this.button7.TabIndex = 15;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(624, 257);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 37);
            this.button8.TabIndex = 24;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 569);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(697, 585);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private UserDB userDB;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UserDBTableAdapters.UsersTableAdapter usersTableAdapter;
        private UserDBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.MaskedTextBox имяMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox фамилияMaskedTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private CompanyDB companyDB;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private CompanyDBTableAdapters.CompanyTableAdapter companyTableAdapter;
        private CompanyDBTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox название_компанииTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.MaskedTextBox телефонMaskedTextBox;
        private System.Windows.Forms.DataGridView companyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}
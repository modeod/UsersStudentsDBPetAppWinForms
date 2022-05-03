namespace UsersStudentsDBForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telegramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.universityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.townDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuUpdateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.buttonСlear = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.radioButtonSearch = new System.Windows.Forms.RadioButton();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelFlat = new System.Windows.Forms.Label();
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.labelHouse = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelTown = new System.Windows.Forms.Label();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelCounty = new System.Windows.Forms.Label();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxTown = new System.Windows.Forms.TextBox();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.textBoxUniversity = new System.Windows.Forms.TextBox();
            this.labelUniversity = new System.Windows.Forms.Label();
            this.labelTelegram = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxCounty = new System.Windows.Forms.TextBox();
            this.textBoxTelegram = new System.Windows.Forms.TextBox();
            this.labelForm = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.contextMenuData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).BeginInit();
            this.SearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.видToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(994, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.импортToolStripMenuItem,
            this.экспортToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.импортToolStripMenuItem.Text = "Импорт";
            // 
            // экспортToolStripMenuItem
            // 
            this.экспортToolStripMenuItem.Name = "экспортToolStripMenuItem";
            this.экспортToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.экспортToolStripMenuItem.Text = "Экспорт";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.таблицаToolStripMenuItem.Text = "Таблица";
            // 
            // DataView
            // 
            this.DataView.AllowUserToAddRows = false;
            this.DataView.AllowUserToDeleteRows = false;
            this.DataView.AllowUserToOrderColumns = true;
            this.DataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataView.AutoGenerateColumns = false;
            this.DataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DataView.ColumnHeadersHeight = 29;
            this.DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.telegramDataGridViewTextBoxColumn,
            this.universityDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.townDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.flatDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.DataView.ContextMenuStrip = this.contextMenuData;
            this.DataView.DataSource = this.userModelBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "Ничего";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataView.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataView.Location = new System.Drawing.Point(0, 28);
            this.DataView.Margin = new System.Windows.Forms.Padding(0);
            this.DataView.MinimumSize = new System.Drawing.Size(400, 110);
            this.DataView.MultiSelect = false;
            this.DataView.Name = "DataView";
            this.DataView.ReadOnly = true;
            this.DataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataView.RowTemplate.Height = 29;
            this.DataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataView.ShowCellErrors = false;
            this.DataView.ShowCellToolTips = false;
            this.DataView.ShowEditingIcon = false;
            this.DataView.ShowRowErrors = false;
            this.DataView.Size = new System.Drawing.Size(994, 171);
            this.DataView.TabIndex = 3;
            this.DataView.TabStop = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 51;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 105;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 104;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            this.patronymicDataGridViewTextBoxColumn.Width = 111;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            this.dOBDataGridViewTextBoxColumn.Width = 69;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 75;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 79;
            // 
            // telegramDataGridViewTextBoxColumn
            // 
            this.telegramDataGridViewTextBoxColumn.DataPropertyName = "Telegram";
            this.telegramDataGridViewTextBoxColumn.HeaderText = "Telegram";
            this.telegramDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telegramDataGridViewTextBoxColumn.Name = "telegramDataGridViewTextBoxColumn";
            this.telegramDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // universityDataGridViewTextBoxColumn
            // 
            this.universityDataGridViewTextBoxColumn.DataPropertyName = "University";
            this.universityDataGridViewTextBoxColumn.HeaderText = "University";
            this.universityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.universityDataGridViewTextBoxColumn.Name = "universityDataGridViewTextBoxColumn";
            this.universityDataGridViewTextBoxColumn.ReadOnly = true;
            this.universityDataGridViewTextBoxColumn.Width = 102;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryDataGridViewTextBoxColumn.Width = 89;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            this.regionDataGridViewTextBoxColumn.Width = 85;
            // 
            // townDataGridViewTextBoxColumn
            // 
            this.townDataGridViewTextBoxColumn.DataPropertyName = "Town";
            this.townDataGridViewTextBoxColumn.HeaderText = "Town";
            this.townDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.townDataGridViewTextBoxColumn.Name = "townDataGridViewTextBoxColumn";
            this.townDataGridViewTextBoxColumn.ReadOnly = true;
            this.townDataGridViewTextBoxColumn.Width = 73;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Width = 77;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "House";
            this.houseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseDataGridViewTextBoxColumn.Width = 80;
            // 
            // flatDataGridViewTextBoxColumn
            // 
            this.flatDataGridViewTextBoxColumn.DataPropertyName = "Flat";
            this.flatDataGridViewTextBoxColumn.HeaderText = "Flat";
            this.flatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flatDataGridViewTextBoxColumn.Name = "flatDataGridViewTextBoxColumn";
            this.flatDataGridViewTextBoxColumn.ReadOnly = true;
            this.flatDataGridViewTextBoxColumn.Width = 62;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 114;
            // 
            // contextMenuData
            // 
            this.contextMenuData.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuDeleteItem,
            this.ContextMenuUpdateItem});
            this.contextMenuData.Name = "contextMenuStrip1";
            this.contextMenuData.ShowImageMargin = false;
            this.contextMenuData.Size = new System.Drawing.Size(123, 52);
            this.contextMenuData.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuData_Opening);
            // 
            // ContextMenuDeleteItem
            // 
            this.ContextMenuDeleteItem.Name = "ContextMenuDeleteItem";
            this.ContextMenuDeleteItem.Size = new System.Drawing.Size(122, 24);
            this.ContextMenuDeleteItem.Text = "Удалить";
            this.ContextMenuDeleteItem.Click += new System.EventHandler(this.contextMenuDeleteItem_Click);
            // 
            // ContextMenuUpdateItem
            // 
            this.ContextMenuUpdateItem.Name = "ContextMenuUpdateItem";
            this.ContextMenuUpdateItem.Size = new System.Drawing.Size(122, 24);
            this.ContextMenuUpdateItem.Text = "Обновить";
            this.ContextMenuUpdateItem.Click += new System.EventHandler(this.contextMenuUpdateItem_Click);
            // 
            // userModelBindingSource
            // 
            this.userModelBindingSource.DataSource = typeof(DataAccess.Models.UserModel);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchBox.Controls.Add(this.radioButtonUpdate);
            this.SearchBox.Controls.Add(this.buttonСlear);
            this.SearchBox.Controls.Add(this.buttonAction);
            this.SearchBox.Controls.Add(this.radioButtonInsert);
            this.SearchBox.Controls.Add(this.radioButtonSearch);
            this.SearchBox.Controls.Add(this.labelDescription);
            this.SearchBox.Controls.Add(this.textBoxDOB);
            this.SearchBox.Controls.Add(this.textBoxDescription);
            this.SearchBox.Controls.Add(this.labelDOB);
            this.SearchBox.Controls.Add(this.labelFlat);
            this.SearchBox.Controls.Add(this.textBoxFlat);
            this.SearchBox.Controls.Add(this.labelHouse);
            this.SearchBox.Controls.Add(this.labelStreet);
            this.SearchBox.Controls.Add(this.labelTown);
            this.SearchBox.Controls.Add(this.labelRegion);
            this.SearchBox.Controls.Add(this.labelCounty);
            this.SearchBox.Controls.Add(this.textBoxHouse);
            this.SearchBox.Controls.Add(this.textBoxStreet);
            this.SearchBox.Controls.Add(this.textBoxTown);
            this.SearchBox.Controls.Add(this.textBoxRegion);
            this.SearchBox.Controls.Add(this.textBoxUniversity);
            this.SearchBox.Controls.Add(this.labelUniversity);
            this.SearchBox.Controls.Add(this.labelTelegram);
            this.SearchBox.Controls.Add(this.labelPhone);
            this.SearchBox.Controls.Add(this.labelEmail);
            this.SearchBox.Controls.Add(this.labelPatronymic);
            this.SearchBox.Controls.Add(this.labelLastName);
            this.SearchBox.Controls.Add(this.labelName);
            this.SearchBox.Controls.Add(this.textBoxCounty);
            this.SearchBox.Controls.Add(this.textBoxTelegram);
            this.SearchBox.Controls.Add(this.labelForm);
            this.SearchBox.Controls.Add(this.textBoxPhone);
            this.SearchBox.Controls.Add(this.textBoxEmail);
            this.SearchBox.Controls.Add(this.textBoxFirstName);
            this.SearchBox.Controls.Add(this.textBoxPatronymic);
            this.SearchBox.Controls.Add(this.textBoxLastName);
            this.SearchBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBox.Location = new System.Drawing.Point(14, 204);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(5);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(966, 246);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TabStop = false;
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Enabled = false;
            this.radioButtonUpdate.Location = new System.Drawing.Point(272, 4);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(165, 24);
            this.radioButtonUpdate.TabIndex = 37;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Обновить данные...";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_CheckedChanged);
            // 
            // buttonСlear
            // 
            this.buttonСlear.Location = new System.Drawing.Point(14, 137);
            this.buttonСlear.Name = "buttonСlear";
            this.buttonСlear.Size = new System.Drawing.Size(191, 93);
            this.buttonСlear.TabIndex = 17;
            this.buttonСlear.Text = "Очистить";
            this.buttonСlear.UseVisualStyleBackColor = true;
            this.buttonСlear.Click += new System.EventHandler(this.buttonСlear_Click);
            // 
            // buttonAction
            // 
            this.buttonAction.Location = new System.Drawing.Point(14, 38);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(191, 93);
            this.buttonAction.TabIndex = 16;
            this.buttonAction.Text = "Поиск";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.buttonAction_Click);
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonInsert.Location = new System.Drawing.Point(169, 5);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(97, 24);
            this.radioButtonInsert.TabIndex = 34;
            this.radioButtonInsert.Text = "Добавить";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            this.radioButtonInsert.CheckedChanged += new System.EventHandler(this.radioButtonInsert_CheckedChanged);
            // 
            // radioButtonSearch
            // 
            this.radioButtonSearch.AutoSize = true;
            this.radioButtonSearch.Checked = true;
            this.radioButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSearch.Location = new System.Drawing.Point(90, 5);
            this.radioButtonSearch.Name = "radioButtonSearch";
            this.radioButtonSearch.Size = new System.Drawing.Size(73, 24);
            this.radioButtonSearch.TabIndex = 33;
            this.radioButtonSearch.TabStop = true;
            this.radioButtonSearch.Text = "Поиск";
            this.radioButtonSearch.UseVisualStyleBackColor = true;
            this.radioButtonSearch.CheckedChanged += new System.EventHandler(this.radioButtonSearch_CheckedChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(693, 104);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(93, 23);
            this.labelDescription.TabIndex = 32;
            this.labelDescription.Text = "Описание:";
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxDOB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxDOB.Location = new System.Drawing.Point(835, 70);
            this.textBoxDOB.MaxLength = 10;
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(116, 27);
            this.textBoxDOB.TabIndex = 14;
            this.textBoxDOB.TabStop = false;
            this.textBoxDOB.Tag = "DOB";
            this.textBoxDOB.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDOB_Validating);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(693, 137);
            this.textBoxDescription.MaxLength = 200;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(258, 93);
            this.textBoxDescription.TabIndex = 15;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Tag = "Description";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDOB.Location = new System.Drawing.Point(693, 70);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(136, 23);
            this.labelDOB.TabIndex = 29;
            this.labelDOB.Text = "Дата рождения:";
            // 
            // labelFlat
            // 
            this.labelFlat.AutoSize = true;
            this.labelFlat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFlat.Location = new System.Drawing.Point(454, 203);
            this.labelFlat.Name = "labelFlat";
            this.labelFlat.Size = new System.Drawing.Size(88, 23);
            this.labelFlat.TabIndex = 27;
            this.labelFlat.Text = "Квартира:";
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxFlat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFlat.Location = new System.Drawing.Point(548, 203);
            this.textBoxFlat.MaxLength = 50;
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(120, 27);
            this.textBoxFlat.TabIndex = 12;
            this.textBoxFlat.TabStop = false;
            this.textBoxFlat.Tag = "Flat";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHouse.Location = new System.Drawing.Point(494, 170);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(48, 23);
            this.labelHouse.TabIndex = 25;
            this.labelHouse.Text = "Дом:";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStreet.Location = new System.Drawing.Point(480, 137);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(62, 23);
            this.labelStreet.TabIndex = 24;
            this.labelStreet.Text = "Улица:";
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTown.Location = new System.Drawing.Point(481, 104);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(61, 23);
            this.labelTown.TabIndex = 23;
            this.labelTown.Text = "Город:";
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRegion.Location = new System.Drawing.Point(463, 70);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(79, 23);
            this.labelRegion.TabIndex = 22;
            this.labelRegion.Text = "Область:";
            // 
            // labelCounty
            // 
            this.labelCounty.AutoSize = true;
            this.labelCounty.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCounty.Location = new System.Drawing.Point(472, 38);
            this.labelCounty.Name = "labelCounty";
            this.labelCounty.Size = new System.Drawing.Size(70, 23);
            this.labelCounty.TabIndex = 21;
            this.labelCounty.Text = "Страна:";
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxHouse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxHouse.Location = new System.Drawing.Point(548, 170);
            this.textBoxHouse.MaxLength = 50;
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(120, 27);
            this.textBoxHouse.TabIndex = 11;
            this.textBoxHouse.TabStop = false;
            this.textBoxHouse.Tag = "House";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxStreet.Location = new System.Drawing.Point(548, 137);
            this.textBoxStreet.MaxLength = 50;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(120, 27);
            this.textBoxStreet.TabIndex = 10;
            this.textBoxStreet.TabStop = false;
            this.textBoxStreet.Tag = "Street";
            // 
            // textBoxTown
            // 
            this.textBoxTown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxTown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTown.Location = new System.Drawing.Point(548, 104);
            this.textBoxTown.MaxLength = 50;
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(120, 27);
            this.textBoxTown.TabIndex = 9;
            this.textBoxTown.TabStop = false;
            this.textBoxTown.Tag = "Town";
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxRegion.Location = new System.Drawing.Point(548, 70);
            this.textBoxRegion.MaxLength = 50;
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(120, 27);
            this.textBoxRegion.TabIndex = 8;
            this.textBoxRegion.TabStop = false;
            this.textBoxRegion.Tag = "Region";
            // 
            // textBoxUniversity
            // 
            this.textBoxUniversity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxUniversity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxUniversity.Location = new System.Drawing.Point(835, 38);
            this.textBoxUniversity.Name = "textBoxUniversity";
            this.textBoxUniversity.Size = new System.Drawing.Size(116, 27);
            this.textBoxUniversity.TabIndex = 13;
            this.textBoxUniversity.TabStop = false;
            this.textBoxUniversity.Tag = "University";
            // 
            // labelUniversity
            // 
            this.labelUniversity.AutoSize = true;
            this.labelUniversity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUniversity.Location = new System.Drawing.Point(716, 38);
            this.labelUniversity.Name = "labelUniversity";
            this.labelUniversity.Size = new System.Drawing.Size(113, 23);
            this.labelUniversity.TabIndex = 15;
            this.labelUniversity.Text = "Университет:";
            // 
            // labelTelegram
            // 
            this.labelTelegram.AutoSize = true;
            this.labelTelegram.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelegram.Location = new System.Drawing.Point(228, 203);
            this.labelTelegram.Name = "labelTelegram";
            this.labelTelegram.Size = new System.Drawing.Size(83, 23);
            this.labelTelegram.TabIndex = 14;
            this.labelTelegram.Text = "Telegram:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(229, 170);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(82, 23);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(249, 137);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(62, 23);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Почта:";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPatronymic.Location = new System.Drawing.Point(224, 104);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(87, 23);
            this.labelPatronymic.TabIndex = 11;
            this.labelPatronymic.Text = "Отчество:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.Location = new System.Drawing.Point(226, 70);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(85, 23);
            this.labelLastName.TabIndex = 10;
            this.labelLastName.Text = "Фамилия:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(263, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 23);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Имя:";
            // 
            // textBoxCounty
            // 
            this.textBoxCounty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCounty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCounty.Location = new System.Drawing.Point(548, 38);
            this.textBoxCounty.MaxLength = 50;
            this.textBoxCounty.Name = "textBoxCounty";
            this.textBoxCounty.Size = new System.Drawing.Size(120, 27);
            this.textBoxCounty.TabIndex = 7;
            this.textBoxCounty.TabStop = false;
            this.textBoxCounty.Tag = "Country";
            // 
            // textBoxTelegram
            // 
            this.textBoxTelegram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxTelegram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxTelegram.Location = new System.Drawing.Point(314, 203);
            this.textBoxTelegram.MaxLength = 50;
            this.textBoxTelegram.Name = "textBoxTelegram";
            this.textBoxTelegram.Size = new System.Drawing.Size(120, 27);
            this.textBoxTelegram.TabIndex = 6;
            this.textBoxTelegram.TabStop = false;
            this.textBoxTelegram.Tag = "Telegram";
            this.textBoxTelegram.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTelegram_Validating);
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelForm.Location = new System.Drawing.Point(6, 0);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(78, 28);
            this.labelForm.TabIndex = 1;
            this.labelForm.Text = "Режим:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPhone.Location = new System.Drawing.Point(314, 170);
            this.textBoxPhone.MaxLength = 20;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(120, 27);
            this.textBoxPhone.TabIndex = 5;
            this.textBoxPhone.TabStop = false;
            this.textBoxPhone.Tag = "Phone";
            this.textBoxPhone.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPhone_Validating);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxEmail.Location = new System.Drawing.Point(314, 137);
            this.textBoxEmail.MaxLength = 50;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(120, 27);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.TabStop = false;
            this.textBoxEmail.Tag = "Email";
            this.textBoxEmail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmail_Validating);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFirstName.Location = new System.Drawing.Point(314, 38);
            this.textBoxFirstName.MaxLength = 50;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(120, 27);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.TabStop = false;
            this.textBoxFirstName.Tag = "FirstName";
            this.textBoxFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxFirstName_Validating);
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxPatronymic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxPatronymic.Location = new System.Drawing.Point(314, 104);
            this.textBoxPatronymic.MaxLength = 50;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(120, 27);
            this.textBoxPatronymic.TabIndex = 3;
            this.textBoxPatronymic.TabStop = false;
            this.textBoxPatronymic.Tag = "Patronymic";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxLastName.Location = new System.Drawing.Point(314, 70);
            this.textBoxLastName.MaxLength = 50;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(120, 27);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.TabStop = false;
            this.textBoxLastName.Tag = "LastName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(994, 464);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SearchBox);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1012, 450);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DbUserStudents";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.contextMenuData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userModelBindingSource)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem импортToolStripMenuItem;
        private ToolStripMenuItem экспортToolStripMenuItem;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telegramDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn universityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn townDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn flatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource userModelBindingSource;
        public DataGridView DataView;
        private ContextMenuStrip contextMenuData;
        private ToolStripMenuItem ContextMenuDeleteItem;
        private ToolStripMenuItem ContextMenuUpdateItem;
        private GroupBox SearchBox;
        private Label labelForm;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxPatronymic;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxCounty;
        private TextBox textBoxTelegram;
        private Label labelPatronymic;
        private Label labelLastName;
        private Label labelName;
        private Label labelTelegram;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelHouse;
        private Label labelStreet;
        private Label labelTown;
        private Label labelRegion;
        private Label labelCounty;
        private TextBox textBoxHouse;
        private TextBox textBoxStreet;
        private TextBox textBoxTown;
        private TextBox textBoxRegion;
        private TextBox textBoxUniversity;
        private Label labelUniversity;
        private Label labelDescription;
        private TextBox textBoxDOB;
        private TextBox textBoxDescription;
        private Label labelDOB;
        private Label labelFlat;
        private TextBox textBoxFlat;
        private RadioButton radioButtonInsert;
        private RadioButton radioButtonSearch;
        private Button buttonСlear;
        private Button buttonAction;
        private RadioButton radioButtonUpdate;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem таблицаToolStripMenuItem;
    }
}
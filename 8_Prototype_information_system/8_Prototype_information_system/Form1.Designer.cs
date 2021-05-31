
namespace _8_Prototype_information_system
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Самое важное");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Подразделение 1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Подразделение 2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Главное отделение", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Почти такое же главное");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУмолчаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultPath = new System.Windows.Forms.ToolStripTextBox();
            this.отделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxSort = new System.Windows.Forms.ToolStripComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TreeDepartments = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.localSave = new System.Windows.Forms.Button();
            this.employeesDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeDepartment = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nameDepartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateDepartment = new System.Windows.Forms.Panel();
            this.CreateDepartmentCheckRoot = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CreateDepartmentParent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CreateDepartmentButton = new System.Windows.Forms.Button();
            this.CreateDepartmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateDepartmentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.CreateDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.отделенияToolStripMenuItem,
            this.сотрудникиToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(1234, 33);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.поУмолчаниюToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форматJSONToolStripMenuItem,
            this.форматXMLToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // форматJSONToolStripMenuItem
            // 
            this.форматJSONToolStripMenuItem.Name = "форматJSONToolStripMenuItem";
            this.форматJSONToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
            this.форматJSONToolStripMenuItem.Text = "Формат JSON";
            this.форматJSONToolStripMenuItem.Click += new System.EventHandler(this.форматJSONToolStripMenuItem_Click);
            // 
            // форматXMLToolStripMenuItem
            // 
            this.форматXMLToolStripMenuItem.Name = "форматXMLToolStripMenuItem";
            this.форматXMLToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
            this.форматXMLToolStripMenuItem.Text = "Формат XML";
            this.форматXMLToolStripMenuItem.Click += new System.EventHandler(this.форматXMLToolStripMenuItem_Click);
            // 
            // поУмолчаниюToolStripMenuItem
            // 
            this.поУмолчаниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultPath});
            this.поУмолчаниюToolStripMenuItem.Name = "поУмолчаниюToolStripMenuItem";
            this.поУмолчаниюToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.поУмолчаниюToolStripMenuItem.Text = "По умолчанию";
            // 
            // defaultPath
            // 
            this.defaultPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.defaultPath.Name = "defaultPath";
            this.defaultPath.Size = new System.Drawing.Size(100, 27);
            this.defaultPath.Text = "data.json";
            // 
            // отделенияToolStripMenuItem
            // 
            this.отделенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.отделенияToolStripMenuItem.Name = "отделенияToolStripMenuItem";
            this.отделенияToolStripMenuItem.Size = new System.Drawing.Size(109, 27);
            this.отделенияToolStripMenuItem.Text = "Отделения";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(170, 28);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1,
            this.сортировкаToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(188, 28);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.добавитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(188, 28);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxSort});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // toolStripComboBoxSort
            // 
            this.toolStripComboBoxSort.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Возраст",
            "Идентификатор",
            "Зарплата"});
            this.toolStripComboBoxSort.Name = "toolStripComboBoxSort";
            this.toolStripComboBoxSort.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBoxSort.Text = "Фамилия";
            this.toolStripComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSort_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TreeDepartments);
            this.panel1.Location = new System.Drawing.Point(13, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 390);
            this.panel1.TabIndex = 1;
            // 
            // TreeDepartments
            // 
            this.TreeDepartments.Location = new System.Drawing.Point(4, 4);
            this.TreeDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.TreeDepartments.Name = "TreeDepartments";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "Самое важное";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "Подразделение 1";
            treeNode3.Name = "Узел4";
            treeNode3.Text = "Подразделение 2";
            treeNode4.Name = "Узел0";
            treeNode4.Text = "Главное отделение";
            treeNode5.Name = "Узел1";
            treeNode5.Text = "Почти такое же главное";
            this.TreeDepartments.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.TreeDepartments.Size = new System.Drawing.Size(336, 380);
            this.TreeDepartments.TabIndex = 0;
            this.TreeDepartments.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeDepartments_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Location = new System.Drawing.Point(367, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 346);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surname,
            this.firstName,
            this.age,
            this.id,
            this.salary});
            this.dataGridView.Location = new System.Drawing.Point(5, 5);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(843, 334);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // surname
            // 
            this.surname.HeaderText = "Фамилия";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Имя";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            // 
            // age
            // 
            this.age.HeaderText = "Возраст";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            // 
            // id
            // 
            this.id.HeaderText = "Идентификатор";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.HeaderText = "Зарплата";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.localSave);
            this.panel3.Controls.Add(this.employeesDepartment);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateTimeDepartment);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.nameDepartment);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(367, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 38);
            this.panel3.TabIndex = 3;
            // 
            // localSave
            // 
            this.localSave.BackgroundImage = global::_8_Prototype_information_system.Properties.Resources.edit;
            this.localSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.localSave.Location = new System.Drawing.Point(800, 3);
            this.localSave.Name = "localSave";
            this.localSave.Size = new System.Drawing.Size(30, 29);
            this.localSave.TabIndex = 7;
            this.localSave.UseVisualStyleBackColor = true;
            this.localSave.Click += new System.EventHandler(this.localSave_Click);
            // 
            // employeesDepartment
            // 
            this.employeesDepartment.Location = new System.Drawing.Point(715, 6);
            this.employeesDepartment.Name = "employeesDepartment";
            this.employeesDepartment.ReadOnly = true;
            this.employeesDepartment.Size = new System.Drawing.Size(70, 27);
            this.employeesDepartment.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Сотрудников";
            // 
            // dateTimeDepartment
            // 
            this.dateTimeDepartment.Location = new System.Drawing.Point(388, 6);
            this.dateTimeDepartment.Name = "dateTimeDepartment";
            this.dateTimeDepartment.Size = new System.Drawing.Size(200, 27);
            this.dateTimeDepartment.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата создания";
            // 
            // nameDepartment
            // 
            this.nameDepartment.Location = new System.Drawing.Point(100, 6);
            this.nameDepartment.Name = "nameDepartment";
            this.nameDepartment.Size = new System.Drawing.Size(147, 27);
            this.nameDepartment.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // CreateDepartment
            // 
            this.CreateDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateDepartment.Controls.Add(this.CreateDepartmentCheckRoot);
            this.CreateDepartment.Controls.Add(this.label8);
            this.CreateDepartment.Controls.Add(this.CreateDepartmentParent);
            this.CreateDepartment.Controls.Add(this.label7);
            this.CreateDepartment.Controls.Add(this.CreateDepartmentButton);
            this.CreateDepartment.Controls.Add(this.CreateDepartmentDateTime);
            this.CreateDepartment.Controls.Add(this.label6);
            this.CreateDepartment.Controls.Add(this.CreateDepartmentName);
            this.CreateDepartment.Controls.Add(this.label5);
            this.CreateDepartment.Location = new System.Drawing.Point(361, 34);
            this.CreateDepartment.Name = "CreateDepartment";
            this.CreateDepartment.Size = new System.Drawing.Size(861, 391);
            this.CreateDepartment.TabIndex = 1;
            this.CreateDepartment.Visible = false;
            // 
            // CreateDepartmentCheckRoot
            // 
            this.CreateDepartmentCheckRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateDepartmentCheckRoot.AutoSize = true;
            this.CreateDepartmentCheckRoot.Location = new System.Drawing.Point(428, 120);
            this.CreateDepartmentCheckRoot.Name = "CreateDepartmentCheckRoot";
            this.CreateDepartmentCheckRoot.Size = new System.Drawing.Size(18, 17);
            this.CreateDepartmentCheckRoot.TabIndex = 8;
            this.CreateDepartmentCheckRoot.UseVisualStyleBackColor = true;
            this.CreateDepartmentCheckRoot.CheckedChanged += new System.EventHandler(this.CreateDepartmentCheckRoot_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Корневое отделение";
            // 
            // CreateDepartmentParent
            // 
            this.CreateDepartmentParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateDepartmentParent.Location = new System.Drawing.Point(428, 68);
            this.CreateDepartmentParent.Name = "CreateDepartmentParent";
            this.CreateDepartmentParent.ReadOnly = true;
            this.CreateDepartmentParent.Size = new System.Drawing.Size(260, 27);
            this.CreateDepartmentParent.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Родительский отдел";
            // 
            // CreateDepartmentButton
            // 
            this.CreateDepartmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateDepartmentButton.Location = new System.Drawing.Point(390, 329);
            this.CreateDepartmentButton.Name = "CreateDepartmentButton";
            this.CreateDepartmentButton.Size = new System.Drawing.Size(110, 44);
            this.CreateDepartmentButton.TabIndex = 4;
            this.CreateDepartmentButton.Text = "Создать";
            this.CreateDepartmentButton.UseVisualStyleBackColor = true;
            this.CreateDepartmentButton.Click += new System.EventHandler(this.CreateDepartmentButton_Click);
            // 
            // CreateDepartmentDateTime
            // 
            this.CreateDepartmentDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateDepartmentDateTime.Location = new System.Drawing.Point(428, 212);
            this.CreateDepartmentDateTime.Name = "CreateDepartmentDateTime";
            this.CreateDepartmentDateTime.Size = new System.Drawing.Size(260, 27);
            this.CreateDepartmentDateTime.TabIndex = 3;
            this.CreateDepartmentDateTime.Value = new System.DateTime(2021, 5, 1, 19, 11, 20, 0);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Дата создания";
            // 
            // CreateDepartmentName
            // 
            this.CreateDepartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateDepartmentName.Location = new System.Drawing.Point(428, 163);
            this.CreateDepartmentName.Name = "CreateDepartmentName";
            this.CreateDepartmentName.Size = new System.Drawing.Size(260, 27);
            this.CreateDepartmentName.TabIndex = 1;
            this.CreateDepartmentName.Text = "Новое отделение";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Название отделения";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 436);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CreateDepartment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1252, 483);
            this.MinimumSize = new System.Drawing.Size(1252, 483);
            this.Name = "Form";
            this.Text = "Прототип информационной системы для организации";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.CreateDepartment.ResumeLayout(false);
            this.CreateDepartment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView TreeDepartments;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimeDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeesDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.Panel CreateDepartment;
        private System.Windows.Forms.DateTimePicker CreateDepartmentDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CreateDepartmentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateDepartmentButton;
        private System.Windows.Forms.TextBox CreateDepartmentParent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CreateDepartmentCheckRoot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button localSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem поУмолчаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox defaultPath;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSort;
    }
}


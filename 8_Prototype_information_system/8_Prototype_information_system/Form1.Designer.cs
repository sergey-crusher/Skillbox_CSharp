
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
            this.отделенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TreeDepartments = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nameDepartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateDepartment = new System.Windows.Forms.Panel();
            this.CreateDepartmentCheckRoot = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CreateDepartmentButton = new System.Windows.Forms.Button();
            this.CreateDepartmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateDepartmentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(178, 28);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форматJSONToolStripMenuItem,
            this.форматXMLToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(178, 28);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // форматJSONToolStripMenuItem
            // 
            this.форматJSONToolStripMenuItem.Name = "форматJSONToolStripMenuItem";
            this.форматJSONToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
            this.форматJSONToolStripMenuItem.Text = "Формат JSON";
            // 
            // форматXMLToolStripMenuItem
            // 
            this.форматXMLToolStripMenuItem.Name = "форматXMLToolStripMenuItem";
            this.форматXMLToolStripMenuItem.Size = new System.Drawing.Size(200, 28);
            this.форматXMLToolStripMenuItem.Text = "Формат XML";
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
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem1});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(117, 27);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(170, 28);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(170, 28);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
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
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(367, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 346);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surname,
            this.firstName,
            this.age,
            this.id,
            this.salary});
            this.dataGridView1.Location = new System.Drawing.Point(5, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 334);
            this.dataGridView1.TabIndex = 0;
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
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.nameDepartment);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(367, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 38);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::_8_Prototype_information_system.Properties.Resources.edit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(803, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 29);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(715, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(70, 27);
            this.textBox1.TabIndex = 6;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 4;
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
            this.CreateDepartment.Controls.Add(this.textBox2);
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
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(428, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(260, 27);
            this.textBox2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Родительское id";
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
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Дата/Время";
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
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 436);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.CreateDepartment);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.Text = "Прототип информационной системы для организации";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.Panel CreateDepartment;
        private System.Windows.Forms.DateTimePicker CreateDepartmentDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CreateDepartmentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateDepartmentButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CreateDepartmentCheckRoot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}


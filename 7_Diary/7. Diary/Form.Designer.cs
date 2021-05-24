namespace _7.Diary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Turnover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.DownloadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ConcatenationFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportByDate_ = new System.Windows.Forms.ToolStripMenuItem();
            this.начальнаяДатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.start = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.конечнаяДатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.end = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ImportByDate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddRow = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveRow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.SortBox = new System.Windows.Forms.ToolStripComboBox();
            this.Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Date,
            this.Sum,
            this.Income,
            this.Profit,
            this.Turnover,
            this.Note});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1164, 456);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // Index
            // 
            this.Index.HeaderText = "Индекс";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Index.Visible = false;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sum
            // 
            this.Sum.HeaderText = "Сумма";
            this.Sum.MinimumWidth = 6;
            this.Sum.Name = "Sum";
            this.Sum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Income
            // 
            this.Income.HeaderText = "Доход";
            this.Income.MinimumWidth = 6;
            this.Income.Name = "Income";
            this.Income.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Прибыль";
            this.Profit.MinimumWidth = 6;
            this.Profit.Name = "Profit";
            this.Profit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Turnover
            // 
            this.Turnover.HeaderText = "Оборот";
            this.Turnover.MinimumWidth = 6;
            this.Turnover.Name = "Turnover";
            this.Turnover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Note
            // 
            this.Note.HeaderText = "Заметки";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripDropDownButton2,
            this.toolStripSeparator1,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStrip1.Size = new System.Drawing.Size(1186, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadFile,
            this.UploadFile,
            this.ConcatenationFile,
            this.ImportByDate_});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 25);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // DownloadFile
            // 
            this.DownloadFile.Name = "DownloadFile";
            this.DownloadFile.Size = new System.Drawing.Size(569, 26);
            this.DownloadFile.Text = "Загрузки данных из файла";
            this.DownloadFile.Click += new System.EventHandler(this.загрузкиДаннахИзФайлаToolStripMenuItem_Click);
            // 
            // UploadFile
            // 
            this.UploadFile.Enabled = false;
            this.UploadFile.Name = "UploadFile";
            this.UploadFile.Size = new System.Drawing.Size(569, 26);
            this.UploadFile.Text = "Выгрузки даннах в файл";
            this.UploadFile.Click += new System.EventHandler(this.выгрузкиДаннахВФайлToolStripMenuItem_Click);
            // 
            // ConcatenationFile
            // 
            this.ConcatenationFile.Enabled = false;
            this.ConcatenationFile.Name = "ConcatenationFile";
            this.ConcatenationFile.Size = new System.Drawing.Size(569, 26);
            this.ConcatenationFile.Text = "Добавления данных в текущий ежедневник из выбранного файла";
            this.ConcatenationFile.Click += new System.EventHandler(this.добавленияДанныхВТекущийЕжедневникИзВыбранногоФайлаToolStripMenuItem_Click);
            // 
            // ImportByDate_
            // 
            this.ImportByDate_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начальнаяДатаToolStripMenuItem,
            this.start,
            this.toolStripSeparator3,
            this.конечнаяДатаToolStripMenuItem,
            this.end,
            this.toolStripSeparator4,
            this.ImportByDate});
            this.ImportByDate_.Name = "ImportByDate_";
            this.ImportByDate_.Size = new System.Drawing.Size(569, 26);
            this.ImportByDate_.Text = "Импорт записей по выбранному диапазону дат";
            // 
            // начальнаяДатаToolStripMenuItem
            // 
            this.начальнаяДатаToolStripMenuItem.Enabled = false;
            this.начальнаяДатаToolStripMenuItem.Name = "начальнаяДатаToolStripMenuItem";
            this.начальнаяДатаToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.начальнаяДатаToolStripMenuItem.Text = "Начальная дата";
            // 
            // start
            // 
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(207, 26);
            this.start.Text = "01.05.2018";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // конечнаяДатаToolStripMenuItem
            // 
            this.конечнаяДатаToolStripMenuItem.Enabled = false;
            this.конечнаяДатаToolStripMenuItem.Name = "конечнаяДатаToolStripMenuItem";
            this.конечнаяДатаToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.конечнаяДатаToolStripMenuItem.Text = "Конечная дата";
            // 
            // end
            // 
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(207, 26);
            this.end.Text = "15.02.2019";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(204, 6);
            // 
            // ImportByDate
            // 
            this.ImportByDate.Name = "ImportByDate";
            this.ImportByDate.Size = new System.Drawing.Size(207, 26);
            this.ImportByDate.Text = "Импорт";
            this.ImportByDate.Click += new System.EventHandler(this.ImportByDate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRow,
            this.RemoveRow});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(76, 25);
            this.toolStripDropDownButton2.Text = "Правка";
            // 
            // AddRow
            // 
            this.AddRow.Name = "AddRow";
            this.AddRow.Size = new System.Drawing.Size(163, 26);
            this.AddRow.Text = "Добавить";
            this.AddRow.Click += new System.EventHandler(this.AddRow_Click);
            // 
            // RemoveRow
            // 
            this.RemoveRow.Enabled = false;
            this.RemoveRow.Name = "RemoveRow";
            this.RemoveRow.Size = new System.Drawing.Size(163, 26);
            this.RemoveRow.Text = "Удалить";
            this.RemoveRow.Click += new System.EventHandler(this.RemoveRow_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortBox,
            this.Sort});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(109, 25);
            this.toolStripDropDownButton3.Text = "Сортировка";
            // 
            // SortBox
            // 
            this.SortBox.Items.AddRange(new object[] {
            "Дата",
            "Сумма",
            "Доход",
            "Прибыль",
            "Оборот",
            "Заметки"});
            this.SortBox.Name = "SortBox";
            this.SortBox.Size = new System.Drawing.Size(121, 28);
            this.SortBox.Text = "Дата";
            // 
            // Sort
            // 
            this.Sort.Enabled = false;
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(195, 26);
            this.Sort.Text = "Применить";
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "file.json";
            this.openFileDialog1.InitialDirectory = "./";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1186, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "Form";
            this.Text = "Trader diary";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem DownloadFile;
        private System.Windows.Forms.ToolStripMenuItem UploadFile;
        private System.Windows.Forms.ToolStripMenuItem ConcatenationFile;
        private System.Windows.Forms.ToolStripMenuItem ImportByDate_;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Turnover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem AddRow;
        private System.Windows.Forms.ToolStripMenuItem RemoveRow;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripComboBox SortBox;
        private System.Windows.Forms.ToolStripMenuItem Sort;
        private System.Windows.Forms.ToolStripMenuItem начальнаяДатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem start;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem конечнаяДатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem end;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ImportByDate;
    }
}


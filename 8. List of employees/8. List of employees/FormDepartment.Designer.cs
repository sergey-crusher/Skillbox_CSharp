namespace _8.List_of_employees
{
    partial class FormDepartment
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameDepartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreationDate = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberEmployees = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название отделения:";
            // 
            // NameDepartment
            // 
            this.NameDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.NameDepartment.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameDepartment.Location = new System.Drawing.Point(217, 16);
            this.NameDepartment.Name = "NameDepartment";
            this.NameDepartment.Size = new System.Drawing.Size(192, 29);
            this.NameDepartment.TabIndex = 1;
            this.NameDepartment.Text = "Новое отделение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата создания:";
            // 
            // CreationDate
            // 
            this.CreationDate.Location = new System.Drawing.Point(217, 73);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Штат сотрудников:";
            // 
            // NumberEmployees
            // 
            this.NumberEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.NumberEmployees.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NumberEmployees.Location = new System.Drawing.Point(217, 303);
            this.NumberEmployees.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumberEmployees.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberEmployees.Name = "NumberEmployees";
            this.NumberEmployees.Size = new System.Drawing.Size(192, 29);
            this.NumberEmployees.TabIndex = 6;
            this.NumberEmployees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberEmployees.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.button1.Location = new System.Drawing.Point(26, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(383, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AddDepartment);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(68)))));
            this.button2.Location = new System.Drawing.Point(26, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(383, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Close);
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(439, 473);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumberEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreationDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameDepartment);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новое отделения";
            ((System.ComponentModel.ISupportInitialize)(this.NumberEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar CreationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumberEmployees;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
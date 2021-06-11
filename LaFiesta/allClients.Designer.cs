namespace LaFiesta
{
    partial class allClients
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pasport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Given = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objective = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cName,
            this.Birthday,
            this.Place,
            this.Pasport,
            this.PasportDate,
            this.Given,
            this.Objective,
            this.LastDate});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 550);
            this.dataGridView1.TabIndex = 15;
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            // 
            // cName
            // 
            this.cName.HeaderText = "ФИО";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            this.cName.Width = 200;
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Дата рождения";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Width = 70;
            // 
            // Place
            // 
            this.Place.HeaderText = "Место рождения";
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Width = 80;
            // 
            // Pasport
            // 
            this.Pasport.HeaderText = "Паспорт";
            this.Pasport.Name = "Pasport";
            this.Pasport.ReadOnly = true;
            this.Pasport.Width = 80;
            // 
            // PasportDate
            // 
            this.PasportDate.HeaderText = "Дата";
            this.PasportDate.Name = "PasportDate";
            this.PasportDate.ReadOnly = true;
            this.PasportDate.Width = 60;
            // 
            // Given
            // 
            this.Given.HeaderText = "Выдан";
            this.Given.Name = "Given";
            this.Given.ReadOnly = true;
            // 
            // Objective
            // 
            this.Objective.HeaderText = "Цель приезда";
            this.Objective.Name = "Objective";
            this.Objective.ReadOnly = true;
            // 
            // LastDate
            // 
            this.LastDate.HeaderText = "Последнее посещение";
            this.LastDate.Name = "LastDate";
            this.LastDate.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 609);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 35);
            this.button5.TabIndex = 21;
            this.button5.TabStop = false;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(268, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 35);
            this.button4.TabIndex = 20;
            this.button4.TabStop = false;
            this.button4.Text = "Подробнее";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 650);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 35);
            this.button3.TabIndex = 19;
            this.button3.TabStop = false;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 35);
            this.button2.TabIndex = 18;
            this.button2.TabStop = false;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(268, 650);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(250, 35);
            this.button9.TabIndex = 17;
            this.button9.TabStop = false;
            this.button9.Text = "Вернуться назад";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 35);
            this.button1.TabIndex = 16;
            this.button1.TabStop = false;
            this.button1.Text = "Добавить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(524, 568);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 35);
            this.button6.TabIndex = 22;
            this.button6.TabStop = false;
            this.button6.Text = "Печать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // allClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 692);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "allClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "allClients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.allClients_FormClosed);
            this.Load += new System.EventHandler(this.allClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pasport;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasportDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Given;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objective;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDate;
        private System.Windows.Forms.Button button6;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
namespace LaFiesta
{
    partial class allFlats
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Floor,
            this.Number,
            this.Beds,
            this.Rooms,
            this.Class});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 550);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Floor
            // 
            this.Floor.HeaderText = "Этаж";
            this.Floor.Name = "Floor";
            this.Floor.ReadOnly = true;
            this.Floor.Width = 80;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 80;
            // 
            // Beds
            // 
            this.Beds.HeaderText = "Места";
            this.Beds.Name = "Beds";
            this.Beds.ReadOnly = true;
            this.Beds.Width = 80;
            // 
            // Rooms
            // 
            this.Rooms.HeaderText = "Комнаты";
            this.Rooms.Name = "Rooms";
            this.Rooms.ReadOnly = true;
            this.Rooms.Width = 80;
            // 
            // Class
            // 
            this.Class.HeaderText = "Класс";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 200;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(268, 650);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(250, 35);
            this.button9.TabIndex = 10;
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
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.Text = "Добавить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 35);
            this.button2.TabIndex = 11;
            this.button2.TabStop = false;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 650);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 35);
            this.button3.TabIndex = 12;
            this.button3.TabStop = false;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(268, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 35);
            this.button4.TabIndex = 13;
            this.button4.TabStop = false;
            this.button4.Text = "Подробнее";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 609);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 35);
            this.button5.TabIndex = 14;
            this.button5.TabStop = false;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(524, 568);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 35);
            this.button6.TabIndex = 15;
            this.button6.TabStop = false;
            this.button6.Text = "Печать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // allFlats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 711);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "allFlats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "allFlats";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.allFlats_FormClosed);
            this.Load += new System.EventHandler(this.allFlats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Floor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beds;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
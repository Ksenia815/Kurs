namespace LaFiesta
{
    partial class allLive
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
            this.lID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lStop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lID,
            this.lName,
            this.lNum,
            this.lStart,
            this.lStop,
            this.lPay,
            this.lClass});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 550);
            this.dataGridView1.TabIndex = 22;
            // 
            // lID
            // 
            this.lID.HeaderText = "ID";
            this.lID.Name = "lID";
            this.lID.ReadOnly = true;
            // 
            // lName
            // 
            this.lName.HeaderText = "ФИО клиента";
            this.lName.Name = "lName";
            this.lName.ReadOnly = true;
            this.lName.Width = 200;
            // 
            // lNum
            // 
            this.lNum.HeaderText = "Номер";
            this.lNum.Name = "lNum";
            this.lNum.ReadOnly = true;
            this.lNum.Width = 70;
            // 
            // lStart
            // 
            this.lStart.HeaderText = "Начало брони";
            this.lStart.Name = "lStart";
            this.lStart.ReadOnly = true;
            this.lStart.Width = 80;
            // 
            // lStop
            // 
            this.lStop.HeaderText = "Конец брони";
            this.lStop.Name = "lStop";
            this.lStop.ReadOnly = true;
            this.lStop.Width = 80;
            // 
            // lPay
            // 
            this.lPay.HeaderText = "К оплате";
            this.lPay.Name = "lPay";
            this.lPay.ReadOnly = true;
            // 
            // lClass
            // 
            this.lClass.HeaderText = "Класс номера";
            this.lClass.Name = "lClass";
            this.lClass.ReadOnly = true;
            this.lClass.Width = 140;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 568);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 35);
            this.button5.TabIndex = 28;
            this.button5.TabStop = false;
            this.button5.Text = "Обновить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 650);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 35);
            this.button4.TabIndex = 27;
            this.button4.TabStop = false;
            this.button4.Text = "Подробнее";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(268, 609);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(250, 35);
            this.button9.TabIndex = 24;
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
            this.button1.TabIndex = 23;
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
            this.button2.TabIndex = 25;
            this.button2.TabStop = false;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 650);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 35);
            this.button3.TabIndex = 29;
            this.button3.TabStop = false;
            this.button3.Text = "Печать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // allLive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 690);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "allLive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "allLive";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.allLive_FormClosed);
            this.Load += new System.EventHandler(this.allLive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn lStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn lStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn lPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn lClass;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button3;
    }
}
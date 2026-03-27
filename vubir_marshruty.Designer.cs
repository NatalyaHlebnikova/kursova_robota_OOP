namespace kyrsova_robota
{
    partial class vubir_marshruty
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonMyBookings = new System.Windows.Forms.Button();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "звідки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(306, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "знайти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(318, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "куди";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(593, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // buttonMyBookings
            // 
            this.buttonMyBookings.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonMyBookings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonMyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyBookings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMyBookings.Location = new System.Drawing.Point(606, 189);
            this.buttonMyBookings.Name = "buttonMyBookings";
            this.buttonMyBookings.Size = new System.Drawing.Size(160, 50);
            this.buttonMyBookings.TabIndex = 7;
            this.buttonMyBookings.Text = "мої бронювання";
            this.buttonMyBookings.UseVisualStyleBackColor = false;
            this.buttonMyBookings.Click += new System.EventHandler(this.buttonMyBookings_Click);
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Location = new System.Drawing.Point(103, 60);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(150, 26);
            this.comboBoxFrom.TabIndex = 8;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Location = new System.Drawing.Point(387, 60);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(150, 26);
            this.comboBoxTo.TabIndex = 9;
            // 
            // vubir_marshruty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 288);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.buttonMyBookings);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "vubir_marshruty";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMyBookings;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
    }
}
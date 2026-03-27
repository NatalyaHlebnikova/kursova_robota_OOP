namespace kyrsova_robota
{
    partial class kvitanciya
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
            this.lblRouteTitle = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblVagonTitle = new System.Windows.Forms.Label();
            this.lblSeatTitle = new System.Windows.Forms.Label();
            this.lblPassengerTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.lblTicketValue = new System.Windows.Forms.Label();
            this.lblRouteValue = new System.Windows.Forms.Label();
            this.lblDateValue = new System.Windows.Forms.Label();
            this.lblVagonValue = new System.Windows.Forms.Label();
            this.lblSeatValue = new System.Windows.Forms.Label();
            this.lblPassengerValue = new System.Windows.Forms.Label();
            this.lblTicketTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(263, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Квитанція про бронювання";
            // 
            // lblRouteTitle
            // 
            this.lblRouteTitle.AutoSize = true;
            this.lblRouteTitle.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRouteTitle.Location = new System.Drawing.Point(34, 218);
            this.lblRouteTitle.Name = "lblRouteTitle";
            this.lblRouteTitle.Size = new System.Drawing.Size(82, 19);
            this.lblRouteTitle.TabIndex = 1;
            this.lblRouteTitle.Text = "Маршрут";
            this.lblRouteTitle.Click += new System.EventHandler(this.lblRoute_Click);
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateTitle.Location = new System.Drawing.Point(588, 303);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(47, 19);
            this.lblDateTitle.TabIndex = 2;
            this.lblDateTitle.Text = "Дата";
            // 
            // lblVagonTitle
            // 
            this.lblVagonTitle.AutoSize = true;
            this.lblVagonTitle.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVagonTitle.Location = new System.Drawing.Point(350, 218);
            this.lblVagonTitle.Name = "lblVagonTitle";
            this.lblVagonTitle.Size = new System.Drawing.Size(57, 19);
            this.lblVagonTitle.TabIndex = 3;
            this.lblVagonTitle.Text = "Вагон";
            // 
            // lblSeatTitle
            // 
            this.lblSeatTitle.AutoSize = true;
            this.lblSeatTitle.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeatTitle.Location = new System.Drawing.Point(588, 219);
            this.lblSeatTitle.Name = "lblSeatTitle";
            this.lblSeatTitle.Size = new System.Drawing.Size(54, 19);
            this.lblSeatTitle.TabIndex = 4;
            this.lblSeatTitle.Text = "Місце";
            // 
            // lblPassengerTitle
            // 
            this.lblPassengerTitle.AutoSize = true;
            this.lblPassengerTitle.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassengerTitle.Location = new System.Drawing.Point(34, 126);
            this.lblPassengerTitle.Name = "lblPassengerTitle";
            this.lblPassengerTitle.Size = new System.Drawing.Size(80, 19);
            this.lblPassengerTitle.TabIndex = 5;
            this.lblPassengerTitle.Text = "Пасажир";
            this.lblPassengerTitle.Click += new System.EventHandler(this.lblPassenger_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(592, 369);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(160, 50);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click_1);
            // 
            // lblTicketValue
            // 
            this.lblTicketValue.AutoSize = true;
            this.lblTicketValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTicketValue.Location = new System.Drawing.Point(163, 39);
            this.lblTicketValue.Name = "lblTicketValue";
            this.lblTicketValue.Size = new System.Drawing.Size(50, 18);
            this.lblTicketValue.TabIndex = 8;
            this.lblTicketValue.Text = "label2";
            // 
            // lblRouteValue
            // 
            this.lblRouteValue.AutoSize = true;
            this.lblRouteValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRouteValue.Location = new System.Drawing.Point(154, 218);
            this.lblRouteValue.Name = "lblRouteValue";
            this.lblRouteValue.Size = new System.Drawing.Size(50, 18);
            this.lblRouteValue.TabIndex = 9;
            this.lblRouteValue.Text = "label2";
            // 
            // lblDateValue
            // 
            this.lblDateValue.AutoSize = true;
            this.lblDateValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateValue.Location = new System.Drawing.Point(655, 303);
            this.lblDateValue.Name = "lblDateValue";
            this.lblDateValue.Size = new System.Drawing.Size(50, 18);
            this.lblDateValue.TabIndex = 10;
            this.lblDateValue.Text = "label2";
            // 
            // lblVagonValue
            // 
            this.lblVagonValue.AutoSize = true;
            this.lblVagonValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVagonValue.Location = new System.Drawing.Point(427, 218);
            this.lblVagonValue.Name = "lblVagonValue";
            this.lblVagonValue.Size = new System.Drawing.Size(50, 18);
            this.lblVagonValue.TabIndex = 11;
            this.lblVagonValue.Text = "label2";
            // 
            // lblSeatValue
            // 
            this.lblSeatValue.AutoSize = true;
            this.lblSeatValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSeatValue.Location = new System.Drawing.Point(655, 218);
            this.lblSeatValue.Name = "lblSeatValue";
            this.lblSeatValue.Size = new System.Drawing.Size(50, 18);
            this.lblSeatValue.TabIndex = 12;
            this.lblSeatValue.Text = "label2";
            // 
            // lblPassengerValue
            // 
            this.lblPassengerValue.AutoSize = true;
            this.lblPassengerValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassengerValue.Location = new System.Drawing.Point(154, 126);
            this.lblPassengerValue.Name = "lblPassengerValue";
            this.lblPassengerValue.Size = new System.Drawing.Size(50, 18);
            this.lblPassengerValue.TabIndex = 13;
            this.lblPassengerValue.Text = "label2";
            // 
            // lblTicketTitle
            // 
            this.lblTicketTitle.AutoSize = true;
            this.lblTicketTitle.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTicketTitle.Location = new System.Drawing.Point(34, 39);
            this.lblTicketTitle.Name = "lblTicketTitle";
            this.lblTicketTitle.Size = new System.Drawing.Size(123, 19);
            this.lblTicketTitle.TabIndex = 7;
            this.lblTicketTitle.Text = "Номер квитка";
            this.lblTicketTitle.Click += new System.EventHandler(this.lblTicket_Click);
            // 
            // kvitanciya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 444);
            this.Controls.Add(this.lblPassengerValue);
            this.Controls.Add(this.lblSeatValue);
            this.Controls.Add(this.lblVagonValue);
            this.Controls.Add(this.lblDateValue);
            this.Controls.Add(this.lblRouteValue);
            this.Controls.Add(this.lblTicketValue);
            this.Controls.Add(this.lblTicketTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.lblPassengerTitle);
            this.Controls.Add(this.lblSeatTitle);
            this.Controls.Add(this.lblVagonTitle);
            this.Controls.Add(this.lblDateTitle);
            this.Controls.Add(this.lblRouteTitle);
            this.Controls.Add(this.label1);
            this.Name = "kvitanciya";
            this.Text = "kvitanciya";
            this.Load += new System.EventHandler(this.kvitanciya_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRouteTitle;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblVagonTitle;
        private System.Windows.Forms.Label lblSeatTitle;
        private System.Windows.Forms.Label lblPassengerTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label lblTicketValue;
        private System.Windows.Forms.Label lblRouteValue;
        private System.Windows.Forms.Label lblDateValue;
        private System.Windows.Forms.Label lblVagonValue;
        private System.Windows.Forms.Label lblSeatValue;
        private System.Windows.Forms.Label lblPassengerValue;
        private System.Windows.Forms.Label lblTicketTitle;
    }
}
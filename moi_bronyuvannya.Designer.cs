namespace kyrsova_robota
{
    partial class moi_bronyuvannya
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
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookings
            // 
            this.dgvBookings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(12, 73);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.Size = new System.Drawing.Size(856, 130);
            this.dgvBookings.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(241, 332);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 50);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPay.Location = new System.Drawing.Point(507, 332);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(160, 50);
            this.buttonPay.TabIndex = 2;
            this.buttonPay.Text = "Оплатити";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // moi_bronyuvannya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dgvBookings);
            this.Name = "moi_bronyuvannya";
            this.Text = "moi_bronyuvannya";
            this.Load += new System.EventHandler(this.moi_bronyuvannya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPay;
    }
}
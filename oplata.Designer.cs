namespace kyrsova_robota
{
    partial class oplata
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
            this.textBoxCard = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxCard
            // 
            this.textBoxCard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCard.Location = new System.Drawing.Point(218, 51);
            this.textBoxCard.Multiline = true;
            this.textBoxCard.Name = "textBoxCard";
            this.textBoxCard.Size = new System.Drawing.Size(180, 30);
            this.textBoxCard.TabIndex = 0;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDate.Location = new System.Drawing.Point(218, 122);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(180, 30);
            this.textBoxDate.TabIndex = 1;
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCVV.Location = new System.Drawing.Point(218, 194);
            this.textBoxCVV.Multiline = true;
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(180, 30);
            this.textBoxCVV.TabIndex = 2;
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPay.Location = new System.Drawing.Point(155, 310);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(160, 50);
            this.buttonPay.TabIndex = 3;
            this.buttonPay.Text = "Оплатити";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(53, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Номер картки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Термін дії";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(53, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "CVV";
            // 
            // oplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxCard);
            this.Name = "oplata";
            this.Text = "oplata";
            this.Load += new System.EventHandler(this.oplata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCard;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
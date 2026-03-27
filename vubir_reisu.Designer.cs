namespace kyrsova_robota
{
    partial class vubir_reisu
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
            this.dgvTrips = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrips
            // 
            this.dgvTrips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrips.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTrips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Location = new System.Drawing.Point(12, 150);
            this.dgvTrips.MultiSelect = false;
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.ReadOnly = true;
            this.dgvTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrips.Size = new System.Drawing.Size(776, 91);
            this.dgvTrips.TabIndex = 5;
            this.dgvTrips.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrips_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(595, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Обрати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(302, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Доступні рейси";
            // 
            // vubir_reisu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTrips);
            this.Name = "vubir_reisu";
            this.Text = "vubir_reisu";
            this.Load += new System.EventHandler(this.vubir_reisu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTrips;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
namespace kyrsova_robota
{
    partial class vubir_vagona
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
            this.dgvVagony = new System.Windows.Forms.DataGridView();
            this.buttonSelectVagon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagony)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(318, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вибір вагону";
            // 
            // dgvVagony
            // 
            this.dgvVagony.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVagony.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvVagony.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVagony.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVagony.Location = new System.Drawing.Point(12, 124);
            this.dgvVagony.Name = "dgvVagony";
            this.dgvVagony.ReadOnly = true;
            this.dgvVagony.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVagony.Size = new System.Drawing.Size(776, 149);
            this.dgvVagony.TabIndex = 1;
            // 
            // buttonSelectVagon
            // 
            this.buttonSelectVagon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSelectVagon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonSelectVagon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectVagon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectVagon.Location = new System.Drawing.Point(322, 329);
            this.buttonSelectVagon.Name = "buttonSelectVagon";
            this.buttonSelectVagon.Size = new System.Drawing.Size(160, 50);
            this.buttonSelectVagon.TabIndex = 2;
            this.buttonSelectVagon.Text = "Вибрати вагон";
            this.buttonSelectVagon.UseVisualStyleBackColor = false;
            this.buttonSelectVagon.Click += new System.EventHandler(this.buttonSelectVagon_Click);
            // 
            // vubir_vagona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSelectVagon);
            this.Controls.Add(this.dgvVagony);
            this.Controls.Add(this.label1);
            this.Name = "vubir_vagona";
            this.Text = "vubir_vagona";
            this.Load += new System.EventHandler(this.vubir_vagona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVagony)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVagony;
        private System.Windows.Forms.Button buttonSelectVagon;
    }
}
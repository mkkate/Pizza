namespace Pizza.Forme
{
    partial class AzurirajPorudzbinuForm
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
            this.lblDatumVremeIsporuke = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.nudIdPorudzbine = new System.Windows.Forms.NumericUpDown();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDatumVremeIsporuke = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPorudzbine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id porudzbine:";
            // 
            // lblDatumVremeIsporuke
            // 
            this.lblDatumVremeIsporuke.AutoSize = true;
            this.lblDatumVremeIsporuke.Location = new System.Drawing.Point(33, 108);
            this.lblDatumVremeIsporuke.Name = "lblDatumVremeIsporuke";
            this.lblDatumVremeIsporuke.Size = new System.Drawing.Size(121, 13);
            this.lblDatumVremeIsporuke.TabIndex = 1;
            this.lblDatumVremeIsporuke.Text = "Datum i vreme isporuke:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(36, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(142, 180);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // nudIdPorudzbine
            // 
            this.nudIdPorudzbine.Location = new System.Drawing.Point(173, 29);
            this.nudIdPorudzbine.Name = "nudIdPorudzbine";
            this.nudIdPorudzbine.Size = new System.Drawing.Size(120, 20);
            this.nudIdPorudzbine.TabIndex = 4;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(173, 66);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // dtpDatumVremeIsporuke
            // 
            this.dtpDatumVremeIsporuke.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDatumVremeIsporuke.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumVremeIsporuke.Location = new System.Drawing.Point(173, 108);
            this.dtpDatumVremeIsporuke.Name = "dtpDatumVremeIsporuke";
            this.dtpDatumVremeIsporuke.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumVremeIsporuke.TabIndex = 6;
            // 
            // AzurirajPorudzbinu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.dtpDatumVremeIsporuke);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.nudIdPorudzbine);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDatumVremeIsporuke);
            this.Controls.Add(this.label1);
            this.Name = "AzurirajPorudzbinu";
            this.Text = "AzurirajPorudzbinu";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPorudzbine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatumVremeIsporuke;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.NumericUpDown nudIdPorudzbine;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpDatumVremeIsporuke;
    }
}
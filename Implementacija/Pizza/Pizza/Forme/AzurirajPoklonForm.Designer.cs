namespace Pizza.Forme
{
    partial class AzurirajPoklonForm
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
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtIskoriscenje = new System.Windows.Forms.DateTimePicker();
            this.upDownId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.upDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(287, 192);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAzuriraj.TabIndex = 0;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(79, 53);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(62, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID poklona:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(79, 120);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(99, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum iskoriscenja:";
            // 
            // dtIskoriscenje
            // 
            this.dtIskoriscenje.Location = new System.Drawing.Point(212, 114);
            this.dtIskoriscenje.Name = "dtIskoriscenje";
            this.dtIskoriscenje.Size = new System.Drawing.Size(200, 20);
            this.dtIskoriscenje.TabIndex = 3;
            // 
            // upDownId
            // 
            this.upDownId.Location = new System.Drawing.Point(212, 51);
            this.upDownId.Name = "upDownId";
            this.upDownId.Size = new System.Drawing.Size(120, 20);
            this.upDownId.TabIndex = 4;
            // 
            // AzurirajPoklonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 265);
            this.Controls.Add(this.upDownId);
            this.Controls.Add(this.dtIskoriscenje);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnAzuriraj);
            this.Name = "AzurirajPoklonForm";
            this.Text = "AzurirajPoklonForm";
            ((System.ComponentModel.ISupportInitialize)(this.upDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtIskoriscenje;
        private System.Windows.Forms.NumericUpDown upDownId;
    }
}
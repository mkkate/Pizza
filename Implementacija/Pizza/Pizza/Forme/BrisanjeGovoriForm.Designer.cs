namespace Pizza.Forme
{
    partial class BrisanjeGovoriForm
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.upDownId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.upDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(142, 212);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 23);
            this.btnObrisi.TabIndex = 0;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(62, 72);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(47, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID veze:";
            // 
            // upDownId
            // 
            this.upDownId.Location = new System.Drawing.Point(142, 72);
            this.upDownId.Name = "upDownId";
            this.upDownId.Size = new System.Drawing.Size(100, 20);
            this.upDownId.TabIndex = 2;
            // 
            // BrisanjeGovoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 305);
            this.Controls.Add(this.upDownId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnObrisi);
            this.Name = "BrisanjeGovoriForm";
            this.Text = "BrisanjeGovoriForm";
            ((System.ComponentModel.ISupportInitialize)(this.upDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown upDownId;
    }
}
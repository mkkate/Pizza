namespace Pizza.Forme
{
    partial class BrisanjeRadiUForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.upDownId = new System.Windows.Forms.NumericUpDown();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.upDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(59, 76);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(45, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id veze:";
            // 
            // upDownId
            // 
            this.upDownId.Location = new System.Drawing.Point(130, 69);
            this.upDownId.Name = "upDownId";
            this.upDownId.Size = new System.Drawing.Size(94, 20);
            this.upDownId.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(130, 192);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(94, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // BrisanjeRadiUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 307);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.upDownId);
            this.Controls.Add(this.lblId);
            this.Name = "BrisanjeRadiUForm";
            this.Text = "BrisanjeRadiUForm";
            ((System.ComponentModel.ISupportInitialize)(this.upDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown upDownId;
        private System.Windows.Forms.Button btnObrisi;
    }
}
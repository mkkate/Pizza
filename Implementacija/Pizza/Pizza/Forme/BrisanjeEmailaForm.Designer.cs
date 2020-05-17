namespace Pizza.Forme
{
    partial class BrisanjeEmailaForm
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
            this.lblId.Location = new System.Drawing.Point(60, 72);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(54, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID emaila:";
            // 
            // upDownId
            // 
            this.upDownId.Location = new System.Drawing.Point(156, 72);
            this.upDownId.Name = "upDownId";
            this.upDownId.Size = new System.Drawing.Size(120, 20);
            this.upDownId.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(174, 194);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // BrisanjeEmailaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 318);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.upDownId);
            this.Controls.Add(this.lblId);
            this.Name = "BrisanjeEmailaForm";
            this.Text = "BrisanjeEmailaForm";
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
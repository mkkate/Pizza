namespace Pizza.Forme
{
    partial class BrisanjePorudzbineForm
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
            this.lblIdPorudzbine = new System.Windows.Forms.Label();
            this.nudIdPorudzbine = new System.Windows.Forms.NumericUpDown();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPorudzbine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdPorudzbine
            // 
            this.lblIdPorudzbine.AutoSize = true;
            this.lblIdPorudzbine.Location = new System.Drawing.Point(58, 33);
            this.lblIdPorudzbine.Name = "lblIdPorudzbine";
            this.lblIdPorudzbine.Size = new System.Drawing.Size(74, 13);
            this.lblIdPorudzbine.TabIndex = 0;
            this.lblIdPorudzbine.Text = "Id porudzbine:";
            // 
            // nudIdPorudzbine
            // 
            this.nudIdPorudzbine.Location = new System.Drawing.Point(158, 33);
            this.nudIdPorudzbine.Name = "nudIdPorudzbine";
            this.nudIdPorudzbine.Size = new System.Drawing.Size(79, 20);
            this.nudIdPorudzbine.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(94, 143);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // BrisanjePorudzbineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.nudIdPorudzbine);
            this.Controls.Add(this.lblIdPorudzbine);
            this.Name = "BrisanjePorudzbineForm";
            this.Text = "BrisanjePorudzbineForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdPorudzbine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdPorudzbine;
        private System.Windows.Forms.NumericUpDown nudIdPorudzbine;
        private System.Windows.Forms.Button btnObrisi;
    }
}
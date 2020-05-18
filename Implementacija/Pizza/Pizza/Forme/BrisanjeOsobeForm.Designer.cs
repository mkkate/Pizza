namespace Pizza.Forme
{
    partial class BrisanjeOsobeForm
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
            this.lblIdOsobe = new System.Windows.Forms.Label();
            this.nudIdOsobe = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdOsobe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(106, 146);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 0;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblIdOsobe
            // 
            this.lblIdOsobe.AutoSize = true;
            this.lblIdOsobe.Location = new System.Drawing.Point(52, 43);
            this.lblIdOsobe.Name = "lblIdOsobe";
            this.lblIdOsobe.Size = new System.Drawing.Size(51, 13);
            this.lblIdOsobe.TabIndex = 1;
            this.lblIdOsobe.Text = "Id osobe:";
            // 
            // nudIdOsobe
            // 
            this.nudIdOsobe.Location = new System.Drawing.Point(141, 43);
            this.nudIdOsobe.Name = "nudIdOsobe";
            this.nudIdOsobe.Size = new System.Drawing.Size(81, 20);
            this.nudIdOsobe.TabIndex = 2;
            // 
            // BrisanjeOsobeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nudIdOsobe);
            this.Controls.Add(this.lblIdOsobe);
            this.Controls.Add(this.btnObrisi);
            this.Name = "BrisanjeOsobeForm";
            this.Text = "BrisanjeOsobeForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdOsobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblIdOsobe;
        private System.Windows.Forms.NumericUpDown nudIdOsobe;
    }
}
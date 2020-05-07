namespace Pizza.Forme
{
    partial class BrisanjeVozilaForm
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
            this.lblIdVozila = new System.Windows.Forms.Label();
            this.nudIdVozila = new System.Windows.Forms.NumericUpDown();
            this.btnObrisiVozilo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdVozila
            // 
            this.lblIdVozila.AutoSize = true;
            this.lblIdVozila.Location = new System.Drawing.Point(42, 39);
            this.lblIdVozila.Name = "lblIdVozila";
            this.lblIdVozila.Size = new System.Drawing.Size(49, 13);
            this.lblIdVozila.TabIndex = 0;
            this.lblIdVozila.Text = "Id vozila:";
            // 
            // nudIdVozila
            // 
            this.nudIdVozila.Location = new System.Drawing.Point(120, 37);
            this.nudIdVozila.Name = "nudIdVozila";
            this.nudIdVozila.Size = new System.Drawing.Size(120, 20);
            this.nudIdVozila.TabIndex = 1;
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Location = new System.Drawing.Point(101, 137);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiVozilo.TabIndex = 2;
            this.btnObrisiVozilo.Text = "Obrisi vozilo";
            this.btnObrisiVozilo.UseVisualStyleBackColor = true;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // BrisanjeVozilaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnObrisiVozilo);
            this.Controls.Add(this.nudIdVozila);
            this.Controls.Add(this.lblIdVozila);
            this.Name = "BrisanjeVozilaForm";
            this.Text = "BrisanjeVozilaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdVozila;
        private System.Windows.Forms.NumericUpDown nudIdVozila;
        private System.Windows.Forms.Button btnObrisiVozilo;
    }
}
namespace Pizza.Forme
{
    partial class BrojTelefonaForm
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
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblIdOsobe = new System.Windows.Forms.Label();
            this.nudIdOsobe = new System.Windows.Forms.NumericUpDown();
            this.txtBrojTelefona = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdOsobe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.Location = new System.Drawing.Point(22, 30);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(69, 13);
            this.lblBrojTelefona.TabIndex = 0;
            this.lblBrojTelefona.Text = "Broj telefona:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(97, 189);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblIdOsobe
            // 
            this.lblIdOsobe.AutoSize = true;
            this.lblIdOsobe.Location = new System.Drawing.Point(25, 78);
            this.lblIdOsobe.Name = "lblIdOsobe";
            this.lblIdOsobe.Size = new System.Drawing.Size(51, 13);
            this.lblIdOsobe.TabIndex = 2;
            this.lblIdOsobe.Text = "Id osobe:";
            // 
            // nudIdOsobe
            // 
            this.nudIdOsobe.Location = new System.Drawing.Point(113, 78);
            this.nudIdOsobe.Name = "nudIdOsobe";
            this.nudIdOsobe.Size = new System.Drawing.Size(120, 20);
            this.nudIdOsobe.TabIndex = 4;
            // 
            // txtBrojTelefona
            // 
            this.txtBrojTelefona.Location = new System.Drawing.Point(113, 22);
            this.txtBrojTelefona.MaxLength = 10;
            this.txtBrojTelefona.Name = "txtBrojTelefona";
            this.txtBrojTelefona.Size = new System.Drawing.Size(120, 20);
            this.txtBrojTelefona.TabIndex = 5;
            // 
            // BrojTelefonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBrojTelefona);
            this.Controls.Add(this.nudIdOsobe);
            this.Controls.Add(this.lblIdOsobe);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblBrojTelefona);
            this.Name = "BrojTelefonaForm";
            this.Text = "BrojTelefonaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdOsobe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblIdOsobe;
        private System.Windows.Forms.NumericUpDown nudIdOsobe;
        private System.Windows.Forms.TextBox txtBrojTelefona;
    }
}
namespace Pizza.Forme
{
    partial class StraniJezikForm
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
            this.tbNazivJezika = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNazivJezika
            // 
            this.tbNazivJezika.Location = new System.Drawing.Point(111, 48);
            this.tbNazivJezika.Name = "tbNazivJezika";
            this.tbNazivJezika.Size = new System.Drawing.Size(170, 20);
            this.tbNazivJezika.TabIndex = 0;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(41, 51);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(40, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(111, 161);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(170, 30);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // StraniJezikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 264);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.tbNazivJezika);
            this.Name = "StraniJezikForm";
            this.Text = "StraniJezikForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNazivJezika;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnDodaj;
    }
}
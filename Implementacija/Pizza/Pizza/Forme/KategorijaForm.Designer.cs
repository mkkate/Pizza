namespace Pizza.Forme
{
    partial class KategorijaForm
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
            this.lblKategorijaDozvole = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbKategorija = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.UpDownId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKategorijaDozvole
            // 
            this.lblKategorijaDozvole.AutoSize = true;
            this.lblKategorijaDozvole.Location = new System.Drawing.Point(74, 63);
            this.lblKategorijaDozvole.Name = "lblKategorijaDozvole";
            this.lblKategorijaDozvole.Size = new System.Drawing.Size(57, 13);
            this.lblKategorijaDozvole.TabIndex = 0;
            this.lblKategorijaDozvole.Text = "Kategorija:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(74, 129);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID osobe:";
            // 
            // tbKategorija
            // 
            this.tbKategorija.Location = new System.Drawing.Point(188, 63);
            this.tbKategorija.Name = "tbKategorija";
            this.tbKategorija.Size = new System.Drawing.Size(100, 20);
            this.tbKategorija.TabIndex = 2;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(213, 233);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // UpDownId
            // 
            this.UpDownId.Location = new System.Drawing.Point(188, 129);
            this.UpDownId.Name = "UpDownId";
            this.UpDownId.Size = new System.Drawing.Size(120, 20);
            this.UpDownId.TabIndex = 5;
            // 
            // KategorijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 308);
            this.Controls.Add(this.UpDownId);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.tbKategorija);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblKategorijaDozvole);
            this.Name = "KategorijaForm";
            this.Text = "KategorijaForm";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKategorijaDozvole;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbKategorija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.NumericUpDown UpDownId;
    }
}
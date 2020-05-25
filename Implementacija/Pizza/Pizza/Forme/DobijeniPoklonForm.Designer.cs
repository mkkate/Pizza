namespace Pizza.Forme
{
    partial class DobijeniPoklonForm
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
            this.lblTip = new System.Windows.Forms.Label();
            this.lblIskoriscenje = new System.Windows.Forms.Label();
            this.lblBodovi = new System.Windows.Forms.Label();
            this.lblDodela = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.UpDownBodovi = new System.Windows.Forms.NumericUpDown();
            this.DtIskoriscenje = new System.Windows.Forms.DateTimePicker();
            this.dtDodela = new System.Windows.Forms.DateTimePicker();
            this.UpDownId = new System.Windows.Forms.NumericUpDown();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.cbNije = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBodovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(58, 49);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(66, 13);
            this.lblTip.TabIndex = 0;
            this.lblTip.Text = "Tip poklona:";
            // 
            // lblIskoriscenje
            // 
            this.lblIskoriscenje.AutoSize = true;
            this.lblIskoriscenje.Location = new System.Drawing.Point(58, 91);
            this.lblIskoriscenje.Name = "lblIskoriscenje";
            this.lblIskoriscenje.Size = new System.Drawing.Size(99, 13);
            this.lblIskoriscenje.TabIndex = 2;
            this.lblIskoriscenje.Text = "Datum iskoriscenja:";
            // 
            // lblBodovi
            // 
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Location = new System.Drawing.Point(58, 176);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(104, 13);
            this.lblBodovi.TabIndex = 3;
            this.lblBodovi.Text = "Kvalifikacioni bodovi";
            // 
            // lblDodela
            // 
            this.lblDodela.AutoSize = true;
            this.lblDodela.Location = new System.Drawing.Point(58, 231);
            this.lblDodela.Name = "lblDodela";
            this.lblDodela.Size = new System.Drawing.Size(76, 13);
            this.lblDodela.TabIndex = 4;
            this.lblDodela.Text = "Datum dodele:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(58, 273);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "ID osobe:";
            // 
            // UpDownBodovi
            // 
            this.UpDownBodovi.Location = new System.Drawing.Point(202, 169);
            this.UpDownBodovi.Name = "UpDownBodovi";
            this.UpDownBodovi.Size = new System.Drawing.Size(120, 20);
            this.UpDownBodovi.TabIndex = 6;
            // 
            // DtIskoriscenje
            // 
            this.DtIskoriscenje.Location = new System.Drawing.Point(202, 84);
            this.DtIskoriscenje.Name = "DtIskoriscenje";
            this.DtIskoriscenje.Size = new System.Drawing.Size(200, 20);
            this.DtIskoriscenje.TabIndex = 7;
            // 
            // dtDodela
            // 
            this.dtDodela.Location = new System.Drawing.Point(202, 224);
            this.dtDodela.Name = "dtDodela";
            this.dtDodela.Size = new System.Drawing.Size(200, 20);
            this.dtDodela.TabIndex = 8;
            // 
            // UpDownId
            // 
            this.UpDownId.Location = new System.Drawing.Point(202, 266);
            this.UpDownId.Name = "UpDownId";
            this.UpDownId.Size = new System.Drawing.Size(120, 20);
            this.UpDownId.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(359, 326);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(114, 23);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbTip
            // 
            this.cbTip.Items.AddRange(new object[] {
            "popust",
            "poklon pizza"});
            this.cbTip.Location = new System.Drawing.Point(202, 41);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(121, 21);
            this.cbTip.TabIndex = 13;
            this.cbTip.Text = "Odaberi tip";
            // 
            // cbNije
            // 
            this.cbNije.AutoSize = true;
            this.cbNije.Location = new System.Drawing.Point(202, 121);
            this.cbNije.Name = "cbNije";
            this.cbNije.Size = new System.Drawing.Size(171, 17);
            this.cbNije.TabIndex = 14;
            this.cbNije.Text = "Poklon jos uvek nije iskoriscen";
            this.cbNije.UseVisualStyleBackColor = true;
            // 
            // DobijeniPoklonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 373);
            this.Controls.Add(this.cbNije);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.UpDownId);
            this.Controls.Add(this.dtDodela);
            this.Controls.Add(this.DtIskoriscenje);
            this.Controls.Add(this.UpDownBodovi);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblDodela);
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.lblIskoriscenje);
            this.Controls.Add(this.lblTip);
            this.Name = "DobijeniPoklonForm";
            this.Text = "DobijeniPoklonForm";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBodovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblIskoriscenje;
        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.Label lblDodela;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown UpDownBodovi;
        private System.Windows.Forms.DateTimePicker DtIskoriscenje;
        private System.Windows.Forms.DateTimePicker dtDodela;
        private System.Windows.Forms.NumericUpDown UpDownId;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.CheckBox cbNije;
    }
}
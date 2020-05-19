namespace Pizza.Forme
{
    partial class PorudzbinaForm
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
            this.lblCena = new System.Windows.Forms.Label();
            this.lblNacinPlacanja = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDatumVremeKreiranja = new System.Windows.Forms.Label();
            this.lblIdOsobe = new System.Windows.Forms.Label();
            this.lblIdVozila = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDatumVremeKreiranja = new System.Windows.Forms.DateTimePicker();
            this.nudIdOsobe = new System.Windows.Forms.NumericUpDown();
            this.nudIdVozila = new System.Windows.Forms.NumericUpDown();
            this.lblPicaId = new System.Windows.Forms.Label();
            this.nudPicaId = new System.Windows.Forms.NumericUpDown();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblObracunataCena = new System.Windows.Forms.Label();
            this.lblSastojci = new System.Windows.Forms.Label();
            this.txtSastojci = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdOsobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPicaId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(115, 243);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(35, 13);
            this.lblCena.TabIndex = 0;
            this.lblCena.Text = "Cena:";
            // 
            // lblNacinPlacanja
            // 
            this.lblNacinPlacanja.AutoSize = true;
            this.lblNacinPlacanja.Location = new System.Drawing.Point(26, 38);
            this.lblNacinPlacanja.Name = "lblNacinPlacanja";
            this.lblNacinPlacanja.Size = new System.Drawing.Size(81, 13);
            this.lblNacinPlacanja.TabIndex = 1;
            this.lblNacinPlacanja.Text = "Nacin placanja:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(29, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // lblDatumVremeKreiranja
            // 
            this.lblDatumVremeKreiranja.AutoSize = true;
            this.lblDatumVremeKreiranja.Location = new System.Drawing.Point(29, 114);
            this.lblDatumVremeKreiranja.Name = "lblDatumVremeKreiranja";
            this.lblDatumVremeKreiranja.Size = new System.Drawing.Size(121, 13);
            this.lblDatumVremeKreiranja.TabIndex = 3;
            this.lblDatumVremeKreiranja.Text = "Datum i vreme kreiranja:";
            // 
            // lblIdOsobe
            // 
            this.lblIdOsobe.AutoSize = true;
            this.lblIdOsobe.Location = new System.Drawing.Point(29, 156);
            this.lblIdOsobe.Name = "lblIdOsobe";
            this.lblIdOsobe.Size = new System.Drawing.Size(51, 13);
            this.lblIdOsobe.TabIndex = 4;
            this.lblIdOsobe.Text = "Id osobe:";
            // 
            // lblIdVozila
            // 
            this.lblIdVozila.AutoSize = true;
            this.lblIdVozila.Location = new System.Drawing.Point(29, 191);
            this.lblIdVozila.Name = "lblIdVozila";
            this.lblIdVozila.Size = new System.Drawing.Size(49, 13);
            this.lblIdVozila.TabIndex = 5;
            this.lblIdVozila.Text = "Id vozila:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(148, 292);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cmbNacinPlacanja
            // 
            this.cmbNacinPlacanja.FormattingEnabled = true;
            this.cmbNacinPlacanja.Location = new System.Drawing.Point(185, 29);
            this.cmbNacinPlacanja.Name = "cmbNacinPlacanja";
            this.cmbNacinPlacanja.Size = new System.Drawing.Size(121, 21);
            this.cmbNacinPlacanja.TabIndex = 8;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(185, 68);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 9;
            // 
            // dtpDatumVremeKreiranja
            // 
            this.dtpDatumVremeKreiranja.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDatumVremeKreiranja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumVremeKreiranja.Location = new System.Drawing.Point(185, 106);
            this.dtpDatumVremeKreiranja.Name = "dtpDatumVremeKreiranja";
            this.dtpDatumVremeKreiranja.Size = new System.Drawing.Size(121, 20);
            this.dtpDatumVremeKreiranja.TabIndex = 10;
            // 
            // nudIdOsobe
            // 
            this.nudIdOsobe.Location = new System.Drawing.Point(185, 148);
            this.nudIdOsobe.Name = "nudIdOsobe";
            this.nudIdOsobe.Size = new System.Drawing.Size(120, 20);
            this.nudIdOsobe.TabIndex = 12;
            // 
            // nudIdVozila
            // 
            this.nudIdVozila.Location = new System.Drawing.Point(185, 183);
            this.nudIdVozila.Name = "nudIdVozila";
            this.nudIdVozila.Size = new System.Drawing.Size(120, 20);
            this.nudIdVozila.TabIndex = 13;
            // 
            // lblPicaId
            // 
            this.lblPicaId.AutoSize = true;
            this.lblPicaId.Location = new System.Drawing.Point(349, 37);
            this.lblPicaId.Name = "lblPicaId";
            this.lblPicaId.Size = new System.Drawing.Size(43, 13);
            this.lblPicaId.TabIndex = 14;
            this.lblPicaId.Text = "Pica Id:";
            // 
            // nudPicaId
            // 
            this.nudPicaId.Location = new System.Drawing.Point(428, 29);
            this.nudPicaId.Name = "nudPicaId";
            this.nudPicaId.Size = new System.Drawing.Size(100, 20);
            this.nudPicaId.TabIndex = 15;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(349, 72);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(47, 13);
            this.lblKolicina.TabIndex = 16;
            this.lblKolicina.Text = "Kolicina:";
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(428, 66);
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(100, 20);
            this.nudKolicina.TabIndex = 17;
            // 
            // lblObracunataCena
            // 
            this.lblObracunataCena.AutoSize = true;
            this.lblObracunataCena.Location = new System.Drawing.Point(177, 243);
            this.lblObracunataCena.Name = "lblObracunataCena";
            this.lblObracunataCena.Size = new System.Drawing.Size(45, 13);
            this.lblObracunataCena.TabIndex = 18;
            this.lblObracunataCena.Text = "Ukupno";
            // 
            // lblSastojci
            // 
            this.lblSastojci.AutoSize = true;
            this.lblSastojci.Location = new System.Drawing.Point(349, 111);
            this.lblSastojci.Name = "lblSastojci";
            this.lblSastojci.Size = new System.Drawing.Size(47, 13);
            this.lblSastojci.TabIndex = 19;
            this.lblSastojci.Text = "Sastojci:";
            // 
            // txtSastojci
            // 
            this.txtSastojci.Location = new System.Drawing.Point(428, 104);
            this.txtSastojci.Name = "txtSastojci";
            this.txtSastojci.Size = new System.Drawing.Size(100, 20);
            this.txtSastojci.TabIndex = 20;
            // 
            // PorudzbinaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 387);
            this.Controls.Add(this.txtSastojci);
            this.Controls.Add(this.lblSastojci);
            this.Controls.Add(this.lblObracunataCena);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.nudPicaId);
            this.Controls.Add(this.lblPicaId);
            this.Controls.Add(this.nudIdVozila);
            this.Controls.Add(this.nudIdOsobe);
            this.Controls.Add(this.dtpDatumVremeKreiranja);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbNacinPlacanja);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblIdVozila);
            this.Controls.Add(this.lblIdOsobe);
            this.Controls.Add(this.lblDatumVremeKreiranja);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNacinPlacanja);
            this.Controls.Add(this.lblCena);
            this.Name = "PorudzbinaForm";
            this.Text = "PorudzbinaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdOsobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPicaId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblNacinPlacanja;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDatumVremeKreiranja;
        private System.Windows.Forms.Label lblIdOsobe;
        private System.Windows.Forms.Label lblIdVozila;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbNacinPlacanja;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpDatumVremeKreiranja;
        private System.Windows.Forms.NumericUpDown nudIdOsobe;
        private System.Windows.Forms.NumericUpDown nudIdVozila;
        private System.Windows.Forms.Label lblPicaId;
        private System.Windows.Forms.NumericUpDown nudPicaId;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Label lblObracunataCena;
        private System.Windows.Forms.Label lblSastojci;
        private System.Windows.Forms.TextBox txtSastojci;
    }
}
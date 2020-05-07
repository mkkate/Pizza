namespace Pizza.Forme
{
    partial class VoziloForm
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
            this.btnDodajVozilo = new System.Windows.Forms.Button();
            this.lblNazivTipa = new System.Windows.Forms.Label();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.rdbAutomobil = new System.Windows.Forms.RadioButton();
            this.lblTipVozila = new System.Windows.Forms.Label();
            this.rdbSkuter = new System.Windows.Forms.RadioButton();
            this.rdbBicikl = new System.Windows.Forms.RadioButton();
            this.lblVelicinaRama = new System.Windows.Forms.Label();
            this.nudVelicinaRama = new System.Windows.Forms.NumericUpDown();
            this.lblRegistarskiBroj = new System.Windows.Forms.Label();
            this.lblBrSaobracanjeDozvole = new System.Windows.Forms.Label();
            this.txtRegistarskiBroj = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtNazivTipa = new System.Windows.Forms.TextBox();
            this.nudBrSaobracajneDozvole = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudVelicinaRama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrSaobracajneDozvole)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajVozilo
            // 
            this.btnDodajVozilo.Location = new System.Drawing.Point(95, 268);
            this.btnDodajVozilo.Name = "btnDodajVozilo";
            this.btnDodajVozilo.Size = new System.Drawing.Size(75, 23);
            this.btnDodajVozilo.TabIndex = 0;
            this.btnDodajVozilo.Text = "Dodaj";
            this.btnDodajVozilo.UseVisualStyleBackColor = true;
            this.btnDodajVozilo.Click += new System.EventHandler(this.btnDodajVozilo_Click);
            // 
            // lblNazivTipa
            // 
            this.lblNazivTipa.AutoSize = true;
            this.lblNazivTipa.Location = new System.Drawing.Point(13, 25);
            this.lblNazivTipa.Name = "lblNazivTipa";
            this.lblNazivTipa.Size = new System.Drawing.Size(57, 13);
            this.lblNazivTipa.TabIndex = 1;
            this.lblNazivTipa.Text = "Naziv tipa:";
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(13, 60);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(65, 13);
            this.lblProizvodjac.TabIndex = 2;
            this.lblProizvodjac.Text = "Proizvodjac:";
            // 
            // rdbAutomobil
            // 
            this.rdbAutomobil.AutoSize = true;
            this.rdbAutomobil.Location = new System.Drawing.Point(115, 86);
            this.rdbAutomobil.Name = "rdbAutomobil";
            this.rdbAutomobil.Size = new System.Drawing.Size(71, 17);
            this.rdbAutomobil.TabIndex = 3;
            this.rdbAutomobil.TabStop = true;
            this.rdbAutomobil.Text = "Automobil";
            this.rdbAutomobil.UseVisualStyleBackColor = true;
            this.rdbAutomobil.CheckedChanged += new System.EventHandler(this.rdbAutomobil_CheckedChanged);
            // 
            // lblTipVozila
            // 
            this.lblTipVozila.AutoSize = true;
            this.lblTipVozila.Location = new System.Drawing.Point(13, 88);
            this.lblTipVozila.Name = "lblTipVozila";
            this.lblTipVozila.Size = new System.Drawing.Size(55, 13);
            this.lblTipVozila.TabIndex = 4;
            this.lblTipVozila.Text = "Tip vozila:";
            // 
            // rdbSkuter
            // 
            this.rdbSkuter.AutoSize = true;
            this.rdbSkuter.Location = new System.Drawing.Point(115, 110);
            this.rdbSkuter.Name = "rdbSkuter";
            this.rdbSkuter.Size = new System.Drawing.Size(56, 17);
            this.rdbSkuter.TabIndex = 5;
            this.rdbSkuter.TabStop = true;
            this.rdbSkuter.Text = "Skuter";
            this.rdbSkuter.UseVisualStyleBackColor = true;
            this.rdbSkuter.CheckedChanged += new System.EventHandler(this.rdbSkuter_CheckedChanged);
            // 
            // rdbBicikl
            // 
            this.rdbBicikl.AutoSize = true;
            this.rdbBicikl.Location = new System.Drawing.Point(115, 134);
            this.rdbBicikl.Name = "rdbBicikl";
            this.rdbBicikl.Size = new System.Drawing.Size(50, 17);
            this.rdbBicikl.TabIndex = 6;
            this.rdbBicikl.TabStop = true;
            this.rdbBicikl.Text = "Bicikl";
            this.rdbBicikl.UseVisualStyleBackColor = true;
            this.rdbBicikl.CheckedChanged += new System.EventHandler(this.rdbBicikl_CheckedChanged);
            // 
            // lblVelicinaRama
            // 
            this.lblVelicinaRama.AutoSize = true;
            this.lblVelicinaRama.Location = new System.Drawing.Point(13, 169);
            this.lblVelicinaRama.Name = "lblVelicinaRama";
            this.lblVelicinaRama.Size = new System.Drawing.Size(73, 13);
            this.lblVelicinaRama.TabIndex = 7;
            this.lblVelicinaRama.Text = "Velicina rama:";
            // 
            // nudVelicinaRama
            // 
            this.nudVelicinaRama.Location = new System.Drawing.Point(148, 167);
            this.nudVelicinaRama.Minimum = new decimal(new int[] {
            44,
            0,
            0,
            0});
            this.nudVelicinaRama.Name = "nudVelicinaRama";
            this.nudVelicinaRama.Size = new System.Drawing.Size(121, 20);
            this.nudVelicinaRama.TabIndex = 8;
            this.nudVelicinaRama.Value = new decimal(new int[] {
            44,
            0,
            0,
            0});
            // 
            // lblRegistarskiBroj
            // 
            this.lblRegistarskiBroj.AutoSize = true;
            this.lblRegistarskiBroj.Location = new System.Drawing.Point(13, 198);
            this.lblRegistarskiBroj.Name = "lblRegistarskiBroj";
            this.lblRegistarskiBroj.Size = new System.Drawing.Size(82, 13);
            this.lblRegistarskiBroj.TabIndex = 9;
            this.lblRegistarskiBroj.Text = "Registarski broj:";
            // 
            // lblBrSaobracanjeDozvole
            // 
            this.lblBrSaobracanjeDozvole.AutoSize = true;
            this.lblBrSaobracanjeDozvole.Location = new System.Drawing.Point(13, 229);
            this.lblBrSaobracanjeDozvole.Name = "lblBrSaobracanjeDozvole";
            this.lblBrSaobracanjeDozvole.Size = new System.Drawing.Size(129, 13);
            this.lblBrSaobracanjeDozvole.TabIndex = 10;
            this.lblBrSaobracanjeDozvole.Text = "Broj saobracajne dozvole:";
            // 
            // txtRegistarskiBroj
            // 
            this.txtRegistarskiBroj.Location = new System.Drawing.Point(148, 195);
            this.txtRegistarskiBroj.Name = "txtRegistarskiBroj";
            this.txtRegistarskiBroj.Size = new System.Drawing.Size(121, 20);
            this.txtRegistarskiBroj.TabIndex = 12;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(115, 60);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(100, 20);
            this.txtProizvodjac.TabIndex = 13;
            // 
            // txtNazivTipa
            // 
            this.txtNazivTipa.Location = new System.Drawing.Point(115, 25);
            this.txtNazivTipa.Name = "txtNazivTipa";
            this.txtNazivTipa.Size = new System.Drawing.Size(100, 20);
            this.txtNazivTipa.TabIndex = 14;
            // 
            // nudBrSaobracajneDozvole
            // 
            this.nudBrSaobracajneDozvole.Location = new System.Drawing.Point(148, 229);
            this.nudBrSaobracajneDozvole.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudBrSaobracajneDozvole.Name = "nudBrSaobracajneDozvole";
            this.nudBrSaobracajneDozvole.Size = new System.Drawing.Size(121, 20);
            this.nudBrSaobracajneDozvole.TabIndex = 15;
            // 
            // VoziloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 303);
            this.Controls.Add(this.nudBrSaobracajneDozvole);
            this.Controls.Add(this.txtNazivTipa);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtRegistarskiBroj);
            this.Controls.Add(this.lblBrSaobracanjeDozvole);
            this.Controls.Add(this.lblRegistarskiBroj);
            this.Controls.Add(this.nudVelicinaRama);
            this.Controls.Add(this.lblVelicinaRama);
            this.Controls.Add(this.rdbBicikl);
            this.Controls.Add(this.rdbSkuter);
            this.Controls.Add(this.lblTipVozila);
            this.Controls.Add(this.rdbAutomobil);
            this.Controls.Add(this.lblProizvodjac);
            this.Controls.Add(this.lblNazivTipa);
            this.Controls.Add(this.btnDodajVozilo);
            this.Name = "VoziloForm";
            this.Text = "Vozila";
            ((System.ComponentModel.ISupportInitialize)(this.nudVelicinaRama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrSaobracajneDozvole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajVozilo;
        private System.Windows.Forms.Label lblNazivTipa;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.RadioButton rdbAutomobil;
        private System.Windows.Forms.Label lblTipVozila;
        private System.Windows.Forms.RadioButton rdbSkuter;
        private System.Windows.Forms.RadioButton rdbBicikl;
        private System.Windows.Forms.Label lblVelicinaRama;
        private System.Windows.Forms.NumericUpDown nudVelicinaRama;
        private System.Windows.Forms.Label lblRegistarskiBroj;
        private System.Windows.Forms.Label lblBrSaobracanjeDozvole;
        private System.Windows.Forms.TextBox txtRegistarskiBroj;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtNazivTipa;
        private System.Windows.Forms.NumericUpDown nudBrSaobracajneDozvole;
    }
}
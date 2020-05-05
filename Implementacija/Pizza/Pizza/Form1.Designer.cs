namespace Pizza
{
    partial class Form1
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
            this.btnUcitavanjeVozila = new System.Windows.Forms.Button();
            this.btnDodavanjeNovogVozila = new System.Windows.Forms.Button();
            this.btnUcitavanjeSmene = new System.Windows.Forms.Button();
            this.btnUcitajTPHInheritance = new System.Windows.Forms.Button();
            this.btnGetVozilo = new System.Windows.Forms.Button();
            this.groupBoxVozila = new System.Windows.Forms.GroupBox();
            this.groupBoxSmene = new System.Windows.Forms.GroupBox();
            this.groupBoxNasledjivanja = new System.Windows.Forms.GroupBox();
            this.btnObrisiVozilo = new System.Windows.Forms.Button();
            this.btnDodavanjeSmene = new System.Windows.Forms.Button();
            this.btnObrisiSmenu = new System.Windows.Forms.Button();
            this.groupBoxVozila.SuspendLayout();
            this.groupBoxSmene.SuspendLayout();
            this.groupBoxNasledjivanja.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUcitavanjeVozila
            // 
            this.btnUcitavanjeVozila.Location = new System.Drawing.Point(24, 32);
            this.btnUcitavanjeVozila.Name = "btnUcitavanjeVozila";
            this.btnUcitavanjeVozila.Size = new System.Drawing.Size(143, 23);
            this.btnUcitavanjeVozila.TabIndex = 0;
            this.btnUcitavanjeVozila.Text = "Ucitavanje vozila";
            this.btnUcitavanjeVozila.UseVisualStyleBackColor = true;
            this.btnUcitavanjeVozila.Click += new System.EventHandler(this.btnUcitavanjeVozila_Click);
            // 
            // btnDodavanjeNovogVozila
            // 
            this.btnDodavanjeNovogVozila.Location = new System.Drawing.Point(24, 82);
            this.btnDodavanjeNovogVozila.Name = "btnDodavanjeNovogVozila";
            this.btnDodavanjeNovogVozila.Size = new System.Drawing.Size(143, 23);
            this.btnDodavanjeNovogVozila.TabIndex = 1;
            this.btnDodavanjeNovogVozila.Text = "Dodavanje novog vozila";
            this.btnDodavanjeNovogVozila.UseVisualStyleBackColor = true;
            this.btnDodavanjeNovogVozila.Click += new System.EventHandler(this.btnDodavanjeNovogVozila_Click);
            // 
            // btnUcitavanjeSmene
            // 
            this.btnUcitavanjeSmene.Location = new System.Drawing.Point(15, 27);
            this.btnUcitavanjeSmene.Name = "btnUcitavanjeSmene";
            this.btnUcitavanjeSmene.Size = new System.Drawing.Size(143, 23);
            this.btnUcitavanjeSmene.TabIndex = 2;
            this.btnUcitavanjeSmene.Text = "Ucitavanje smene";
            this.btnUcitavanjeSmene.UseVisualStyleBackColor = true;
            this.btnUcitavanjeSmene.Click += new System.EventHandler(this.btnUcitavanjeSmene_Click);
            // 
            // btnUcitajTPHInheritance
            // 
            this.btnUcitajTPHInheritance.Location = new System.Drawing.Point(15, 29);
            this.btnUcitajTPHInheritance.Name = "btnUcitajTPHInheritance";
            this.btnUcitajTPHInheritance.Size = new System.Drawing.Size(143, 23);
            this.btnUcitajTPHInheritance.TabIndex = 3;
            this.btnUcitajTPHInheritance.Text = "Ucitaj TPH inheritance";
            this.btnUcitajTPHInheritance.UseVisualStyleBackColor = true;
            this.btnUcitajTPHInheritance.Click += new System.EventHandler(this.btnUcitajTPHInheritance_Click);
            // 
            // btnGetVozilo
            // 
            this.btnGetVozilo.Location = new System.Drawing.Point(24, 127);
            this.btnGetVozilo.Name = "btnGetVozilo";
            this.btnGetVozilo.Size = new System.Drawing.Size(143, 23);
            this.btnGetVozilo.TabIndex = 4;
            this.btnGetVozilo.Text = "Get vozilo";
            this.btnGetVozilo.UseVisualStyleBackColor = true;
            this.btnGetVozilo.Click += new System.EventHandler(this.btnGetVozilo_Click);
            // 
            // groupBoxVozila
            // 
            this.groupBoxVozila.Controls.Add(this.btnObrisiVozilo);
            this.groupBoxVozila.Controls.Add(this.btnGetVozilo);
            this.groupBoxVozila.Controls.Add(this.btnUcitavanjeVozila);
            this.groupBoxVozila.Controls.Add(this.btnDodavanjeNovogVozila);
            this.groupBoxVozila.Location = new System.Drawing.Point(27, 12);
            this.groupBoxVozila.Name = "groupBoxVozila";
            this.groupBoxVozila.Size = new System.Drawing.Size(193, 201);
            this.groupBoxVozila.TabIndex = 5;
            this.groupBoxVozila.TabStop = false;
            this.groupBoxVozila.Text = "Vozila";
            // 
            // groupBoxSmene
            // 
            this.groupBoxSmene.Controls.Add(this.btnObrisiSmenu);
            this.groupBoxSmene.Controls.Add(this.btnDodavanjeSmene);
            this.groupBoxSmene.Controls.Add(this.btnUcitavanjeSmene);
            this.groupBoxSmene.Location = new System.Drawing.Point(236, 17);
            this.groupBoxSmene.Name = "groupBoxSmene";
            this.groupBoxSmene.Size = new System.Drawing.Size(200, 183);
            this.groupBoxSmene.TabIndex = 6;
            this.groupBoxSmene.TabStop = false;
            this.groupBoxSmene.Text = "Smene";
            // 
            // groupBoxNasledjivanja
            // 
            this.groupBoxNasledjivanja.Controls.Add(this.btnUcitajTPHInheritance);
            this.groupBoxNasledjivanja.Location = new System.Drawing.Point(236, 215);
            this.groupBoxNasledjivanja.Name = "groupBoxNasledjivanja";
            this.groupBoxNasledjivanja.Size = new System.Drawing.Size(200, 100);
            this.groupBoxNasledjivanja.TabIndex = 7;
            this.groupBoxNasledjivanja.TabStop = false;
            this.groupBoxNasledjivanja.Text = "Nasledjivanja";
            // 
            // btnObrisiVozilo
            // 
            this.btnObrisiVozilo.Location = new System.Drawing.Point(24, 168);
            this.btnObrisiVozilo.Name = "btnObrisiVozilo";
            this.btnObrisiVozilo.Size = new System.Drawing.Size(143, 23);
            this.btnObrisiVozilo.TabIndex = 5;
            this.btnObrisiVozilo.Text = "Obrisi vozilo";
            this.btnObrisiVozilo.UseVisualStyleBackColor = true;
            this.btnObrisiVozilo.Click += new System.EventHandler(this.btnObrisiVozilo_Click);
            // 
            // btnDodavanjeSmene
            // 
            this.btnDodavanjeSmene.Location = new System.Drawing.Point(15, 77);
            this.btnDodavanjeSmene.Name = "btnDodavanjeSmene";
            this.btnDodavanjeSmene.Size = new System.Drawing.Size(143, 23);
            this.btnDodavanjeSmene.TabIndex = 3;
            this.btnDodavanjeSmene.Text = "Dodavanje smene";
            this.btnDodavanjeSmene.UseVisualStyleBackColor = true;
            this.btnDodavanjeSmene.Click += new System.EventHandler(this.btnDodavanjeSmene_Click);
            // 
            // btnObrisiSmenu
            // 
            this.btnObrisiSmenu.Location = new System.Drawing.Point(15, 122);
            this.btnObrisiSmenu.Name = "btnObrisiSmenu";
            this.btnObrisiSmenu.Size = new System.Drawing.Size(143, 23);
            this.btnObrisiSmenu.TabIndex = 4;
            this.btnObrisiSmenu.Text = "Obrisi smenu";
            this.btnObrisiSmenu.UseVisualStyleBackColor = true;
            this.btnObrisiSmenu.Click += new System.EventHandler(this.btnObrisiSmenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 340);
            this.Controls.Add(this.groupBoxNasledjivanja);
            this.Controls.Add(this.groupBoxVozila);
            this.Controls.Add(this.groupBoxSmene);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxVozila.ResumeLayout(false);
            this.groupBoxSmene.ResumeLayout(false);
            this.groupBoxNasledjivanja.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitavanjeVozila;
        private System.Windows.Forms.Button btnDodavanjeNovogVozila;
        private System.Windows.Forms.Button btnUcitavanjeSmene;
        private System.Windows.Forms.Button btnUcitajTPHInheritance;
        private System.Windows.Forms.Button btnGetVozilo;
        private System.Windows.Forms.GroupBox groupBoxVozila;
        private System.Windows.Forms.GroupBox groupBoxSmene;
        private System.Windows.Forms.GroupBox groupBoxNasledjivanja;
        private System.Windows.Forms.Button btnObrisiVozilo;
        private System.Windows.Forms.Button btnDodavanjeSmene;
        private System.Windows.Forms.Button btnObrisiSmenu;
    }
}


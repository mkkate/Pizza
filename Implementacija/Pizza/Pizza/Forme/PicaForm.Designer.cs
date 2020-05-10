namespace Pizza.Forme
{
    partial class PicaForm
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
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.btnDodavanjePice = new System.Windows.Forms.Button();
            this.lblNazivPice = new System.Windows.Forms.Label();
            this.lblCena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(107, 37);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(157, 20);
            this.tbNaziv.TabIndex = 0;
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(109, 81);
            this.tbCena.Name = "tbCena";
            this.tbCena.Size = new System.Drawing.Size(154, 20);
            this.tbCena.TabIndex = 1;
            // 
            // btnDodavanjePice
            // 
            this.btnDodavanjePice.Location = new System.Drawing.Point(116, 169);
            this.btnDodavanjePice.Name = "btnDodavanjePice";
            this.btnDodavanjePice.Size = new System.Drawing.Size(146, 27);
            this.btnDodavanjePice.TabIndex = 2;
            this.btnDodavanjePice.Text = "Dodaj";
            this.btnDodavanjePice.UseVisualStyleBackColor = true;
            this.btnDodavanjePice.Click += new System.EventHandler(this.btnDodavanjePice_Click);
            // 
            // lblNazivPice
            // 
            this.lblNazivPice.AutoSize = true;
            this.lblNazivPice.Location = new System.Drawing.Point(27, 44);
            this.lblNazivPice.Name = "lblNazivPice";
            this.lblNazivPice.Size = new System.Drawing.Size(37, 13);
            this.lblNazivPice.TabIndex = 3;
            this.lblNazivPice.Text = "Naziv:";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(27, 88);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(35, 13);
            this.lblCena.TabIndex = 4;
            this.lblCena.Text = "Cena:";
            // 
            // PicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 269);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.lblNazivPice);
            this.Controls.Add(this.btnDodavanjePice);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.tbNaziv);
            this.Name = "PicaForm";
            this.Text = "PicaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.Button btnDodavanjePice;
        private System.Windows.Forms.Label lblNazivPice;
        private System.Windows.Forms.Label lblCena;
    }
}
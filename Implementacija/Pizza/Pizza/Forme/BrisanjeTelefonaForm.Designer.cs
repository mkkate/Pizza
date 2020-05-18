namespace Pizza.Forme
{
    partial class BrisanjeTelefonaForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudIdBrojaTelefona = new System.Windows.Forms.NumericUpDown();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdBrojaTelefona)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id broja telefona:";
            // 
            // nudIdBrojaTelefona
            // 
            this.nudIdBrojaTelefona.Location = new System.Drawing.Point(148, 37);
            this.nudIdBrojaTelefona.Name = "nudIdBrojaTelefona";
            this.nudIdBrojaTelefona.Size = new System.Drawing.Size(101, 20);
            this.nudIdBrojaTelefona.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(89, 134);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // BrisanjeTelefonaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.nudIdBrojaTelefona);
            this.Controls.Add(this.label1);
            this.Name = "BrisanjeTelefonaForm";
            this.Text = "BrisanjeTelefonaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdBrojaTelefona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudIdBrojaTelefona;
        private System.Windows.Forms.Button btnObrisi;
    }
}
namespace Pizza.Forme
{
    partial class BrisanjeSmeneForm
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
            this.lblIdSmene = new System.Windows.Forms.Label();
            this.nudIdSmene = new System.Windows.Forms.NumericUpDown();
            this.btnObrisiSmenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdSmene)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdSmene
            // 
            this.lblIdSmene.AutoSize = true;
            this.lblIdSmene.Location = new System.Drawing.Point(43, 47);
            this.lblIdSmene.Name = "lblIdSmene";
            this.lblIdSmene.Size = new System.Drawing.Size(53, 13);
            this.lblIdSmene.TabIndex = 0;
            this.lblIdSmene.Text = "Id smene:";
            // 
            // nudIdSmene
            // 
            this.nudIdSmene.Location = new System.Drawing.Point(121, 47);
            this.nudIdSmene.Name = "nudIdSmene";
            this.nudIdSmene.Size = new System.Drawing.Size(93, 20);
            this.nudIdSmene.TabIndex = 1;
            // 
            // btnObrisiSmenu
            // 
            this.btnObrisiSmenu.Location = new System.Drawing.Point(91, 135);
            this.btnObrisiSmenu.Name = "btnObrisiSmenu";
            this.btnObrisiSmenu.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiSmenu.TabIndex = 2;
            this.btnObrisiSmenu.Text = "Obrisi smenu";
            this.btnObrisiSmenu.UseVisualStyleBackColor = true;
            this.btnObrisiSmenu.Click += new System.EventHandler(this.btnObrisiSmenu_Click);
            // 
            // BrisanjeSmeneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnObrisiSmenu);
            this.Controls.Add(this.nudIdSmene);
            this.Controls.Add(this.lblIdSmene);
            this.Name = "BrisanjeSmeneForm";
            this.Text = "Brisanje smene";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdSmene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdSmene;
        private System.Windows.Forms.NumericUpDown nudIdSmene;
        private System.Windows.Forms.Button btnObrisiSmenu;
    }
}
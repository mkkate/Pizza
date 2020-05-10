namespace Pizza.Forme
{
    partial class BrisanjeJezikaForm
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
            this.updownId = new System.Windows.Forms.NumericUpDown();
            this.lblId = new System.Windows.Forms.Label();
            this.btnBrisanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updownId)).BeginInit();
            this.SuspendLayout();
            // 
            // updownId
            // 
            this.updownId.Location = new System.Drawing.Point(160, 36);
            this.updownId.Name = "updownId";
            this.updownId.Size = new System.Drawing.Size(133, 20);
            this.updownId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(56, 38);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(87, 13);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id stranog jezika:";
            // 
            // btnBrisanje
            // 
            this.btnBrisanje.Location = new System.Drawing.Point(160, 170);
            this.btnBrisanje.Name = "btnBrisanje";
            this.btnBrisanje.Size = new System.Drawing.Size(133, 29);
            this.btnBrisanje.TabIndex = 2;
            this.btnBrisanje.Text = "Obrisi";
            this.btnBrisanje.UseVisualStyleBackColor = true;
            this.btnBrisanje.Click += new System.EventHandler(this.btnBrisanje_Click);
            // 
            // BrisanjeJezikaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 246);
            this.Controls.Add(this.btnBrisanje);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.updownId);
            this.Name = "BrisanjeJezikaForm";
            this.Text = "BrisanjeJezikaForm";
            ((System.ComponentModel.ISupportInitialize)(this.updownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown updownId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnBrisanje;
    }
}
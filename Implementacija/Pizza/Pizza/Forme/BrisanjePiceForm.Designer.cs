﻿namespace Pizza.Forme
{
    partial class BrisanjePiceForm
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.updownId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.updownId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(131, 152);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(146, 29);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(56, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id pice";
            // 
            // updownId
            // 
            this.updownId.Location = new System.Drawing.Point(131, 54);
            this.updownId.Name = "updownId";
            this.updownId.Size = new System.Drawing.Size(145, 20);
            this.updownId.TabIndex = 3;
            // 
            // BrisanjePiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 269);
            this.Controls.Add(this.updownId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnObrisi);
            this.Name = "BrisanjePiceForm";
            this.Text = "BrisanjePiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.updownId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown updownId;
    }
}
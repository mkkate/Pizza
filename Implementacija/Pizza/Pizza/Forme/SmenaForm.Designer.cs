namespace Pizza.Forme
{
    partial class SmenaForm
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
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.btnDodajSmenu = new System.Windows.Forms.Button();
            this.lblTipSmene = new System.Windows.Forms.Label();
            this.nudTipSmene = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudTipSmene)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.CustomFormat = "dd.MM.yyyy";
            this.dtpDatumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatumOd.Location = new System.Drawing.Point(129, 37);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDatumOd.Size = new System.Drawing.Size(106, 20);
            this.dtpDatumOd.TabIndex = 0;
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.Location = new System.Drawing.Point(32, 44);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(56, 13);
            this.lblDatumOd.TabIndex = 1;
            this.lblDatumOd.Text = "Datum od:";
            // 
            // btnDodajSmenu
            // 
            this.btnDodajSmenu.Location = new System.Drawing.Point(35, 153);
            this.btnDodajSmenu.Name = "btnDodajSmenu";
            this.btnDodajSmenu.Size = new System.Drawing.Size(117, 23);
            this.btnDodajSmenu.TabIndex = 2;
            this.btnDodajSmenu.Text = "Dodaj smenu";
            this.btnDodajSmenu.UseVisualStyleBackColor = true;
            this.btnDodajSmenu.Click += new System.EventHandler(this.btnDodajSmenu_Click);
            // 
            // lblTipSmene
            // 
            this.lblTipSmene.AutoSize = true;
            this.lblTipSmene.Location = new System.Drawing.Point(32, 86);
            this.lblTipSmene.Name = "lblTipSmene";
            this.lblTipSmene.Size = new System.Drawing.Size(59, 13);
            this.lblTipSmene.TabIndex = 6;
            this.lblTipSmene.Text = "Tip smene:";
            // 
            // nudTipSmene
            // 
            this.nudTipSmene.Location = new System.Drawing.Point(129, 86);
            this.nudTipSmene.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudTipSmene.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTipSmene.Name = "nudTipSmene";
            this.nudTipSmene.Size = new System.Drawing.Size(106, 20);
            this.nudTipSmene.TabIndex = 7;
            this.nudTipSmene.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SmenaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nudTipSmene);
            this.Controls.Add(this.lblTipSmene);
            this.Controls.Add(this.btnDodajSmenu);
            this.Controls.Add(this.lblDatumOd);
            this.Controls.Add(this.dtpDatumOd);
            this.Name = "SmenaForm";
            this.Text = "Smene";
            ((System.ComponentModel.ISupportInitialize)(this.nudTipSmene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label lblDatumOd;
        private System.Windows.Forms.Button btnDodajSmenu;
        private System.Windows.Forms.Label lblTipSmene;
        private System.Windows.Forms.NumericUpDown nudTipSmene;
    }
}
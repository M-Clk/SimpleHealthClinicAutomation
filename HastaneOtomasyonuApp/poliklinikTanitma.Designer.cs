namespace HastaneOtomasyonuApp
{
    partial class poliklinikTanitma
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbPoliklinikAdi = new System.Windows.Forms.ComboBox();
            this.chkGecerli = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOHAST - Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Poliklinik Adi";
            // 
            // cbPoliklinikAdi
            // 
            this.cbPoliklinikAdi.FormattingEnabled = true;
            this.cbPoliklinikAdi.Location = new System.Drawing.Point(119, 44);
            this.cbPoliklinikAdi.Name = "cbPoliklinikAdi";
            this.cbPoliklinikAdi.Size = new System.Drawing.Size(121, 21);
            this.cbPoliklinikAdi.TabIndex = 2;
            this.cbPoliklinikAdi.SelectedIndexChanged += new System.EventHandler(this.cbPoliklinikAdi_SelectedIndexChanged);
            this.cbPoliklinikAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPoliklinikAdi_KeyDown);
            // 
            // chkGecerli
            // 
            this.chkGecerli.AutoSize = true;
            this.chkGecerli.Location = new System.Drawing.Point(119, 70);
            this.chkGecerli.Name = "chkGecerli";
            this.chkGecerli.Size = new System.Drawing.Size(102, 17);
            this.chkGecerli.TabIndex = 3;
            this.chkGecerli.Text = "Gecerli/Gecersiz";
            this.chkGecerli.UseVisualStyleBackColor = true;
            this.chkGecerli.CheckedChanged += new System.EventHandler(this.chkGecerli_CheckedChanged);
            // 
            // poliklinikTanitma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 105);
            this.Controls.Add(this.chkGecerli);
            this.Controls.Add(this.cbPoliklinikAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "poliklinikTanitma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.poliklinikTanitma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPoliklinikAdi;
        private System.Windows.Forms.CheckBox chkGecerli;
    }
}
namespace HastaneOtomasyonuApp
{
    partial class taburcu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtSevkTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOdemeSekli);
            this.groupBox1.Controls.Add(this.dtCikisTarihi);
            this.groupBox1.Controls.Add(this.dtSevkTarihi);
            this.groupBox1.Controls.Add(this.txtToplamTutar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDosyaNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(278, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbOdemeSekli
            // 
            this.cbOdemeSekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOdemeSekli.FormattingEnabled = true;
            this.cbOdemeSekli.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Karti - Taksitli",
            "Kredi Karti - Tek Cekim",
            "Cek",
            "Senet"});
            this.cbOdemeSekli.Location = new System.Drawing.Point(97, 100);
            this.cbOdemeSekli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOdemeSekli.Name = "cbOdemeSekli";
            this.cbOdemeSekli.Size = new System.Drawing.Size(172, 21);
            this.cbOdemeSekli.TabIndex = 12;
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Enabled = false;
            this.dtCikisTarihi.Location = new System.Drawing.Point(97, 76);
            this.dtCikisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(172, 20);
            this.dtCikisTarihi.TabIndex = 11;
            // 
            // dtSevkTarihi
            // 
            this.dtSevkTarihi.Enabled = false;
            this.dtSevkTarihi.Location = new System.Drawing.Point(97, 45);
            this.dtSevkTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSevkTarihi.Name = "dtSevkTarihi";
            this.dtSevkTarihi.Size = new System.Drawing.Size(172, 20);
            this.dtSevkTarihi.TabIndex = 10;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Enabled = false;
            this.txtToplamTutar.Location = new System.Drawing.Point(97, 124);
            this.txtToplamTutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.Size = new System.Drawing.Size(172, 20);
            this.txtToplamTutar.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Toplam Tutar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Odeme Sekli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cikis Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dosya No";
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Enabled = false;
            this.txtDosyaNo.Location = new System.Drawing.Point(97, 20);
            this.txtDosyaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(172, 20);
            this.txtDosyaNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sevk Tarihi";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(10, 173);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(64, 23);
            this.btnVazgec.TabIndex = 1;
            this.btnVazgec.Text = "Vazgec";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(224, 173);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(64, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // taburcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 208);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "taburcu";
            this.ShowIcon = false;
            this.Text = "SOHATS - TABURCU";
            this.Load += new System.EventHandler(this.taburcu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbOdemeSekli;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtSevkTarihi;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVazgec;
        private System.Windows.Forms.Button btnKaydet;
    }
}
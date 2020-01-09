namespace HastaneOtomasyonuApp
{
    partial class dosyaBul
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAdSoyad = new System.Windows.Forms.Panel();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.cbVe = new System.Windows.Forms.CheckBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.cbAramaKriteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgDosyaBul = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlAdSoyad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDosyaBul)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.cbAramaKriteri);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 38);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlAdSoyad);
            this.panel2.Controls.Add(this.txtArama);
            this.panel2.Location = new System.Drawing.Point(188, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 31);
            this.panel2.TabIndex = 2;
            // 
            // pnlAdSoyad
            // 
            this.pnlAdSoyad.Controls.Add(this.txtSoyad);
            this.pnlAdSoyad.Controls.Add(this.cbVe);
            this.pnlAdSoyad.Controls.Add(this.txtAd);
            this.pnlAdSoyad.Location = new System.Drawing.Point(0, 0);
            this.pnlAdSoyad.Name = "pnlAdSoyad";
            this.pnlAdSoyad.Size = new System.Drawing.Size(219, 31);
            this.pnlAdSoyad.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(133, 5);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(82, 20);
            this.txtSoyad.TabIndex = 4;
            // 
            // cbVe
            // 
            this.cbVe.AutoSize = true;
            this.cbVe.Location = new System.Drawing.Point(89, 7);
            this.cbVe.Name = "cbVe";
            this.cbVe.Size = new System.Drawing.Size(38, 17);
            this.cbVe.TabIndex = 3;
            this.cbVe.Text = "ve";
            this.cbVe.UseVisualStyleBackColor = true;
            this.cbVe.CheckedChanged += new System.EventHandler(this.cbVe_CheckedChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(0, 5);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(82, 20);
            this.txtAd.TabIndex = 2;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(0, 5);
            this.txtArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(216, 20);
            this.txtArama.TabIndex = 2;
            this.txtArama.Visible = false;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(413, 7);
            this.btnBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(48, 19);
            this.btnBul.TabIndex = 3;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // cbAramaKriteri
            // 
            this.cbAramaKriteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAramaKriteri.FormattingEnabled = true;
            this.cbAramaKriteri.Items.AddRange(new object[] {
            "Hasta Ad Soyad",
            "Kimlik No",
            "Kurum Sicil No",
            "Dosya No"});
            this.cbAramaKriteri.Location = new System.Drawing.Point(78, 5);
            this.cbAramaKriteri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAramaKriteri.Name = "cbAramaKriteri";
            this.cbAramaKriteri.Size = new System.Drawing.Size(104, 21);
            this.cbAramaKriteri.TabIndex = 1;
            this.cbAramaKriteri.SelectedIndexChanged += new System.EventHandler(this.cbAramaKriteri_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arama Kriteri";
            // 
            // dgDosyaBul
            // 
            this.dgDosyaBul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDosyaBul.Location = new System.Drawing.Point(10, 53);
            this.dgDosyaBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDosyaBul.MultiSelect = false;
            this.dgDosyaBul.Name = "dgDosyaBul";
            this.dgDosyaBul.ReadOnly = true;
            this.dgDosyaBul.RowHeadersWidth = 51;
            this.dgDosyaBul.RowTemplate.Height = 26;
            this.dgDosyaBul.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDosyaBul.Size = new System.Drawing.Size(468, 303);
            this.dgDosyaBul.TabIndex = 1;
            this.dgDosyaBul.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDosyaBul_CellDoubleClick);
            // 
            // dosyaBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 366);
            this.Controls.Add(this.dgDosyaBul);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dosyaBul";
            this.Text = "<Dosya Bul>";
            this.Load += new System.EventHandler(this.dosyaBul_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAdSoyad.ResumeLayout(false);
            this.pnlAdSoyad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDosyaBul)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cbAramaKriteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDosyaBul;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlAdSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.CheckBox cbVe;
        private System.Windows.Forms.TextBox txtAd;
    }
}
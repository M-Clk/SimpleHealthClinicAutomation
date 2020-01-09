using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HastaneOtomasyonuApp
{
    public partial class hastaIslemleri : Form
    {
        public hastaIslemleri()
        {
            InitializeComponent();
        }
        decimal toplamTutar = 0;
        public DataGridViewRow SeciliHasta { get; set; }
        public DataTable SeciliHastaninSevkleri { get; set; }

        private void frmHastaIslemleri_Load(object sender, EventArgs e)
        {
            DbOperations dbOperations = DbOperations.GetInstance();

            cbYapilanIslem.ValueMember = "birimFiyati";
            cbYapilanIslem.DisplayMember = "islemAdi";
            cbYapilanIslem.DataSource = dbOperations.Sorgu("tum_islemleri_getir");

            cbPoliklinik.DisplayMember = "poliklinikAdi";
            cbPoliklinik.ValueMember = "poliklinikAdi";
            cbPoliklinik.DataSource = dbOperations.Sorgu("poliklinik_acik_olanlari_getir");

            cbDrAdi.DisplayMember = "advesoyad";
            cbDrAdi.ValueMember = "kodu";
            cbDrAdi.DataSource = dbOperations.Sorgu("kullanici_doktor_getir");
        }
        private void txtDosyaNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtDosyaNo.Text.Length > 0)
                HastaAra();
        }

        void HastaAra()
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
                {
                    new SqlParameter()
                    {
                        ParameterName="@DosyaNo",
                        SqlDbType=SqlDbType.Int,
                        SqlValue = txtDosyaNo.Text
                    }
                };
            DbOperations dbOperations = DbOperations.GetInstance();
            DataTable hastaTable = dbOperations.Sorgu("dosyano_ile_bul", sqlParameters);
            temporaryDataGrid.DataSource = hastaTable;

            if (hastaTable.Rows.Count > 0)
            {
                SeciliHasta = temporaryDataGrid.Rows[0];
                SeciliHastaBilgileriYukle();
                SeciliHastaninIslemleriniYukle(int.Parse(txtDosyaNo.Text), dtSevk.Value, false);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bu dosya numarasina ait hasta bulunamadi. Farkli parametrelerle hastayi aramak ister misin?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    SeciliHasta = null;

                    dosyaBul bul = new dosyaBul(this);
                    bul.ShowDialog();
                    if (SeciliHasta != null)
                    {
                        SeciliHastaBilgileriYukle();

                        SeciliHastaninIslemleriniYukle(int.Parse(SeciliHasta.Cells["dosyano"].Value.ToString()), dtSevk.Value,false);
                    }
                }
                else
                {
                    txtDosyaNo.Clear();
                }

            }
        }

        //TODO baski onizleme ya da yazdirma butonlari sadece tabloda satir varken calissin
        private void btnBaski_Click(object sender, EventArgs e)
        {
            if (SeciliHastaninSevkleri.Rows.Count == 0) return;

            DGVPrinter printer = new DGVPrinter();
            printer = YazdirmayaHazirla(printer);
            printer.PrintPreviewDataGridView(dgYapilanTahlil);

        }

        DGVPrinter YazdirmayaHazirla(DGVPrinter printer)
        {
            printer.Title = "Hasta Sevk İşlemleri : " + SeciliHasta.Cells["ad"].Value + " " + SeciliHasta.Cells["soyad"].Value;
            printer.SubTitle = "\n";
            printer.TitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Center;
            printer.Footer = "Toplam :" + lblToplam.Text + "\n Tarih :" + dtSevk.Value.Date;
            printer.FooterColor = Color.Black;
            printer.FooterAlignment = StringAlignment.Near;
            printer.SubTitleSpacing = 15;
            printer.ShowTotalPageNumber = false;
            printer.FooterSpacing = 15;
            printer.SubTitleColor = Color.Gray;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            return printer;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (txtDosyaNo.Text.Length == 0)
            {
                dosyaBul bul = new dosyaBul(this);
                bul.ShowDialog();
                if (SeciliHasta != null)
                {
                    SeciliHastaBilgileriYukle();
                    SeciliHastaninIslemleriniYukle(int.Parse(SeciliHasta.Cells["dosyano"].Value.ToString()), dtSevk.Value, false);
                }
            }
            else
                HastaAra();
        }

        void SeciliHastaBilgileriYukle()
        {
            txtHastaAdi.Text = SeciliHasta.Cells["ad"].Value.ToString();
            txtSoyadi.Text = SeciliHasta.Cells["soyad"].Value.ToString();
            txtKurumAdi.Text = SeciliHasta.Cells["kurumadi"].Value.ToString();
            txtDosyaNo.Text = SeciliHasta.Cells["dosyano"].Value.ToString();
            btnHastaBilgileri.Enabled = true;
        }

        //TODO Secili hastanin dosya numarasina ve secili sevk tarihine gore verileri sorgula ve duzenleyip datagride aktar.

        void SeciliHastaninOncekiIsleminiYukle(int dosyaNo)
        {

            List<SqlParameter> sqlParameters = new List<SqlParameter>()
                {
                    new SqlParameter()
                    {
                        ParameterName="@DosyaNo",
                        SqlDbType=SqlDbType.Int,
                        SqlValue = dosyaNo
                    }
                };
            DbOperations dbOperations = DbOperations.GetInstance();
            DataTable oncekiIslemler = dbOperations.Sorgu("dosyano_ile_onceki_islem_tarihleri_getir", sqlParameters);
            cbOncelikliIslemleri.DisplayMember = "sevktarihi";
            cbOncelikliIslemleri.ValueMember = "sevktarihi";
            cbOncelikliIslemleri.DataSource = oncekiIslemler;
        }
        void SeciliHastaninIslemleriniYukle(int dosyaNo, DateTime tarih, bool taburcu)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
                {
                    new SqlParameter()
                    {
                        ParameterName="@DosyaNo",
                        SqlDbType=SqlDbType.Int,
                        SqlValue = dosyaNo
                    },
                new SqlParameter()
                    {
                        ParameterName="@tarih",
                        SqlDbType=SqlDbType.Date,
                        SqlValue =tarih.Date
                    },
                new SqlParameter()
                    {
                        ParameterName="@taburcu",
                        SqlDbType=SqlDbType.Bit,
                        SqlValue =taburcu
                    }
                };
            
            DbOperations dbOperations = DbOperations.GetInstance();
            SeciliHastaninSevkleri = dbOperations.Sorgu("dosyano_ile_bul_sevk", sqlParameters);
            dgYapilanTahlil.DataSource = SeciliHastaninSevkleri;
            for (int i = 0; i < SeciliHastaninSevkleri.Rows.Count; i++)
            {
                toplamTutar += (decimal)SeciliHastaninSevkleri.Rows[i]["toplamtutar"];
            } 
            lblToplam.Text = toplamTutar.ToString() + "TL";
            
            btnTaburcu.Enabled = !taburcu;

            SeciliHastaninOncekiIsleminiYukle(dosyaNo);

            dgYapilanTahlil.Columns["poliklinik"].HeaderText = "POLIKLINIK";
            dgYapilanTahlil.Columns["sira"].HeaderText = "SIRA";
            dgYapilanTahlil.Columns["saat"].HeaderText = "SAAT";
            dgYapilanTahlil.Columns["yapilanislem"].HeaderText = "YAPILAN ISLEM";
            dgYapilanTahlil.Columns["drkod"].HeaderText = "DOKTOR KODU";
            dgYapilanTahlil.Columns["miktar"].HeaderText = "MIKTAR";
            dgYapilanTahlil.Columns["birimfiyat"].HeaderText = "BIRIM FIYATI";

            dgYapilanTahlil.Columns["toplamtutar"].Visible = false;

            
        }

        //TODO Taburcu edilen sevk islemlerini yukle

        private void btnGit_Click(object sender, EventArgs e)
        {
            SeciliHastaninIslemleriniYukle(int.Parse(SeciliHasta.Cells["dosyano"].Value.ToString()), DateTime.Parse(cbOncelikliIslemleri.SelectedValue.ToString()), true);
        }
        private void btnHastaBilgileri_Click(object sender, EventArgs e)
        {
            if (SeciliHasta != null)
            {
                hastaBilgileri hastaBilgileri = new hastaBilgileri(SeciliHasta, this);
                hastaBilgileri.ShowDialog();
                SeciliHastaBilgileriYukle();
            }
        }
        private void Yazdir_Click(object sender, EventArgs e)
        {

            if (SeciliHastaninSevkleri.Rows.Count == 0) return;
            DGVPrinter printer = new DGVPrinter();
            printer = YazdirmayaHazirla(printer);
            printer.PrintDataGridView(dgYapilanTahlil);
        }
        private void btnSecSil_Click(object sender, EventArgs e)
        {
            if (dgYapilanTahlil.SelectedRows.Count == 0) return;
            foreach (DataGridViewRow item in dgYapilanTahlil.SelectedRows)
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>()
                {
                    new SqlParameter()
                    {
                        ParameterName="@DosyaNo",
                        SqlDbType=SqlDbType.Int,
                        SqlValue = SeciliHasta.Cells["dosyano"].Value
                    },
                    new SqlParameter()
                    {
                        ParameterName="@poliklinikAdi",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = item.Cells["poliklinik"].Value
                    },
                    new SqlParameter()
                    {
                        ParameterName="@sira",
                        SqlDbType=SqlDbType.Int,
                        SqlValue = item.Cells["sira"].Value
                    },
                new SqlParameter()
                    {
                        ParameterName="@sevktarihi",
                        SqlDbType=SqlDbType.Date,
                        SqlValue =dtSevk.Value.Date
                    }
                };
                DbOperations dbOperations = DbOperations.GetInstance();
                dbOperations.Update("delete_sevk", sqlParameters);
            }
            SeciliHastaninIslemleriniYukle(int.Parse(SeciliHasta.Cells["dosyano"].Value.ToString()),dtSevk.Value, false);
            SiraNumarasiYukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DbOperations dbOperations = DbOperations.GetInstance();
            DataTable gelenVeri = dbOperations.Sorgu("son_dosyano_getir_hasta");
            int gelenDosyaNo = (int)gelenVeri.Rows[0][0];
            hastaBilgileri hastaBilgileri = new hastaBilgileri(++gelenDosyaNo);
            hastaBilgileri.ShowDialog();
        }

        private void cbYapilanIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBirimFiyat.Text = cbYapilanIslem.SelectedValue.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (SeciliHasta == null) return;
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
                {
                    new SqlParameter()
                    {
                        ParameterName="@sevkTarihi",
                        SqlDbType=SqlDbType.DateTime,
                        SqlValue = dtSevk.Value.Date
                    },
                new SqlParameter()
                    {
                        ParameterName="@dosyano",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue =txtDosyaNo.Text
                    },
                new SqlParameter()
                    {
                        ParameterName="@poliklinik",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue =cbPoliklinik.SelectedValue
                    },
                new SqlParameter()
                    {
                        ParameterName="@saat",
                        SqlDbType= SqlDbType.NVarChar,
                        SqlValue = DateTime.Now.Hour+":"+DateTime.Now.Minute
                    },
                new SqlParameter()
                    {
                        ParameterName="@yapilanIslem",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue =cbYapilanIslem.Text
                    },
                new SqlParameter()
                    {
                        ParameterName="@drkod",
                        SqlDbType=SqlDbType.Int,
                        SqlValue = cbDrAdi.SelectedValue
                    },
                new SqlParameter()
                    {
                        ParameterName="@miktar",
                        SqlDbType=SqlDbType.Int,
                        SqlValue = nmMiktar.Value
                    },
                new SqlParameter()
                    {
                        ParameterName="@birimfiyat",
                        SqlDbType=SqlDbType.Decimal,
                        SqlValue =decimal.Parse(txtBirimFiyat.Text)
                    },
                new SqlParameter()
                    {
                        ParameterName="@sira",
                        SqlDbType=SqlDbType.Int,
                        SqlValue = int.Parse(txtSiraNo.Text)
                    },
                new SqlParameter()
                    {
                        ParameterName="@toplamTutar",
                        SqlDbType=SqlDbType.Decimal,
                        SqlValue = nmMiktar.Value * decimal.Parse(txtBirimFiyat.Text)
                    },
                new SqlParameter()
                    {
                        ParameterName="@taburcu",
                        SqlDbType = SqlDbType.NVarChar,
                        SqlValue = ""
                    }
                };

            DbOperations dbOperations = DbOperations.GetInstance();
            if (dbOperations.Update("insert_sevk", sqlParameters))
            {
                SeciliHastaninIslemleriniYukle(int.Parse(SeciliHasta.Cells["dosyano"].Value.ToString()), dtSevk.Value, false);
                cbPoliklinik.SelectedIndex = 0;
            }
            else MessageBox.Show("Islem eklenemedi.");
            SiraNumarasiYukle();
        }
        void SiraNumarasiYukle()
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>()
                {
                    new SqlParameter()
                    {
                        ParameterName="@poliklinikAdi",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = cbPoliklinik.SelectedValue.ToString()
                    },
                new SqlParameter()
                    {
                        ParameterName="@tarih",
                        SqlDbType=SqlDbType.Date,
                        SqlValue =dtSevk.Value.Date
                    }
                };
            DbOperations dbOperations = DbOperations.GetInstance();
            DataTable dataTable = dbOperations.Sorgu("son_sira_no_getir", sqlParameters);

            int sonSira;
            if (int.TryParse(dataTable.Rows[0][0].ToString(), out sonSira)) txtSiraNo.Text = (sonSira + 1).ToString();
            else txtSiraNo.Text = "1";
        }
        private void cbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            SiraNumarasiYukle();
        }
        private void btnTaburcu_Click(object sender, EventArgs e)
        {
            if (SeciliHastaninSevkleri.Rows.Count > 0)
            {
                taburcu taburcu = new taburcu(dtSevk.Value, int.Parse(SeciliHasta.Cells["dosyano"].Value.ToString()), toplamTutar);
                taburcu.ShowDialog();
                SeciliHastaninIslemleriniYukle(int.Parse(SeciliHasta.Cells["dosyano"].Value.ToString()), dtSevk.Value,false);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonuApp
{
    public partial class hastaBilgileri : Form
    {
        hastaIslemleri hastaIslemleri;
        public hastaBilgileri(int dosyaNo )
        {
            procName = "insert_hasta";
            InitializeComponent();
            txtDosyaNo.Text = dosyaNo.ToString();
            cbCinsiyet.SelectedIndex = 0;
            cbMedeniHal.SelectedIndex = 0;
            cbKanGrubu.SelectedIndex = 0;
        }
        string procName;
        public hastaBilgileri(DataGridViewRow seciliHasta, hastaIslemleri _hastaIslemleri)
        {  
            hastaIslemleri = _hastaIslemleri;
            procName = "update_hasta";
            InitializeComponent();
            txtDosyaNo.Text = seciliHasta.Cells["dosyano"].Value.ToString();
            txtTc.Text = seciliHasta.Cells["tckimlikno"].Value.ToString();
            txtTc.Enabled = false;
            txtAd.Text = seciliHasta.Cells["ad"].Value.ToString();
            txtSoyad.Text = seciliHasta.Cells["soyad"].Value.ToString();
            txtDogum.Text = seciliHasta.Cells["dogumyeri"].Value.ToString();
            dtDogumTarigi.Value = DateTime.Parse(seciliHasta.Cells["dogumtarihi"].Value.ToString());
            txtBabaAdi.Text = seciliHasta.Cells["babaadi"].Value.ToString();
            txtAnaAdi.Text = seciliHasta.Cells["anneadi"].Value.ToString();
            cbCinsiyet.SelectedItem = seciliHasta.Cells["cinsiyet"].Value.ToString();
            cbKanGrubu.SelectedItem = seciliHasta.Cells["kangrubu"].Value.ToString();
            cbMedeniHal.SelectedItem = seciliHasta.Cells["medenihal"].Value.ToString();
            txtAdres.Text = seciliHasta.Cells["adres"].Value.ToString();
            txtTelefon.Text = seciliHasta.Cells["tel"].Value.ToString();
            txtKurumSicilNo.Text = seciliHasta.Cells["kurumsicilno"].Value.ToString();
            txtKurumAdi.Text = seciliHasta.Cells["kurumadi"].Value.ToString();
            txtYakinTelNo.Text = seciliHasta.Cells["yakintel"].Value.ToString();
            txtYakinKurumAdi.Text = seciliHasta.Cells["yakinkurumadi"].Value.ToString();
            txtYakinKurumSicilNo.Text = seciliHasta.Cells["yakinkurumsicilno"].Value.ToString();

        }

        private void hastaBilgileri_Load(object sender, EventArgs e)
        {
           
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            procName = "insert_hasta";
        }
        bool Validation()
        {

            if (txtTc.Text.Length != 11)
            {
                MessageBox.Show("Tc kimlik no 11 haneli olmali.");
                return false;
            }
            try
            {
                long.Parse(txtTc.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Tc kimlik no sayisal bir deger olmali.");
                return false;
            }
            if (dtDogumTarigi.Value > DateTime.Now)
            {
                MessageBox.Show("Dogum tarihi bu gunden buyuk bir tarih girilemez.");
                return false;
            }
            if (txtAd.Text.Length < 3)
            {
                MessageBox.Show("Hasta adi en az 3 karakterli olmali.");
                return false;
            }
            if (txtSoyad.Text.Length < 2)
            {
                MessageBox.Show("Hasta soyadi en az 2 karakterli olmali.");
                return false;
            }
            return true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
             
                if (InsertOrUpdate())
                {
                    if (procName.Equals("insert_hasta"))
                    {
                        int sonDosyaNo = int.Parse(txtDosyaNo.Text);
                        txtDosyaNo.Text = (++sonDosyaNo).ToString();
                        Temizle();
                    }
                    else
                    {
                        hastaIslemleri.SeciliHasta.Cells["ad"].Value = txtAd.Text;
                        hastaIslemleri.SeciliHasta.Cells["soyad"].Value = txtSoyad.Text;
                        hastaIslemleri.SeciliHasta.Cells["dogumyeri"].Value = txtDogum.Text;
                        hastaIslemleri.SeciliHasta.Cells["dogumtarihi"].Value = dtDogumTarigi.Value;
                        hastaIslemleri.SeciliHasta.Cells["babaadi"].Value = txtBabaAdi.Text;
                        hastaIslemleri.SeciliHasta.Cells["anneadi"].Value = txtAnaAdi.Text;
                        hastaIslemleri.SeciliHasta.Cells["cinsiyet"].Value = cbCinsiyet.SelectedItem.ToString();
                        hastaIslemleri.SeciliHasta.Cells["kangrubu"].Value = cbKanGrubu.SelectedItem.ToString();
                        hastaIslemleri.SeciliHasta.Cells["medenihal"].Value =cbMedeniHal.SelectedItem.ToString();
                        hastaIslemleri.SeciliHasta.Cells["adres"].Value = txtAdres.Text;
                        hastaIslemleri.SeciliHasta.Cells["tel"].Value = txtTelefon.Text;
                        hastaIslemleri.SeciliHasta.Cells["kurumsicilno"].Value = txtKurumSicilNo.Text;
                        hastaIslemleri.SeciliHasta.Cells["kurumadi"].Value = txtKurumAdi.Text;
                        hastaIslemleri.SeciliHasta.Cells["yakintel"].Value = txtYakinTelNo.Text;
                        hastaIslemleri.SeciliHasta.Cells["yakinkurumadi"].Value = txtYakinKurumAdi.Text;
                        hastaIslemleri.SeciliHasta.Cells["yakinkurumsicilno"].Value = txtYakinKurumSicilNo.Text;
                    }
                    MessageBox.Show("Hasta basariyla kaydedildi.");
                }
                else
                {
                    MessageBox.Show("Hasta kaydedilemedi.");
                }
            }
        }

        private bool InsertOrUpdate()
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
                {
                    new SqlParameter()
                    {
                        ParameterName="@tckimlikno",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtTc.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@dosyano",
                        SqlDbType=SqlDbType.Int,
                        SqlValue = txtDosyaNo.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@ad",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtAd.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@soyad",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtSoyad.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@dogumyeri",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtDogum.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@dogumtarihi",
                        SqlDbType=SqlDbType.DateTime,
                        SqlValue = dtDogumTarigi.Value
                    },
                    new SqlParameter()
                    {
                        ParameterName="@babaadi",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtBabaAdi.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@anaadi",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtAnaAdi.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@cinsiyet",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = cbCinsiyet.SelectedItem.ToString()
                    },
                    new SqlParameter()
                    {
                        ParameterName="@kangrubu",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = cbKanGrubu.SelectedItem.ToString()
                    },
                    new SqlParameter()
                    {
                        ParameterName="@medenihal",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = cbMedeniHal.SelectedItem.ToString()
                    },
                    new SqlParameter()
                    {
                        ParameterName="@adres",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtAdres.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@tel",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtTelefon.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@kurumsicilno",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtKurumSicilNo.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@kurumadi",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtKurumAdi.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@yakintel",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtYakinTelNo.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@yakinkurumsicilno",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtYakinKurumSicilNo.Text
                    },
                    new SqlParameter()
                    {
                        ParameterName="@yakinkurumadi",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = txtYakinKurumAdi.Text
                    },

                };
            DbOperations dbOperation = DbOperations.GetInstance();
            return dbOperation.Update(procName, parameters);
        }

        void Temizle()
        {
            foreach (var item in Controls)
            {
                if (item is TextBox && ((TextBox)item).Name != txtDosyaNo.Name)
                    ((TextBox)item).Clear();
                if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
                if (item is DateTimePicker)
                    ((DateTimePicker)item).Value = DateTime.Now;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

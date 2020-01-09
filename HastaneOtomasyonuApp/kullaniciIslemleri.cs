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
    public partial class kullaniciIslemleri : Form
    {
        DataRow seciliKullanici;
        string procName;
        public kullaniciIslemleri(DataRow _secilenKullanici)
        {
            InitializeComponent();
            seciliKullanici = _secilenKullanici;
            procName = "update_kullanici";

            txtKullaniciKodu.Text = seciliKullanici["kodu"].ToString();
            txtKullaniciAdi.Text = seciliKullanici["username"].ToString();
            txtSifre.Text = seciliKullanici["sifre"].ToString();
            txtAd.Text = seciliKullanici["ad"].ToString();
            txtAdres.Text = seciliKullanici["adres"].ToString();
            txtAnaAdi.Text = seciliKullanici["annead"].ToString();
            txtBabaAdi.Text = seciliKullanici["babaad"].ToString();
            txtDogum.Text = seciliKullanici["dogumyeri"].ToString();
            txtGsm.Text = seciliKullanici["ceptel"].ToString();
            numericMaas.Value = (decimal)seciliKullanici["maas"];
            txtSoyad.Text = seciliKullanici["soyad"].ToString();
            txtTc.Text = seciliKullanici["tckimlikno"].ToString();
            txtTelefon.Text = seciliKullanici["evtel"].ToString();
            cbCinsiyet.SelectedItem = seciliKullanici["cinsiyet"].ToString();
            cbKanGrubu.SelectedItem = seciliKullanici["kangrubu"].ToString();
            cbMedeniHal.SelectedItem = seciliKullanici["medenihal"].ToString();
            cbUnvan.SelectedItem = seciliKullanici["unvani"].ToString();
            dtDogum.Value = (DateTime)seciliKullanici["dogumtarihi"];
            dtIseBaslama.Value = (DateTime)seciliKullanici["isebaslama"];
            chkYetki.Checked = (bool)seciliKullanici["yetki"];
        }

        public kullaniciIslemleri(int kod)
        {
            procName = "insert_kullanici";
            InitializeComponent();
            txtKullaniciKodu.Text = (++kod).ToString();
        }
        private void kullaniciIslemleri_Load(object sender, EventArgs e)
        {
            foreach (var item in Controls)
                if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            if (UpdateVeInsert())
            {
                this.Close();
                MessageBox.Show("Basarili bir sekilde kaydedildi.");
            }

            else
                MessageBox.Show("Kaydedilemedi. Tekrar deneyin.");

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (UpdateVeInsert())
                MessageBox.Show("Basarili bir sekilde guncellendi.");
            else
                MessageBox.Show("Guncellenemedi. Tekrar deneyin.");
        }

        bool UpdateVeInsert()
        {
            List<SqlParameter> parameters = new List<SqlParameter>(){
                new SqlParameter(){SqlValue=txtKullaniciAdi.Text, ParameterName="@username", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=txtSifre.Text, ParameterName="@sifre", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=int.Parse(txtKullaniciKodu.Text), ParameterName="@kodu", SqlDbType = SqlDbType.Int},
                new SqlParameter(){SqlValue=txtTelefon.Text, ParameterName="@ceptel", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=chkYetki.Checked, ParameterName="@yetki", SqlDbType = SqlDbType.Bit},
                new SqlParameter(){SqlValue=txtAd.Text, ParameterName="@ad", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=txtSoyad.Text, ParameterName="@soyad", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=txtTelefon.Text, ParameterName="@evtel", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=txtAdres.Text, ParameterName="@adres", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=txtDogum.Text, ParameterName="@dogumyeri", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=txtAnaAdi.Text, ParameterName="@anneadi", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=txtBabaAdi.Text, ParameterName="@babaadi", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=cbCinsiyet.SelectedItem.ToString(), ParameterName="@cinsiyet", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=cbKanGrubu.SelectedItem.ToString(), ParameterName="@kangrubu", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=cbMedeniHal.SelectedItem.ToString(), ParameterName="@medenihali", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=txtTc.Text, ParameterName="@tckimlikno", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=dtDogum.Value, ParameterName="@dogumtarihi", SqlDbType = SqlDbType.DateTime},
                new SqlParameter(){SqlValue=dtIseBaslama.Value, ParameterName="@isebaslama", SqlDbType = SqlDbType.DateTime},
                new SqlParameter(){SqlValue=numericMaas.Value, ParameterName="@maas", SqlDbType = SqlDbType.Decimal},
                new SqlParameter(){SqlValue=cbUnvan.SelectedItem.ToString(), ParameterName="@unvan", SqlDbType = SqlDbType.NVarChar}
            };
            DbOperations dbOperations = DbOperations.GetInstance();
            return dbOperations.Update(procName, parameters);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parameters = new List<SqlParameter>(){
                new SqlParameter(){SqlValue=txtKullaniciKodu.Text, ParameterName="@kodu", SqlDbType = SqlDbType.Int}
            };
            DbOperations dbOperations = DbOperations.GetInstance();
            if (dbOperations.Update("delete_kullanici",parameters))
            {
                MessageBox.Show("Basarili bir sekilde silindi.");
                this.Close();
            }
            else
                MessageBox.Show("Silinemedi. Tekrar deneyin.");

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

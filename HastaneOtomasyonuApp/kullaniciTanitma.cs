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
    public partial class kullaniciTanitma : Form
    {
        bool comboBoxIndexChangedOlayiCalissin;
        public kullaniciTanitma()
        {
            InitializeComponent();
        }
        DataTable kullanicilar;
        private void kullaniciTanitma_Load(object sender, EventArgs e)
        {
            DbOperations dbOperations = DbOperations.GetInstance();
            kullanicilar = dbOperations.Sorgu("kullanici_kodu_ve_adi_getir", new List<SqlParameter>());

            cmBoxKullaniciKodu.DisplayMember = "username";
            cmBoxKullaniciKodu.ValueMember = "kodu";
            cmBoxKullaniciKodu.DataSource = kullanicilar;

            comboBoxIndexChangedOlayiCalissin = true;    

        }

        private void cmBoxKullaniciKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxIndexChangedOlayiCalissin) return;
            ComboBox comboBox = (ComboBox)sender;
            kullaniciIslemleri kullanici = new kullaniciIslemleri(kullanicilar.Rows[comboBox.SelectedIndex]);
            kullanici.MdiParent = this.MdiParent;
            kullanici.Show();
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            DbOperations dbOperations = DbOperations.GetInstance();
            DataTable gelenVeri = dbOperations.Sorgu("son_kodu_getir_kullanici");
            int gelenKod = (int)gelenVeri.Rows[0][0];
            kullaniciIslemleri kullanici = new kullaniciIslemleri(gelenKod);
            kullanici.MdiParent = this.MdiParent;
            kullanici.Show();
            this.Close();
        }
    }
}

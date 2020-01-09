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
    public partial class poliklinikTanitma : Form
    {
        public poliklinikTanitma()
        {
            InitializeComponent();
        }
        DataTable poliklinikler;
        DataTable filtreliPoliklinikler;
        bool comboBoxIndexChangedOlayiCalissin;
        private void poliklinikTanitma_Load(object sender, EventArgs e)
        {
            DbOperations dbOperations = DbOperations.GetInstance();
            poliklinikler = dbOperations.Sorgu("poliklinik_adi_durum_getir");
            
            PoliklinikYukle(true);
            comboBoxIndexChangedOlayiCalissin = true;
        }
        private void cbPoliklinikAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxIndexChangedOlayiCalissin) return;
            ComboBox comboBox = (ComboBox)sender;

            PoliklinikAc(new Poliklinik(filtreliPoliklinikler.Rows[comboBox.SelectedIndex]));
            
        }

        void PoliklinikAc(Poliklinik poliklinik)
        {
            poliklinik.MdiParent = this.MdiParent;
            poliklinik.Show();
            this.Close();
        }

        private void chkGecerli_CheckedChanged(object sender, EventArgs e)
        {
            PoliklinikYukle(chkGecerli.Checked);
        }
        void PoliklinikYukle(bool state)
        {
            cbPoliklinikAdi.Items.Clear();
            var filtreliSatirlar = from currentPol in poliklinikler.AsEnumerable()
                                where (bool)currentPol["durum"] == state
                                select currentPol;
            if (filtreliSatirlar.Count() > 0)
                filtreliPoliklinikler = filtreliSatirlar.CopyToDataTable();
            
            foreach (DataRow item in filtreliPoliklinikler.Rows)
                cbPoliklinikAdi.Items.Add(item["poliklinikAdi"]);

        }
        private void cbPoliklinikAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return; 
            if(YeniPoliklinikEklemeKontrol(cbPoliklinikAdi.Text))
            {
                PoliklinikAc(new Poliklinik(cbPoliklinikAdi.Text));
            }
            else
            {
                MessageBox.Show("Bu poliklinik adi kaydedilmek icin uygun degil.");
            }
        }
        bool YeniPoliklinikEklemeKontrol(string eklenecekPoliklinikAdi)
        {
            if (eklenecekPoliklinikAdi.Length < 4) return false;
            var ayniIsimdeOlan = from currentPol in poliklinikler.AsEnumerable()
                                 where currentPol["poliklinikAdi"].ToString() == eklenecekPoliklinikAdi
                                 select currentPol;
            if (ayniIsimdeOlan.Count() > 0)
                return false;
            else return true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

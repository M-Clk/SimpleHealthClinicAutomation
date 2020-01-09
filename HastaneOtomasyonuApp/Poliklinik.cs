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
    public partial class Poliklinik : Form
    {
        //TODO poliklinik formununu constructor ini poliklinik adini alacak sekilde overload et. ve onu burda cagir.
        public Poliklinik()
        {
            InitializeComponent();
        }
        string procName;
        public Poliklinik(DataRow gelenPoliklinik) //Guncelleme icin
        {
            procName = "update_poliklinik";
            InitializeComponent();
            txtPoliklinikAdi.Text = gelenPoliklinik["poliklinikAdi"].ToString();
            txtAciklama.Text = gelenPoliklinik["aciklama"].ToString();
            chkGecerli.Checked = (bool)gelenPoliklinik["durum"];
        }
        public Poliklinik(string polName) //Ekleme icin
        {
            procName = "insert_poliklinik";
            InitializeComponent();
            txtPoliklinikAdi.Text = polName;
            btnGuncelle.Text = "Ekle";
            btnSil.Visible = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parameters = new List<SqlParameter>(){
                new SqlParameter(){SqlValue=txtPoliklinikAdi.Text, ParameterName="@poliklinikAdi", SqlDbType = SqlDbType.NVarChar}
            };
            DbOperations dbOperations = DbOperations.GetInstance();
            if (dbOperations.Update("delete_poliklinik", parameters))
            {
                MessageBox.Show("Basarili bir sekilde silindi.");
                this.Close();
            }
            else
                MessageBox.Show("Silinemedi. Tekrar deneyin.");
        }
        bool UpdateVeInsert()
        {
            List<SqlParameter> parameters = new List<SqlParameter>(){
                new SqlParameter(){SqlValue=txtPoliklinikAdi.Text, ParameterName="@poliklinikAdi", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=txtAciklama.Text, ParameterName="@aciklama", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=chkGecerli.Checked, ParameterName="@durum", SqlDbType = SqlDbType.Bit},
            };
            DbOperations dbOperations = DbOperations.GetInstance();
            return dbOperations.Update(procName, parameters);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (UpdateVeInsert())
            {
                MessageBox.Show("Basarili islem.");
                this.Close();
            }
            else
                MessageBox.Show("Islem basarisiz oldu. Tekrar deneyin.");
            
        }
    }
}

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
    public partial class dosyaBul : Form
    {
        hastaIslemleri acikOlanHastaIslemleri;
        public dosyaBul(hastaIslemleri hastaIslemleri)
        {
            InitializeComponent();
            acikOlanHastaIslemleri = hastaIslemleri;
        }

        private void dosyaBul_Load(object sender, EventArgs e)
        {
            cbAramaKriteri.SelectedIndex = 0;
            cbVe.Checked = true;
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            
            DbOperations dbOperations = DbOperations.GetInstance();
            
            string selectedProcName;
            List<SqlParameter> parameters = new List<SqlParameter>();
            
            if(cbAramaKriteri.SelectedIndex==0)
            {
                selectedProcName = "hasta_adi_ve_soyadi_ile_bul";
                parameters.Add(new SqlParameter() { SqlValue = txtAd.Text, ParameterName = "@Adi", SqlDbType = SqlDbType.NVarChar });
                
                parameters.Add(new SqlParameter() { SqlValue = cbVe.Checked?txtSoyad.Text:"", ParameterName = "@Soyadi", SqlDbType = SqlDbType.NVarChar });
            }
            else if(cbAramaKriteri.SelectedIndex==1)
            {
                selectedProcName = "kimlikno_ile_bul";
                parameters.Add(new SqlParameter() { SqlValue = txtArama.Text, ParameterName = "@KimlikNo", SqlDbType = SqlDbType.NVarChar });
            }
            else if(cbAramaKriteri.SelectedIndex==2)
            {
                selectedProcName = "kurumsicilno_ile_bul";
                parameters.Add(new SqlParameter() { SqlValue = txtArama.Text, ParameterName = "@KurumSicilNo", SqlDbType = SqlDbType.NVarChar });
            }
            else 
            {
                selectedProcName = "dosyano_ile_bul";
                    int result;
                  if(!int.TryParse(txtArama.Text,out result))
                {
                    MessageBox.Show("Dosya numarasi sadece numerik olabilir");
                    return;
                }
                parameters.Add(new SqlParameter() { 
                    SqlValue = txtArama.Text, 
                    ParameterName = "@DosyaNo", 
                    SqlDbType = SqlDbType.Int });
            }
            
            DataTable bulunanSonuclar =  dbOperations.Sorgu(selectedProcName,parameters);

            dgDosyaBul.DataSource = bulunanSonuclar; 
        }
        private void cbAramaKriteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAramaKriteri.SelectedIndex == 0)
            {
                txtSoyad.Clear();
                txtAd.Clear();
                pnlAdSoyad.Visible = true;
                txtArama.Visible = false;
            }
            else 
            {
                txtArama.Clear();
                pnlAdSoyad.Visible = false;
                txtArama.Visible = true;
            }

        }
        private void cbVe_CheckedChanged(object sender, EventArgs e)
        {
            txtSoyad.Visible = cbVe.Checked;
        }

        private void dgDosyaBul_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
if (e.RowIndex == -1) return;
            acikOlanHastaIslemleri.SeciliHasta = dgDosyaBul.Rows[e.RowIndex];
            this.Close();
        }
    }
}

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
    public partial class taburcu : Form
    {
        public taburcu(DateTime sevkTarihi, int dosyaNo, decimal toplamTutar)
        {
            InitializeComponent();
            dtSevkTarihi.Value = sevkTarihi;
            txtDosyaNo.Text = dosyaNo.ToString();
            txtToplamTutar.Text = toplamTutar.ToString();
        }

        private void taburcu_Load(object sender, EventArgs e)
        {
            cbOdemeSekli.SelectedIndex = 0;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter()
                    {
                        ParameterName="@sevkTarihi",
                        SqlDbType=SqlDbType.Date,
                        SqlValue = dtSevkTarihi.Value.Date
                    },
                new SqlParameter()
                    {
                        ParameterName="@dosyano",
                        SqlDbType=SqlDbType.Int,
                        SqlValue =txtDosyaNo.Text
                    },
                new SqlParameter()
                    {
                        ParameterName="@cikisTarihi",
                        SqlDbType=SqlDbType.Date,
                        SqlValue =dtCikisTarihi.Value.Date
                    },
                new SqlParameter()
                    {
                        ParameterName="@odeme",
                        SqlDbType=SqlDbType.NVarChar,
                        SqlValue = cbOdemeSekli.Text
                    },
                new SqlParameter()
                    {
                        ParameterName="@toplamTutar",
                        SqlDbType=SqlDbType.Decimal,
                        SqlValue = txtToplamTutar.Text
                    }
            };
            DbOperations dbOperations = DbOperations.GetInstance();
            if(dbOperations.Update("insert_cikis", parameters))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Taburcu islemi gerceklesemedi.");
            }
           
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

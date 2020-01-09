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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        bool yetkiliMi;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (SingIn())
            {
                anaForm anaForm = (anaForm)this.MdiParent;
                anaForm.isLogin = true;
                ((MenuStrip)this.ParentForm.Controls["menuStrip1"]).Items["referanslarToolStripMenuItem"].Visible = yetkiliMi; 
                this.Close(); 
            }
            else
            {
                txtSifre.Clear();
                MessageBox.Show("Kullanici adi veya sifre girildi.", "Hatali Giris", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool SingIn() 
        {
            DbOperations dbOperations = DbOperations.GetInstance();
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter(){SqlValue=txtKullaniciAdi.Text, ParameterName="@kullaniciAdi", SqlDbType = SqlDbType.NVarChar},
                new SqlParameter(){SqlValue=txtSifre.Text, ParameterName="@sifre", SqlDbType = SqlDbType.NVarChar}
            };
            DataTable dataTable = dbOperations.Sorgu("kullanici_getir", parameters);
            if (dataTable.Rows.Count == 0) return false;
            else
            {
                yetkiliMi = (bool)dataTable.Rows[0]["yetki"];
                return true;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGiris_Click(btnGiris, new EventArgs());

        }
    }
}

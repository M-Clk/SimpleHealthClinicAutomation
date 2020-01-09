using System;
using System.Windows.Forms;

namespace HastaneOtomasyonuApp
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }
        public bool isLogin { get; set; }
        private void anaForm_Load(object sender, EventArgs e)
        {
            YeniFormAc(new login());
        }

        private void rapor1geciciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void poliklinikTanitmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniFormAc(new poliklinikTanitma());
        }

        void YeniFormAc(Form form)
        {
            if (isLogin || form is login)
            {
                form.MdiParent = this;
                form.Show();
            }
        }

        private void hastaIslemleriF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniFormAc(new hastaIslemleri());
        }

        private void kullaniciTanitmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniFormAc(new kullaniciTanitma());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                isLogin = false;
                foreach (var item in this.MdiChildren)
                    item.Close();
                menuStrip1.Items["referanslarToolStripMenuItem"].Visible = false;
            }
            YeniFormAc(new login());
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) YeniFormAc(new hastaIslemleri());
        }
    }
}

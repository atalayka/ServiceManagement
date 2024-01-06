using DevExpress.XtraEditors;
using Is_Takip_Proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is_Takip_Proje.PersonelGorevFormlari
{
    public partial class FormCagriDetay : Form
    {
        public FormCagriDetay()
        {
            InitializeComponent();
        }
        public int id;
        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCagriDetay_Load(object sender, EventArgs e)
        {   
            txtCagriId.Enabled = false; 
            txtCagriId.Text = id.ToString();
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            txtTarih.Text = tarih;
            txtSaat.Text = saat;
        }
        DbIsTakiipEntities db = new DbIsTakiipEntities();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblCagriDetay t = new TblCagriDetay();
            t.Cagri = int.Parse(txtCagriId.Text);
            t.Saat = txtSaat.Text;
            t.Tarih = DateTime.Parse(txtTarih.Text);
            t.Aciklama = txtAciklama.Text;
            db.TblCagriDetay.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt başarılı.");
        }
    }
}

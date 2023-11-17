using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Is_Takip_Proje.Entity;

namespace Is_Takip_Proje.Forms
{
    public partial class FormYeniGorev : Form
    {
        public FormYeniGorev()
        {
            InitializeComponent();
        }
        DbIsTakiipEntities db = new DbIsTakiipEntities();
        private void FormYeniGorev_Load(object sender, EventArgs e)
        {
            var gorevAlan = (from x in db.TblPersonel select new { x.ID, x.Ad}).ToList();
            lookGorevAlan.Properties.ValueMember = "ID";
            lookGorevAlan.Properties.DisplayMember = "Ad";
            lookGorevAlan.Properties.DataSource = gorevAlan;
        }

    private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblGorevler t = new TblGorevler();


            t.GorevVeren = int.Parse(txtGorevVeren.Text);
            t.GorevAlan = int.Parse(lookGorevAlan.EditValue.ToString());
            t.Aciklama = txtAciklama.Text;
            t.Durum = true;
            t.Tarih = DateTime.Parse(txtTarih.Text);

            db.TblGorevler.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Kayıt başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

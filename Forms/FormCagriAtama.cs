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

namespace Is_Takip_Proje.Forms
{
    public partial class FormCagriAtama : Form
    {
        public FormCagriAtama()
        {
            InitializeComponent();
        }
        public int id;
        DbIsTakiipEntities db = new DbIsTakiipEntities();
        private void FormCagriAtama_Load(object sender, EventArgs e)
        {
            //lookupedit
            var personel = (from x in db.TblPersonel
                            select new
                            {
                                x.ID,
                                AdSoyad = x.Ad + " " + x.Soyad
                            }).ToList();



            lookGorevAlan.Properties.ValueMember = "ID";
            lookGorevAlan.Properties.DisplayMember = "AdSoyad";
            lookGorevAlan.Properties.DataSource = personel;

            txtCagriId.Text = id.ToString();
            var gelenveri = db.TblCagrilar.Find(id);
            txtAciklama.Text = gelenveri.Aciklama;
            txtTarih.Text = gelenveri.Tarih.ToString();
            txtKonu.Text = gelenveri.Konu;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var gelenveri = db.TblCagrilar.Find(id);
            gelenveri.Konu = txtKonu.Text;
            gelenveri.Tarih = DateTime.Parse(txtTarih.Text);
            gelenveri.Aciklama = txtAciklama.Text;
            gelenveri.CagriPersonel = int.Parse(lookGorevAlan.EditValue.ToString());
            db.SaveChanges();
        }
    }
}

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
    
    public partial class FormPersoneller : Form
    {
        DbIsTakiipEntities db = new DbIsTakiipEntities();
        void ListelePersonel ()
        {
            var degerler = from x in db.TblPersonel select new { x.ID, 
                x.Ad,
                x.Soyad, 
               Departman =  x.TblDepartmanlar.Ad,
                x.Telefon, 
                x.Durum 
            };

            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();
        }
        public FormPersoneller()
        {
            InitializeComponent();
        }

        private void FormPersoneller_Load(object sender, EventArgs e)
        {
            ListelePersonel();

            var departmanlar = (from x in db.TblDepartmanlar select new { x.ID, x.Ad }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Ad";

            lookUpEdit1.Properties.DataSource = departmanlar;

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblPersonel tblPersonel = new TblPersonel();
            tblPersonel.Ad = txtAd.Text;
            tblPersonel.Soyad = txtSoyad.Text;
            tblPersonel.Mail = txtMail.Text;
            tblPersonel.Görsel = txtGorsel.Text;
            tblPersonel.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            XtraMessageBox.Show("Kayıt Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            db.TblPersonel.Add(tblPersonel);
            db.SaveChanges();
            ListelePersonel();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListelePersonel();
        }
    }
}

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
                x.Görsel,
                x.Mail,
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
            tblPersonel.Telefon = txtTelefon.Text;
            tblPersonel.Görsel = txtGorsel.Text;
            tblPersonel.Durum = true;
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtID.Text);
            var deger = db.TblPersonel.Find(x);

            deger.Durum = false;

            db.SaveChanges();
            XtraMessageBox.Show("Silme Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListelePersonel();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            txtTelefon.Text = gridView1.GetFocusedRowCellValue("Telefon").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            txtGorsel.Text = gridView1.GetFocusedRowCellValue("Görsel").ToString();
            lookUpEdit1.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtID.Text);
            var deger = db.TblPersonel.Find(x);

            deger.Ad = txtAd.Text;
            deger.Soyad = txtSoyad.Text;
            deger.Mail = txtMail.Text;
            deger.Telefon = txtTelefon.Text;
            deger.Görsel = txtGorsel.Text;
            deger.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Güncelleme Gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListelePersonel();

        }
    }
}

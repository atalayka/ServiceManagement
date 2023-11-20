using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Is_Takip_Proje.Entity;

namespace Is_Takip_Proje.Forms
{
    public partial class FormAnaForm : Form
    {
        public FormAnaForm()
        {
            InitializeComponent();
        }
        DbIsTakiipEntities db = new DbIsTakiipEntities();
        private void FormAnaForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource =
                (from x in db.TblGorevler select new { x.Aciklama, AdSoyad = x.TblPersonel.Ad + " " + x.TblPersonel.Soyad, x.Durum }).
                Where(y => y.Durum == true).ToList();

            gridView1.Columns["Durum"].Visible = false;

            //gridcont2 üzerinde bugünün işlerinin açıklamasını getir.

            gridControl2.DataSource = (from x in db.TblGorevDetaylar
                                       select new
                                       {
                                           Görev = x.Aciklama,
                                           x.TblGorevler.Aciklama,
                                           x.Tarih
                                       }).Where(y => y.Tarih == DateTime.Today).ToList();
            gridView2.Columns["Tarih"].Visible = false;


            //gridcont4 üzerinde cagri işlerinin açıklamasını getir.

            gridControl4.DataSource = (from x in db.TblCagrilar
                                       select new
                                       {
                                           x.TblFirmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(y => y.Durum == true).ToList();
            gridView4.Columns["Durum"].Visible = false;

            //gridcont3 üzerinde firmalar işlerinin açıklamasını getir.

            gridControl3.DataSource = (from x in db.TblFirmalar
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon,
                                           x.Mail,
                                       }).ToList();

            //çağrı grafikleri
            int aktif_cagrilar = db.TblCagrilar.Count(x=>x.Durum == true);  
            int pasif_cagrilar = db.TblCagrilar.Count(x=>x.Durum == false);

            chartControl1.Series["Series 1"].Points.AddPoint("Aktif Çağrılar", aktif_cagrilar);
            chartControl1.Series["Series 1"].Points.AddPoint("Pasif Çağrılar", pasif_cagrilar);


        }
    }
}

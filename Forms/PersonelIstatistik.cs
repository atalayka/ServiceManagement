using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo.DB.Helpers;
using Is_Takip_Proje.Entity;

namespace Is_Takip_Proje.Forms
{
    public partial class FormPersonelIstatistik : Form
    {
        public FormPersonelIstatistik()
        {
            InitializeComponent();
        }
        DbIsTakiipEntities db = new DbIsTakiipEntities();
        private void labelControl22_Click(object sender, EventArgs e)
        {

        }

        private void btnPersonelIstatistik_Load(object sender, EventArgs e)
        {
            lblDepartmanSayisi.Text = db.TblDepartmanlar.Count().ToString();
            lblPersonelSayisi.Text = db.TblPersonel.Count().ToString();
            lblFirmasayisi.Text = db.TblFirmalar.Count().ToString();
            lblAktifİssayisi.Text = db.TblGorevler.Count(x => x.Durum == "1").ToString();
            lblPasifissayisii.Text = db.TblGorevler.Count(x => x.Durum == "0").ToString();
            lblBugünküiss.Text = db.TblGorevler.Count(x => x.Tarih == DateTime.Today).ToString();
            lblSongorevv.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            lblFirmasayisi.Text = db.TblFirmalar.Count().ToString();

            // LINQ sorgusu ile en çok tekrarlanan departman kodunu bulma
            var enCokTekrarlananDepartmanKodu = db.TblPersonel
                .GroupBy(p => p.Departman)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();
            var hangiDepartman = db.TblDepartmanlar
           .Where(x => x.ID == enCokTekrarlananDepartmanKodu)
           .Select(x => x.Ad) // veya hangi özellikleri istiyorsanız
           .FirstOrDefault();

            lblEncokpersonelDepartmanSayisi.Text = hangiDepartman;


        }
    }

}

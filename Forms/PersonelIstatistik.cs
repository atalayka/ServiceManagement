using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        private void FormPersonelIstatistik_Load(object sender, EventArgs e)
        {
            DateTime bugün = DateTime.Today;    

            lblDepartmanSayisi.Text = db.TblDepartmanlar.Count().ToString();
            lblPersonelSayisi.Text = db.TblPersonel.Count().ToString();
            lblFirmasayisi.Text = db.TblFirmalar.Count().ToString();
            lblAktifİssayisi.Text = db.TblGorevler.Count(x => x.Durum == true).ToString();
            lblPasifissayisii.Text = db.TblGorevler.Count(x => x.Durum == false).ToString();

            lblSonGorevTarihh.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();


            lblSongorevv.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            lblFirmasayisi.Text = db.TblFirmalar.Count().ToString();
            lblSehirsayisii.Text = db.TblFirmalar.Select(x => x.il).Distinct().Count().ToString();
            lblSektorsayisii.Text = db.TblFirmalar.Select(x => x.Sektör).Distinct().Count().ToString();
            lblbugünkügorevlerSay.Text = db.TblGorevler.Count(x => x.Tarih == bugün).ToString();


            // LINQ sorgusu ile AyınPersoneliID bulma
            var AyınPersoneliID = db.TblGorevler
                .GroupBy(g => g.GorevAlan)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault();

            var personel = db.TblPersonel
                .FirstOrDefault(x => x.ID == AyınPersoneliID);

            if (personel != null)
            {
                lblAyinpersonelii.Text = personel.Ad;
            }



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
            lblAyinDepartmani.Text = hangiDepartman;



        }


    }

}

using Is_Takip_Proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is_Takip_Proje.PersonelGorevFormlari
{
    public partial class FormCagriListesi : Form
    {
        public FormCagriListesi()
        {
            InitializeComponent();
        }
        DbIsTakiipEntities db = new DbIsTakiipEntities();
        public string mail1;
        private void FormCagriListesi_Load(object sender, EventArgs e)
        {
            var personelid = db.TblPersonel.Where(x => x.Mail == mail1).Select(y => y.ID).FirstOrDefault();
            gridControl1.DataSource = (from x in db.TblCagrilar
                                       select new
                                       {
                                           x.ID,
                                           x.TblFirmalar.Ad,
                                           x.TblFirmalar.Telefon,
                                           x.TblFirmalar.Mail,
                                           x.Aciklama,
                                           x.Durum,
                                           x.CagriPersonel,
                                       }).Where(y => y.Durum == true && y.CagriPersonel == personelid).ToList();
            gridView1.Columns["Durum"].Visible = false;
            gridView1.Columns["Aciklama"].Visible = false;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormCagriDetay fr = new FormCagriDetay();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}

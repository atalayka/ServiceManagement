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
    public partial class FormAktifCagrilar : Form
    {
        public FormAktifCagrilar()
        {
            InitializeComponent();
        }

        private void FormAktifCagrilar_Load(object sender, EventArgs e)
        {
            DbIsTakiipEntities db = new DbIsTakiipEntities();

            var degerler = (from x in db.TblCagrilar
                            select new
                            {
                                x.ID,
                                x.TblFirmalar.Ad,
                                x.TblFirmalar.Telefon,
                                x.Konu,
                                x.Aciklama,
                                Personel = x.TblPersonel.Ad,
                                x.Durum
                            }).Where(x => x.Durum == true).ToList();



            GridControl1FormCagrilar.DataSource = degerler;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FormCagriAtama fr = new FormCagriAtama();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();

        }
    }
}

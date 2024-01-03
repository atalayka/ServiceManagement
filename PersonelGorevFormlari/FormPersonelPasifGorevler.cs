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
    public partial class FormPersonelPasifGorevler : Form
    {
        public FormPersonelPasifGorevler()
        {
            InitializeComponent();
        }
        DbIsTakiipEntities db = new DbIsTakiipEntities();

        private void FormPersonelPasifGorevler_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblGorevler
                            select new
                            {
                                x.ID,
                                x.Aciklama,
                                x.Tarih,
                                x.GorevAlan,
                                x.Durum
                            }).Where(x => x.GorevAlan == 1 && x.Durum == false).ToList();

            gridControl1.DataSource = degerler;

            gridView1.Columns["GorevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;
        }
    }
}

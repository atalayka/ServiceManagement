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
    public partial class FormPersonelFormu : Form
    {
        public FormPersonelFormu()
        {
            InitializeComponent();
        }

        private void FormPersonelFormu_Load(object sender, EventArgs e)
        {

        }

        private void btnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FormAktifGorevler fr = new FormAktifGorevler();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnPasifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FormPersonelPasifGorevler fr = new FormPersonelPasifGorevler();
            fr.MdiParent = this;
            fr.Show();
        }

        private void btnCagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelGorevFormlari.FormCagriListesi fr = new FormCagriListesi();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}

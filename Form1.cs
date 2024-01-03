using DevExpress.XtraPrinting.Preview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is_Takip_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Forms.FormPersoneller formpersoneller;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formpersoneller == null || formpersoneller.IsDisposed)
            {
                formpersoneller = new Forms.FormPersoneller();
                formpersoneller.MdiParent = this;
                formpersoneller.Show();
            }

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem24_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        Forms.FormDepartmanlar frmdepartmanlar;
        private void BtnDepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmdepartmanlar == null || frmdepartmanlar.IsDisposed)
            {
                frmdepartmanlar = new Forms.FormDepartmanlar();
                frmdepartmanlar.MdiParent = this;
                frmdepartmanlar.Show();
            }

        }
        Forms.FormPersonelIstatistik frmistatistik;
        private void btnPersonelIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frmistatistik == null || frmistatistik.IsDisposed)
            {
                frmistatistik = new Forms.FormPersonelIstatistik();
                frmistatistik.MdiParent = this;
                frmistatistik.Show();
            }
        }
        Forms.FormGorevListesi frmGorev;
        private void btnGorevListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frmGorev == null || frmGorev.IsDisposed)
            {
                frmGorev = new Forms.FormGorevListesi();
                frmGorev.MdiParent = this;
                frmGorev.Show();
            }
        }

        Forms.FormYeniGorev ForemYeniGorev;
        private void btnYeniGorev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (ForemYeniGorev == null || ForemYeniGorev.IsDisposed)
            {

                ForemYeniGorev = new Forms.FormYeniGorev();
                ForemYeniGorev.Show();
            }
        }

        Forms.FormGorevDetay formGorevDetay;
        private void btnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formGorevDetay == null || formGorevDetay.IsDisposed)
            {
                formGorevDetay = new Forms.FormGorevDetay();
                formGorevDetay.Show();
            }
        }
        Forms.FormAnaForm frmanaform;
        private void btnAnaform_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmanaform == null || frmanaform.IsDisposed)
            {
                frmanaform = new Forms.FormAnaForm();
                frmanaform.MdiParent = this;
                frmanaform.Show();
            }
        }
        Forms.FormAktifCagrilar fr;
        private void btnAktifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Forms.FormAktifCagrilar();
                fr.MdiParent = this;
                fr.Show();
            }
        }
    }
}

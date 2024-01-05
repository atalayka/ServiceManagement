﻿namespace Is_Takip_Proje.PersonelGorevFormlari
{
    partial class FormPersonelFormu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelFormu));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAktifGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.btnPasifGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnCagriListesi = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAktifGorevler,
            this.btnPasifGorevler,
            this.btnCagriListesi});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(884, 150);
            // 
            // btnAktifGorevler
            // 
            this.btnAktifGorevler.Caption = "Aktif Görevler";
            this.btnAktifGorevler.Id = 1;
            this.btnAktifGorevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAktifGorevler.ImageOptions.Image")));
            this.btnAktifGorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAktifGorevler.ImageOptions.LargeImage")));
            this.btnAktifGorevler.Name = "btnAktifGorevler";
            this.btnAktifGorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAktifGorevler_ItemClick);
            // 
            // btnPasifGorevler
            // 
            this.btnPasifGorevler.Caption = "Pasif Görevler";
            this.btnPasifGorevler.Id = 2;
            this.btnPasifGorevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPasifGorevler.ImageOptions.Image")));
            this.btnPasifGorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPasifGorevler.ImageOptions.LargeImage")));
            this.btnPasifGorevler.Name = "btnPasifGorevler";
            this.btnPasifGorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPasifGorevler_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAktifGorevler);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPasifGorevler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCagriListesi);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // btnCagriListesi
            // 
            this.btnCagriListesi.Caption = "Çağrı Listesi";
            this.btnCagriListesi.Id = 3;
            this.btnCagriListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnCagriListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnCagriListesi.Name = "btnCagriListesi";
            this.btnCagriListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCagriListesi_ItemClick);
            // 
            // FormPersonelFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormPersonelFormu";
            this.Text = "Personel Formu";
            this.Load += new System.EventHandler(this.FormPersonelFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAktifGorevler;
        private DevExpress.XtraBars.BarButtonItem btnPasifGorevler;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnCagriListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}
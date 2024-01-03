namespace Is_Takip_Proje.Forms
{
    partial class FormAktifCagrilar
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
            this.GridControl1FormCagrilar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1FormCagrilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridControl1FormCagrilar
            // 
            this.GridControl1FormCagrilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControl1FormCagrilar.Location = new System.Drawing.Point(0, 0);
            this.GridControl1FormCagrilar.MainView = this.gridView1;
            this.GridControl1FormCagrilar.Name = "GridControl1FormCagrilar";
            this.GridControl1FormCagrilar.Size = new System.Drawing.Size(969, 346);
            this.GridControl1FormCagrilar.TabIndex = 5;
            this.GridControl1FormCagrilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridControl1FormCagrilar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FormAktifCagrilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 346);
            this.Controls.Add(this.GridControl1FormCagrilar);
            this.Name = "FormAktifCagrilar";
            this.Text = "Aktif Çağrılar";
            this.Load += new System.EventHandler(this.FormAktifCagrilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1FormCagrilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridControl1FormCagrilar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
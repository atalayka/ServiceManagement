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
    public partial class FormCagriDetay : Form
    {
        public FormCagriDetay()
        {
            InitializeComponent();
        }

        private void btnVazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCagriDetay_Load(object sender, EventArgs e)
        {
            string saat, tarih;
            tarih = DateTime.Now.ToShortDateString();
            saat = DateTime.Now.ToShortTimeString();
            txtTarih.Text = tarih;
            txtSaat.Text = saat;
        }
    }
}

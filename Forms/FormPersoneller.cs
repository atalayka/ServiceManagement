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
    
    public partial class FormPersoneller : Form
    {
        DbIsTakiipEntities db = new DbIsTakiipEntities();
        void ListelePersonel ()
        {
            var degerler = from x in db.TblPersonel select new { x.ID, x.Ad, x.Soyad, x.Departman, x.Telefon };
            gridControl1.DataSource = degerler.ToList();
        }
        public FormPersoneller()
        {
            InitializeComponent();
        }

        private void FormPersoneller_Load(object sender, EventArgs e)
        {
            ListelePersonel();

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}

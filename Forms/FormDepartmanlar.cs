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
    public partial class FormDepartmanlar : Form
    {
        public FormDepartmanlar()
        {
            InitializeComponent();
        }
        //crud
        void Listele()
        {
            DbIsTakiipEntities db = new DbIsTakiipEntities();
            gridControl1.DataSource = db.TblDepartmanlar.ToList();
        }
        //crud
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

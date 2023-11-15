﻿using System;
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
    public partial class FormGorevListesi : Form
    {
        public FormGorevListesi()
        {
            InitializeComponent();
        }
        DbIsTakiipEntities db = new DbIsTakiipEntities();
        private void   Listele()
        {
            var result = (from x in db.TblGorevler
                          select new { x.Aciklama }).ToList();

            // GridControl'ün DataSource'ını liste olarak ayarlayın
            gridGorevListesi.DataSource = result;

        }

        private void FormGorevListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

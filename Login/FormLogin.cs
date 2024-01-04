using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Is_Takip_Proje.Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            //this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGorevFormlari.FormPersonelFormu fr = new PersonelGorevFormlari.FormPersonelFormu();
            fr.Show();
            //this.Hide();
        }
    }
}

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

namespace Is_Takip_Proje.Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        DbIsTakiipEntities db = new DbIsTakiipEntities();
        private int loginAttempts = 0;
        private void button1_Click(object sender, EventArgs e)
        {


            var adminValue = db.TblAdmin.Where(x => x.Kullanici == txtkullanici.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
            if (adminValue != null)
            {
                Form1 form1 = new Form1();
                
                form1.Show();
                this.Hide();
            }
            else
            {
                // Incorrect login
                loginAttempts++;

                if (loginAttempts >= 3)
                {
                    this.Close();
                }
                else
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {



            var adminValue = db.TblPersonel.Where(x => x.Mail == txtkullanici.Text && x.Sifre == txtSifre.Text).FirstOrDefault();
            if (adminValue != null)
            {
                PersonelGorevFormlari.FormPersonelFormu fr = new PersonelGorevFormlari.FormPersonelFormu();
                fr.mail = txtkullanici.Text;    
                fr.Show();
                this.Hide();
            }
            else
            {
                // Incorrect login
                loginAttempts++;

                if (loginAttempts >= 3)
                {
                    this.Close();
                }
                else
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = true;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SELTEM_Kütüphane_Otomasyonu_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kutuphane_OtomasyonuEntities1 db = new Kutuphane_OtomasyonuEntities1();
        private void button1_Click(object sender, EventArgs e)
        {
            string gelenkullaniciadi = txtprsad.Text;
            string gelensifre = txtparola.Text;

            var personel = db.Personeller.Where(x => x.Personel_kullaniciadi == (gelenkullaniciadi) && x.Personel_sifre == (gelensifre)).FirstOrDefault();

            if (personel == null) 
            {
                MessageBox.Show("Personel adı veya şifre hatalı");
            }
            else
            {
                İşlem_Paneli islem = new İşlem_Paneli();
                islem.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F1)
            {
                btngiris.PerformClick();
            }
            if (e.KeyCode==Keys.Escape)
            {
                btnkapat.PerformClick();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtparola.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

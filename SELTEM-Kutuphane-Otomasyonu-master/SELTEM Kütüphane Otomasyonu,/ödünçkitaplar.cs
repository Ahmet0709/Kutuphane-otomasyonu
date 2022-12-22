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
    public partial class ödünçkitaplar : Form
    {
        

        Kutuphane_OtomasyonuEntities1 db = new Kutuphane_OtomasyonuEntities1();
        public ödünçkitaplar()
        {
            InitializeComponent();
        }
        void kitapliste()
        {
            var kitaplistele = db.Kitaplar.ToList();
            kitapdtgw.DataSource = kitaplistele.ToList();
        }

        void üyelistele()
        {
            var üyeliste = db.üyeler_1.ToList();
            üyedtgw.DataSource = üyeliste.ToList();
        }

        void kayitlistele()
        {
            var kayitliste = db.genel_kayitlar_1.ToList();
            dtgw1.DataSource = kayitliste.ToList();
            
        }


        void kitapdatagrid()
        {
            kitapdtgw.Columns[0].HeaderText = "Barkod Numarası";
            kitapdtgw.Columns[1].HeaderText = "Kitap Adı";
            kitapdtgw.Columns[2].HeaderText = "Kitap Yazarı";
            kitapdtgw.Columns[3].HeaderText = "Yayınevi";
            kitapdtgw.Columns[4].HeaderText = "Sayfa Sayısı";
            kitapdtgw.Columns[5].HeaderText = "Basım Tarihi";
        }

        void üyedatagrid()
        {
            üyedtgw.Columns[0].HeaderText = "Üye Numarası";
            üyedtgw.Columns[1].HeaderText = "Üye Ad/Soyad";
            üyedtgw.Columns[2].HeaderText = "Üye Sınıf";
            üyedtgw.Columns[3].HeaderText = "Üye Cinsiyet";
            üyedtgw.Columns[4].HeaderText = "Üye Telefon Numarası";
            üyedtgw.Columns[5].HeaderText = "Üye E-Posta";
            üyedtgw.Columns[6].HeaderText = "Üye E-Posta Türü";
        }

        void genelkayıtlar()
        {
            dtgw1.Columns[0].HeaderText = "Kayıt Id";
            dtgw1.Columns[1].HeaderText = "Kullanıcı Id";
            dtgw1.Columns[2].HeaderText = "Kitap Id";
            dtgw1.Columns[3].HeaderText = "Alış Tarihi";
            dtgw1.Columns[4].HeaderText = "Son Tarih";
            dtgw1.Columns[5].HeaderText = "Durum";
        }

        private void ödünçkitaplar_Load(object sender, EventArgs e)
        {
            kayitlistele();
            kitapliste();
            üyelistele();

            dtgw1.Columns[6].Visible = true;
            dtgw1.Columns[7].Visible = true;
            

            groupbox1.Visible = true;
            dtgw1.Visible = true;
            paneluye.Visible = true;
            panelkitap.Visible = true;

            üyedtgw.Visible = true;
            kitapdtgw.Visible = true;

            acbutton.Text = "Ödünç işlemlerini Kapat";

            kitapdatagrid();
            üyedatagrid();
            genelkayıtlar();

        }

        private void acbutton_Click(object sender, EventArgs e)
        {
            if (groupbox1.Visible==true)
            {
                groupbox1.Visible = false;
                dtgw1.Visible = false;
                paneluye.Visible = false;
                panelkitap.Visible = false;
                üyedtgw.Visible = false;
                kitapdtgw.Visible = false;
                acbutton.Text = "Ödünç işlemlerini Aç";
            }
            else
            {
                groupbox1.Visible = true;
                dtgw1.Visible = true;
                paneluye.Visible = true;
                panelkitap.Visible = true;
                üyedtgw.Visible = true;
                kitapdtgw.Visible = true;
                acbutton.Text = "Ödünç işlemlerini Kapat";
            }

        }

        private void üyesectext_Click(object sender, EventArgs e)
        { 

        }

        private void kitapsectxt_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //üyeyi aldık
            //string secilenüyeno = üyesectext.Text;
            int secilenüyeno = Convert.ToInt16(üyedtgw.CurrentRow.Cells[0].Value);
            var secilenüye = db.üyeler_1.Where(x => x.üye_no.Equals(secilenüyeno)).FirstOrDefault();

            //kitabı aldık
            int secilenkitapbarkod = Convert.ToInt16(kitapdtgw.CurrentRow.Cells[0].Value);
            var secilenkitap = db.Kitaplar.Where(x => x.kitap_barkod.Equals(secilenkitapbarkod)).FirstOrDefault();

            //kayıta ekleyelim
            genel_kayitlar_1 kayit = new genel_kayitlar_1();
            kayit.kitap_id = secilenkitap.kitap_barkod;
            kayit.kullanici_id = secilenüye.üye_no;
            kayit.alis_tarihi = DateTime.Today;
            kayit.son_tarih = DateTime.Today.AddDays(15);
            kayit.durum = false;
            // 15 gün ekleme yapıyoruz burada

            db.genel_kayitlar_1.Add(kayit);
            db.SaveChanges();
            kayitlistele();
        }

        private void üyesectext_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgw2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            üyesectext.Text = üyedtgw.CurrentRow.Cells[0].Value.ToString();
        }

        private void kitapdtgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapsectext.Text = kitapdtgw.CurrentRow.Cells[0].Value.ToString();
        }

        private void kitapsectxt_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void kitapalbtn_Click(object sender, EventArgs e)
        {
            int secilenkayitıd = Convert.ToInt16(dtgw1.CurrentRow.Cells[0].Value);
            var kayit = db.genel_kayitlar_1.Where(x => x.kayit_id == secilenkayitıd).FirstOrDefault();
            kayit.durum = true;
            db.SaveChanges();
            kayitlistele();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            üyesectext.Clear();
            kitapsectext.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            İşlem_Paneli islempaneli = new İşlem_Paneli();
            islempaneli.Show();
            this.Hide();
        }
    }
}
  

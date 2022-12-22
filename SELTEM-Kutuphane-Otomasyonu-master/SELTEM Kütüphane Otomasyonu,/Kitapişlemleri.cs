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
    public partial class Kitapişlemleri : Form
    {  
        Kutuphane_OtomasyonuEntities1 db = new Kutuphane_OtomasyonuEntities1();
        public Kitapişlemleri()
        {
            InitializeComponent();
        }

      

        private void Kitapişlemleri_Load(object sender, EventArgs e)
        {
            var kitaplar = db.Kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();

            kitapgroupBox.Visible = true;
            dataGridView1.Visible = true;
            arapanel1.Visible = true;

            dataGridView1.Columns[0].HeaderText = "Barkod Numarası";
            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Kitap Yazarı";
            dataGridView1.Columns[3].HeaderText = "Yayınevi";
            dataGridView1.Columns[4].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns[5].HeaderText = "Basım Tarihi";

            


            btnkitapislemleri.Text = "      Kitap işlemlerini Kapat";
            btnarama.Text = "Arama İşlemlerini Kapat";
            btnkitapislemleri.TextAlign = ContentAlignment.MiddleCenter;
            
            

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kitapbarkodtxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            kitapadtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kitapyazartxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kitapyayınevitxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kitapsayfasayısıtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            datebasımtarihi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void kitapislemleribtn_Click(object sender, EventArgs e)
        {
            if (kitapgroupBox.Visible == true)
            {
                dataGridView1.Visible = false;
                kitapgroupBox.Visible = false;
                btnkitapislemleri.Text = "Kitap işlemlerini Aç";
                btnkitapislemleri.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                dataGridView1.Visible = true;
                kitapgroupBox.Visible = true;
                btnkitapislemleri.Text = "      Kitap işlemlerini Kapat";
                btnkitapislemleri.TextAlign = ContentAlignment.MiddleCenter;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            İşlem_Paneli islempaneli = new İşlem_Paneli();
            islempaneli.Show();
            this.Hide();
        }

        private void Kitapişlemleri_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            if (e.KeyCode == Keys.Enter)
                SelectNextControl(sender as Control, true, true, true, true);
        }

        private void btnkydet_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    e.Handled = true;
                    btnkydet.PerformClick();
                    break;
            }
        }

        private void üyeduznlebtn_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F3:
                    e.Handled = true;
                    btnkydet.PerformClick();
                    break;
            }
        }

        private void üyesilbtn_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    e.Handled = true;
                    btnkydet.PerformClick();
                    break;
            }
        }

        private void Kitapduznlebtn_Click_1(object sender, EventArgs e)
        {
            int sg = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var gk = db.Kitaplar.Where(x => x.kitap_barkod == sg).FirstOrDefault();
            gk.kitap_ad = kitapadtxt.Text;
            gk.kitap_yazar = kitapyazartxt.Text;
            gk.kitap_yayınevi = kitapyayınevitxt.Text;
            gk.kitap_sayfasayısı = Convert.ToInt32(kitapsayfasayısıtxt.Text);
            gk.kitap_basımtarihi = datebasımtarihi.Value;
            db.SaveChanges();

            var kitaplar = db.Kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
        }

        private void kıtapsilbtn_Click_1(object sender, EventArgs e)
        {
            int sun = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);  //sun= secılen uye numarası
            var sk = db.Kitaplar.Where(x => x.kitap_barkod == sun).FirstOrDefault();  // sk=silinen kaynak
            db.Kitaplar.Remove(sk);
            db.SaveChanges();

            var kitaplar = db.Kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList(); //datagrid yeniler refresh işlevi görür
        }


        private void btnkydet_Click_1(object sender, EventArgs e)
        {
            Kitaplar kitaplar = new Kitaplar();
            kitaplar.kitap_barkod = Convert.ToInt32(kitapbarkodtxt.Text);
            kitaplar.kitap_ad = kitapadtxt.Text;
            kitaplar.kitap_yazar = kitapyazartxt.Text;
            kitaplar.kitap_yayınevi = kitapyayınevitxt.Text;
            kitaplar.kitap_sayfasayısı = Convert.ToInt32(kitapsayfasayısıtxt.Text);
            kitaplar.kitap_basımtarihi = datebasımtarihi.Value;
            db.Kitaplar.Add(kitaplar);
            db.SaveChanges();

            var kitapişlemleri = db.Kitaplar.ToList();
            dataGridView1.DataSource = kitapişlemleri.ToList();
        }

        private void btnarama_Click(object sender, EventArgs e)
        {
            if (arapanel1.Visible == false)
            {
                btnarama.Text = "Arama İşlemlerini Kapat";
                arapanel1.Visible = true;
            }
            else
            {
                btnarama.Text="Arama işlemlerini Aç";
                arapanel1.Visible = false;
            }
        }


        private void adtext_TextChanged(object sender, EventArgs e)
        {
            string gelenad = adtext.Text;
            var bulunacakkaynak = db.Kitaplar.Where(x => x.kitap_ad.Contains(gelenad)).ToList();
            dataGridView1.DataSource = bulunacakkaynak;
        }

        private void yazartxt_TextChanged(object sender, EventArgs e)
        {
            string gelenyazar = yazartxt.Text;
            var bulunacakkaynak = db.Kitaplar.Where(x => x.kitap_yazar.Contains(gelenyazar)).ToList();
            dataGridView1.DataSource = bulunacakkaynak;
        }

        private void yayınevitxt_TextChanged(object sender, EventArgs e)
        {
            string gelenyayayınevi = yayınevitxt.Text;
            var bulunacakkaynak = db.Kitaplar.Where(x => x.kitap_yayınevi.Contains(gelenyayayınevi)).ToList();
            dataGridView1.DataSource = bulunacakkaynak;
        }

        private void kitapbarkodtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kitapsayfasayısıtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    } 
    
}
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
    public partial class üyeislemleri : Form
    {
       
        public üyeislemleri()
        {
            InitializeComponent();
        }
         Kutuphane_OtomasyonuEntities1 db = new Kutuphane_OtomasyonuEntities1();
        private void üyeislemleri_Load(object sender, EventArgs e)
        {
            var üyeler = db.üyeler_1.ToList();
            üyedatagrid.DataSource = üyeler.ToList();

            arapanel1.Visible = true;

            üyegroupBox.Visible = true;
            üyedatagrid.Visible = true;
            button1.Text = "         Üye işlemlerini Kapat";
            button1.TextAlign = ContentAlignment.MiddleCenter;

            üyedatagrid.Columns[0].HeaderText = "Üye No";
            üyedatagrid.Columns[1].HeaderText = "Üye Adı / Soyadı";
            üyedatagrid.Columns[2].HeaderText = "Üye Sınıfı";
            üyedatagrid.Columns[3].HeaderText = "Üye Cinsiyeti";
            üyedatagrid.Columns[4].HeaderText = "Üye Telefon Numarası";
            üyedatagrid.Columns[5].HeaderText = "Üye Eposta";
            üyedatagrid.Columns[6].HeaderText = "E-posta Türü";
        }

        private void btnkydet_Click(object sender, EventArgs e)
        {
            üyeler_1 üyeler = new üyeler_1();
            üyeler.üye_no = Convert.ToInt32(tbusers.Text);
            üyeler.üye_adsoyad = tbadsoyad.Text;
            üyeler.üye_eposta = tbmail.Text;
            üyeler.üye_sınıf = Convert.ToInt32(cmbclass.Text);
            üyeler.üye_gsm = tbgsm.Text;
            if (rdbtne.Checked == true)
            {
                üyeler.üye_cinsiyet = "E";
            }
            else if (rdbtnk.Checked == true)
            {
                üyeler.üye_cinsiyet = "K";
            }
            else
            {
                MessageBox.Show("LÜTFEN CİNSİYET SEÇİNİZ!!!");
            }
            üyeler.üye_eposta_türü = cmbmailtype.Text;
            db.üyeler_1.Add(üyeler);
            db.SaveChanges();
        }

        private void üyesilbtn_Click(object sender, EventArgs e)
        {
            int sun = Convert.ToInt32(üyedatagrid.CurrentRow.Cells[0].Value);  //sun= secılen uye numarası
            var sü = db.üyeler_1.Where(x => x.üye_no == sun).FirstOrDefault();  // sü=silinen üye
            db.üyeler_1.Remove(sü);
            db.SaveChanges();

            var üyeler = db.üyeler_1.ToList();
            üyedatagrid.DataSource = üyeler.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (üyegroupBox.Visible==true)
            {
                üyegroupBox.Visible = false;
                üyedatagrid.Visible = false;
                button1.Text = "Üye işlemlerini Aç";
                button1.TextAlign = ContentAlignment.MiddleRight;

            }
            else
            {
                üyegroupBox.Visible = true;
                üyedatagrid.Visible = true;
                button1.Text = "     Üye işlemlerini Kapat";
                button1.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void üyeduznlebtn_Click(object sender, EventArgs e)
        {
            int dü = Convert.ToInt32(üyedatagrid.CurrentRow.Cells[0].Value);
            var dk = db.üyeler_1.Where(x => x.üye_no == dü).FirstOrDefault();
            dk.üye_adsoyad = tbadsoyad.Text;
            dk.üye_sınıf = Convert.ToInt32(cmbclass.Text);
            dk.üye_gsm = tbgsm.Text;
            dk.üye_eposta = tbmail.Text;
            dk.üye_eposta_türü = cmbmailtype.Text;
            db.SaveChanges();

            var üyeler = db.üyeler_1.ToList();
            üyedatagrid.DataSource = üyeler.ToList();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            üyeler_1 üyeler = new üyeler_1();
            tbusers.Text = üyedatagrid.CurrentRow.Cells[0].Value.ToString();
            tbadsoyad.Text = üyedatagrid.CurrentRow.Cells[1].Value.ToString();
            cmbclass.Text = üyedatagrid.CurrentRow.Cells[2].Value.ToString();

            if (üyedatagrid.CurrentRow.Cells[3].Value.ToString().Equals("E"))
                rdbtne.Checked = true;
            else
               rdbtnk.Checked = true;
            
            

            tbgsm.Text = üyedatagrid.CurrentRow.Cells[4].Value.ToString();
            tbmail.Text = üyedatagrid.CurrentRow.Cells[5].Value.ToString();
            cmbmailtype.Text = üyedatagrid.CurrentRow.Cells[6].Value.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            İşlem_Paneli islempaneli = new İşlem_Paneli();
            islempaneli.Show();
            this.Hide();
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

        private void üyeislemleri_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SelectNextControl(sender as Control, true, true, true, true);
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    e.Handled = true;
                    button2.PerformClick();
                    break;
            }
        }

        private void üyegroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (arapanel1.Visible == false)
            {
                btnarama.Text = "Arama İşlemlerini Kapat";
                arapanel1.Visible = true;
            }
            else
            {
                btnarama.Text = "Arama işlemlerini Aç";
                arapanel1.Visible = false;
            }
        }

        private void adtext_TextChanged(object sender, EventArgs e)
        {
            string gelenad = adtext.Text;
            var bulunankaynak = db.üyeler_1.Where(x => x.üye_adsoyad.Contains(gelenad)).ToList();
            üyedatagrid.DataSource = bulunankaynak;
        }

        private void tbusers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbgsm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

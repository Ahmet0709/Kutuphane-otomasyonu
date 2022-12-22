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
    public partial class İşlem_Paneli : Form
    {
        Kutuphane_OtomasyonuEntities1 db = new Kutuphane_OtomasyonuEntities1();
        public İşlem_Paneli()
        {
            InitializeComponent();
        }
       
        private void kitaplarbtn_Click(object sender, EventArgs e)
        {
            Kitapişlemleri kitapişlemleri = new Kitapişlemleri();
            kitapişlemleri.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            üyeislemleri üyeislem = new üyeislemleri();
            üyeislem.Show();
            this.Hide();
        }

        private void odncverbtn_Click(object sender, EventArgs e)
        {
            ödünçkitaplar ödünç = new ödünçkitaplar();
            ödünç.Show();
            this.Hide();
        }

        private void İşlem_Paneli_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/folders/15zM9-VEohVuh_hlZuqF6_LsDcsf4Q2hQ");
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://seltem.meb.k12.tr/");
            linkLabel2.LinkVisited = true;        
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://seltem.meb.k12.tr/tema/okulumuz_hakkinda.html");
            linkLabel3.LinkVisited = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();

            label2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
 
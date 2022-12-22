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
    
    public partial class Kişisec : Form
    {
        Kutuphane_OtomasyonuEntities db = new Kutuphane_OtomasyonuEntities();
        public Kişisec()
        {
            InitializeComponent();
        }
        private void Kişisec_Load(object sender, EventArgs e)
        { 
            var üyeler = db.üyeler_1.ToList();
            dataGridView1.DataSource = üyeler.ToList();
        }
    }
}

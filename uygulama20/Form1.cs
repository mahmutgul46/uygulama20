using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBagla_Click(object sender, EventArgs e)
        {
            Ogrenciler ogrenci = new Ogrenciler();
            ogrenci.Numara = 571;
            ogrenci.AdSoyad = "Mahmut Gül";
            ogrenci.Alan = "Bilişim Teknolojileri";
            txtNumara.DataBindings.Add("Text",ogrenci,"Numara");
            txtAdsoyad.DataBindings.Add("Text", ogrenci, "AdSoyad");
            txtAlan.DataBindings.Add("Text", ogrenci, "Alan");
        }
    }
}

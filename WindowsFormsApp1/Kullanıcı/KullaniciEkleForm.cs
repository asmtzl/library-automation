using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProje
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Kutuphane1Entities db = new Kutuphane1Entities();
        public void Listele()
        {
            // listele methodu
            var kullanıcılar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanıcılar.ToList();
            //kolon adı düzenle
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Kullanıcı Id";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[2].HeaderText = "Kullanıcı Soyadı";
            dataGridView1.Columns[3].HeaderText = "Kullanıcı No";
            dataGridView1.Columns[4].HeaderText = "Kullanıcı Cinsyet";
            dataGridView1.Columns[5].HeaderText = "Kullanıcı Telefon No";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // textbox değerlerini la ve yeni kulanıcı oluştur
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.kullanici_ad = KullaniciAdtxt.Text;
            kullanicilar.kullanici_soyad = KullaniciSoyadtxt.Text;
            kullanicilar.kullanici_no = KullaniciNotxt.Text;
            kullanicilar.kullanici_tel = KullaniciTeltxt.Text;
            if (radioE.Checked = true)
            {
                kullanicilar.kullanici_cinsiyet = "E";
            }
            else if (radioK.Checked = true)
            {
                kullanicilar.kullanici_cinsiyet = "K";
            }
            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
        }

        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

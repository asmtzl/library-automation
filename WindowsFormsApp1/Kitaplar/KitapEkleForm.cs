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
    public partial class KitapEkleForm : Form
    {
        public KitapEkleForm()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            // listele moethodu
            var kitaplar = db.kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
            //kolon adı düzenle
            dataGridView1.Columns[0].HeaderText = "Kitap ID";
            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Kitap Yazarı";
            dataGridView1.Columns[3].HeaderText = "Kitap Yayıncı";
            dataGridView1.Columns[4].HeaderText = "Kitap Sayfa Sayısı";
            dataGridView1.Columns[5].HeaderText = "Kitap Basım Tarihi";
            dataGridView1.Columns[6].Visible = false;
        }
        Kutuphane1Entities db = new Kutuphane1Entities();
        private void button1_Click(object sender, EventArgs e)
        {
            // textbox değerlerini alarak yeni kitap oluştur
            kitaplar kitaplar = new kitaplar();
            kitaplar.kitap_ad = KitapAdtxt.Text;
            kitaplar.kitap_yazar = KitapYazartxt.Text;
            kitaplar.kitap_yayıncı = KitapYayımcıtxt.Text;
            kitaplar.kitap_sayfasayisi = Convert.ToInt32(numericUpDown1.Value);
            kitaplar.kitap_basimtarihi = dateTimePicker1.Value;
            db.kitaplar.Add(kitaplar);
            db.SaveChanges();

            var kitapliste = db.kitaplar.ToList();
            dataGridView1.DataSource = kitapliste.ToList();
            //kolon adı düzenle
            dataGridView1.Columns[0].HeaderText = "Kitap ID";
            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Kitap Yazarı";
            dataGridView1.Columns[3].HeaderText = "Kitap Yayıncı";
            dataGridView1.Columns[4].HeaderText = "Kitap Sayfa Sayısı";
            dataGridView1.Columns[5].HeaderText = "Kitap Basım Tarihi";
            dataGridView1.Columns[6].Visible = false;
        }

        private void KitapEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

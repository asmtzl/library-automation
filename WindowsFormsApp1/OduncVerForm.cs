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
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }
        Kutuphane1Entities db = new Kutuphane1Entities();
        private void OduncVerForm_Load(object sender, EventArgs e)
        {
            //kayıtları lstele
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            //kitapları listele
            var kitaplist = db.kitaplar.ToList();
            dataGridView2.DataSource = kitaplist.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kullanici bul
            string aranankullanici = KullaniciBul.Text;
            var kullanicivarmi = db.Kullanicilar.Where(x => x.kullanici_ad == aranankullanici).FirstOrDefault();
            if(kullanicivarmi!=null)
            {
                label2.Text = kullanicivarmi.kullanici_ad +" "+ kullanicivarmi.kullanici_soyad+" "+kullanicivarmi.kullanici_no;
            }
            else
            {
                label2.Text = "Kullanıcı Bulunamadı";
            }
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //kitaplarda arama
            string gelenAd = textBox1.Text;
            var bulunankitaplar = db.kitaplar.Where(x => x.kitap_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunankitaplar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kullanici seç
            string secilenkullanici = KullaniciBul.Text;
            var secilenkisi = db.Kullanicilar.Where(x => x.kullanici_ad.Equals(secilenkullanici)).FirstOrDefault();
            
            //kitap seç
            int secilenkitapId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenkitap = db.kitaplar.Where(x => x.kitap_id == secilenkitapId).FirstOrDefault();

            // yeni kayıt ekle
            Kayitlar yenikayit = new Kayitlar();
            yenikayit.kitap_id = secilenkitap.kitap_id;
            yenikayit.kullanici_id = secilenkisi.kullanici_id;
            yenikayit.alis_tarih = DateTime.Today;
            yenikayit.son_tarih = DateTime.Today.AddDays(15);
            yenikayit.durum = false;
            db.Kayitlar.Add(yenikayit);
            db.SaveChanges();

            // kayıtları listele
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();

        }

       
    }
}

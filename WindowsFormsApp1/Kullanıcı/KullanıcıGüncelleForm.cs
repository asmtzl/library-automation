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
    public partial class KullanıcıGüncelleForm : Form
    {
        public KullanıcıGüncelleForm()
        {
            InitializeComponent();
        }
        Kutuphane1Entities db = new Kutuphane1Entities();
        public void Listele()
        {
            //listele methodu
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
            //kolon adı düzenle
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Kullanıcı Id";
            dataGridView1.Columns[1].HeaderText = "Kullanıcı Adı";
            dataGridView1.Columns[2].HeaderText = "Kullanıcı Soyadı";
            dataGridView1.Columns[3].HeaderText = "Kullanıcı No";
            dataGridView1.Columns[4].HeaderText = "Kullanıcı Cinsyet";
            dataGridView1.Columns[5].HeaderText = "Kullanıcı Telefon No";

        }

        private void KullanıcıGüncelleForm_Load(object sender, EventArgs e)
        {
            
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagrid değerlerini textboxlara aktar
            KullaniciAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            KullaniciSoyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            KullaniciNotxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            KullaniciTeltxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if(dataGridView1.CurrentRow.Cells[4].Value.ToString().Equals("E"))
            {
                radioE.Checked = true;
            }
            else
            {
                radioK.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textbox değerlerini database kaydet
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();
            kullanici.kullanici_ad = KullaniciAdtxt.Text;
            kullanici.kullanici_soyad = KullaniciSoyadtxt.Text;
            kullanici.kullanici_no = KullaniciNotxt.Text;
            kullanici.kullanici_tel = KullaniciTeltxt.Text;
            
            if(radioK.Checked == true)
            {
                kullanici.kullanici_cinsiyet = "K";
            }
            else if (radioE.Checked == true)
            {
                kullanici.kullanici_cinsiyet = "E";
            }
            
            
            db.SaveChanges();
            Listele();
        }
    }
}

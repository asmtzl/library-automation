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
    public partial class KullanıcıSil : Form
    {
        public KullanıcıSil()
        {
            InitializeComponent();
        }
        Kutuphane1Entities db = new Kutuphane1Entities();
        public void Listele()
        {

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

        private void KullanıcıSil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult silinsinMi = MessageBox.Show("Kullanıcıyı silmek istediğinizden emin misiniz?","Sil",MessageBoxButtons.YesNo);
            if(silinsinMi == DialogResult.Yes)
            {
                
                int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var kullanici = db.Kullanicilar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();
                var kontrol = db.Kayitlar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();
                if (kontrol != null)
                {
                    MessageBox.Show("Kullanıcı Silinemez, Kullanıcıda kitap kayıtlıdır");
                }
                else
                {
                    db.Kullanicilar.Remove(kullanici);
                    db.SaveChanges();
                    Listele();
                    MessageBox.Show("Kullanıcı Silindi");
                }
                
                
                
            }
            

            
        }
    }
}

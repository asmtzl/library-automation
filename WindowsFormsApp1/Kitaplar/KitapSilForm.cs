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
    public partial class KitapSilForm : Form
    {
        public KitapSilForm()
        {
            InitializeComponent();
        }
        Kutuphane1Entities db = new Kutuphane1Entities();
        private void KitapSilForm_Load(object sender, EventArgs e)
        {
            //  kitapları listele
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

        private void button1_Click(object sender, EventArgs e)
        {
            //datagridden kitap seç ve sil
            int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var silinenKitap = db.kitaplar.Where(x => x.kitap_id == secilenId).FirstOrDefault();
            db.kitaplar.Remove(silinenKitap);
            db.SaveChanges();

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
    }
}

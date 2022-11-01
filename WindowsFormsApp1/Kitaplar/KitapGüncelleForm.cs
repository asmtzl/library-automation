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
    public partial class KitapGüncelleForm : Form
    {
        public KitapGüncelleForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        Kutuphane1Entities db = new Kutuphane1Entities();
        private void KitapGüncelleForm_Load(object sender, EventArgs e)
        {
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // data grid değerlerini textboxa aktar
            KitapAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            KitapYazartxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            KitapYayımcıtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //bilgileri güncelle ve database kaydet
            int secilenKitap = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var guncellenecekKitap = db.kitaplar.Where(x => x.kitap_id == secilenKitap).FirstOrDefault();
            guncellenecekKitap.kitap_ad = KitapAdtxt.Text;
            guncellenecekKitap.kitap_yazar = KitapYazartxt.Text;
            guncellenecekKitap.kitap_yayıncı = KitapYayımcıtxt.Text;
            guncellenecekKitap.kitap_sayfasayisi = Convert.ToInt32(numericUpDown1.Value);
            guncellenecekKitap.kitap_basimtarihi = dateTimePicker1.Value;
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

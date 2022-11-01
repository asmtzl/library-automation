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
    public partial class KitapListeForm : Form
    {
        public KitapListeForm()
        {
            InitializeComponent();
        }

        Kutuphane1Entities db = new Kutuphane1Entities();
        private void KitapListeForm_Load(object sender, EventArgs e)
        {
            // kitap listele

            var kitaplar = db.kitaplar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
            //kolon adı düzenle
            dataGridView1.Columns[0].HeaderText = "Kitap ID";
            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Kitap Yazarı";
            dataGridView1.Columns[3].HeaderText = "Kitap Yayıncı";
            dataGridView1.Columns[4].HeaderText = "Kitap Sayfa Sayısı";
            dataGridView1.Columns[5].HeaderText = "Kitap Basım Tarihi";
            dataGridView1.Columns[6].Visible=false;
        }
    }
}

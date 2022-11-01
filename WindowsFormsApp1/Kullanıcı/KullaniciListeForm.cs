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
    public partial class KullaniciListeForm : Form
    {
        public KullaniciListeForm()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            Kutuphane1Entities db = new Kutuphane1Entities();
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
        private void KullaniciListeForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

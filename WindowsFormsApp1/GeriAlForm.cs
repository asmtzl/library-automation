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
    public partial class GeriAlForm : Form
    {
        public GeriAlForm()
        {
            InitializeComponent();
        }
        Kutuphane1Entities db = new Kutuphane1Entities();
        private void GeriAlForm_Load(object sender, EventArgs e)
        {
            // kayıtları listele
            var kayitlar = db.Kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //secilen kayıt durum değiştir
            int secilenKayitId =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.Kayitlar.Where(x => x.kayit_id == secilenKayitId).FirstOrDefault();
            kayit.durum = true;
            db.SaveChanges();

            var kayitlar = db.Kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();


        }
    }
}

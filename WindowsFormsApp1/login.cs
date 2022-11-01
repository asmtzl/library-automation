using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProje;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Kutuphane1Entities db = new  Kutuphane1Entities();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void girisbtn_Click(object sender, EventArgs e)
        {
            
            string gelenkullaniciadi = kullanıcıtxt.Text;
            string gelensifre = sifretxt.Text;

            var personel = db.Personeller.Where(x=> x.personel_kullanıcıadi.Equals(gelenkullaniciadi) && x.personel_sifre.Equals(gelensifre)).FirstOrDefault();
            if(personel == null)
            {
                MessageBox.Show(text: "Kullanıcı adı ya da şifre yanlış");
            }
            else
            {
                MessageBox.Show(text: "Giriş Başarılı");
                islempaneli panel = new islempaneli();
                panel.Show();
                this.Hide();
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

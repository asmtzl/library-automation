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
    public partial class islempaneli : Form
    {
        public islempaneli()
        {
            InitializeComponent();
        }
         Kutuphane1Entities db = new Kutuphane1Entities();
        
        private void islempaneli_Load(object sender, EventArgs e)
        {
            //kullanici butonları
            eklekullanicibtn.Visible = false;
            guncellekullanicibtn.Visible = false;
            silkullanicibtn.Visible = false;
            //kitap butonları
            kitapeklebtn.Visible = false;
            kitapgnclbtn.Visible = false;
            kitapsilbtn.Visible = false;
        }
        //kullanıcı listele butonu aç kapat
        KullaniciListeForm klisteform; 
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (eklekullanicibtn.Visible == false)
            {
                eklekullanicibtn.Visible = true;
                guncellekullanicibtn.Visible = true;
                silkullanicibtn.Visible = true;
                klisteform = new KullaniciListeForm();
                klisteform.MdiParent = this;
                klisteform.Show();
            }
            else
            {
                eklekullanicibtn.Visible = false;
                guncellekullanicibtn.Visible = false;
                silkullanicibtn.Visible = false;
                klisteform.Close();
            }
            
        }
        //kullanıcı ekle butonu parent ata, aç, kapat
        private KullaniciEkleForm ekleform;
        private bool ekleKullaniciDurum = false;
        private void eklekullanicibtn_Click(object sender, EventArgs e)
        {
            
            if(ekleKullaniciDurum==false)
            {
               ekleform = new KullaniciEkleForm();
                ekleform.MdiParent = this;
                ekleform.Show();
                ekleKullaniciDurum = true;
            }
            else
            {
                ekleform.Close();
                ekleKullaniciDurum = false;
            }
            
        }
        //kullanıcı sil butonu paretn ata, aç , kapat
        private KullanıcıSil kullaniciSil; 
        private bool silKullaniciDurum = false;
        private void silkullanicibtn_Click(object sender, EventArgs e)
        {
            if(silKullaniciDurum==false)
            {
                kullaniciSil = new KullanıcıSil();
                kullaniciSil.MdiParent = this;
                kullaniciSil.Show();
                silKullaniciDurum = true;
            }
            else
            {
                kullaniciSil.Close();
                silKullaniciDurum = false;
            }
            
        }
        //kullanıcı güncelle butonu parent ata, aç, kapat
        private KullanıcıGüncelleForm kguncel;
        private bool guncelleKullaniciDurum = false;
        private void guncellekullanicibtn_Click(object sender, EventArgs e)
        {
            
            
            if (guncelleKullaniciDurum==false)
            {
                kguncel = new KullanıcıGüncelleForm();
                kguncel.MdiParent = this;
                kguncel.Show();
                guncelleKullaniciDurum = true;
            }
            else
            {
                kguncel.Close();
                guncelleKullaniciDurum = false;
            }
            
        }
        //kitap listele butonu parent ata, açi kapat
        KitapListeForm kliste;
        private void kitaplarbtn_Click(object sender, EventArgs e)
        {
            if (kitapeklebtn.Visible == false)
            {
                kitapeklebtn.Visible = true;
                kitapgnclbtn.Visible = true;
                kitapsilbtn.Visible = true;
                kliste = new KitapListeForm();
                kliste.MdiParent = this;
                kliste.Show();
            }
            else
            {
                kitapeklebtn.Visible = false;
                kitapgnclbtn.Visible = false;
                kitapsilbtn.Visible = false;
                kliste.Close();
            }
            
            
        }
        //kitap ekle butonu parent ata, açi kapat
        private KitapEkleForm kEkle;
        private bool kitapEkleDurum = false;
        private void kitapeklebtn_Click(object sender, EventArgs e)
        {
            if(kitapEkleDurum==false)
            {
                kEkle = new KitapEkleForm();
                kEkle.MdiParent = this;
                kEkle.Show();
                kitapEkleDurum = true;
            }
            else
            {
                kEkle.Close();
                kitapEkleDurum = false;
            }
           
        }
        //kitap sil butonu parent ata, açi kapat
        private KitapSilForm kitapSil;
        private bool kitapSilDurum = false;
        private void kitapsilbtn_Click(object sender, EventArgs e)
        {
            if(kitapSilDurum==false)
            {
                kitapSil = new KitapSilForm();
                kitapSil.MdiParent = this;
                kitapSil.Show();
                kitapSilDurum = true;
            }
            else
            {
                kitapSil.Close();
                kitapSilDurum = false;
            }
            
        }
        //kitap güncelle butonu parent ata, açi kapat
        private KitapGüncelleForm kitapGuncel; 
        private bool kitapGuncelDurum = false;
        private void kitapgnclbtn_Click(object sender, EventArgs e)
        {
            if(kitapGuncelDurum==false)
            {
                kitapGuncel = new KitapGüncelleForm();
                kitapGuncel.MdiParent = this;
                kitapGuncel.Show();
                kitapGuncelDurum = true;
            }
            else
            {
                kitapGuncel.Close();
                kitapGuncelDurum = false;
            }
            
        }
        //odunc ver butonu parent ata, aç, kapat
        private OduncVerForm odunc;
        private bool oduncVerDurum = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if(oduncVerDurum==false)
            {
                odunc = new OduncVerForm();
                odunc.MdiParent = this;
                odunc.Show();
                oduncVerDurum = true;
            }
            else
            {
                odunc.Close();
                oduncVerDurum = false;
            }
            
        }
        //geri al butonu parent ata, aç, kapat
        private GeriAlForm geri; 
        private bool geriDurum = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if(geriDurum==false)
            {
                geri = new GeriAlForm();
                geri.MdiParent = this;
                geri.Show();
                geriDurum = true;
            }
            else
            {
                geri.Close();
                geriDurum = false;
            }
            
        }
    }
}

using Otel_Rezervasyon_Sistemi.BLL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Otel_Rezervasyon_Sistemi.Formlar
{
    public partial class GirisYap : Form
    {
        List<KayitliUye> kayitliUye = new List<KayitliUye>();
        List<Yoneticiler> kayitliYonetici = new List<Yoneticiler>();
        KayitliUyeController KayitliUyeController = new KayitliUyeController();
        MusteriEkran MusteriEkran;
        RezervasyonYap RezervasyonYap;
        MusteriRezervasyonlar MusteriRezervasyonlar;
        Yonetici Yonetici;
        YoneticiController YoneticiController = new YoneticiController();
        public AnaEkran AnaEkran;
       

        bool _girisOnay;

        public GirisYap()
        {
            InitializeComponent();
        }

        
       

        private void btnGeriDon_Click_1(object sender, EventArgs e)
        {
            AnaEkran.Visible = true;
            AnaEkran.Show();
            AnaEkran.BringToFront();
            this.Close();
        }

        private void btnGirisYap_Click_1(object sender, EventArgs e)
        {
            kayitliUye = KayitliUyeController.KayitliUyeleriGetir();
            kayitliYonetici = YoneticiController.YoneticileriGetir();

            foreach (var item in kayitliUye)
            {
                if (item.Mail == txtEmail.Text && item.Sifre == txtSifre.Text)
                {
                    MusteriEkran = new MusteriEkran();
                    RezervasyonYap = new RezervasyonYap();
                    MusteriRezervasyonlar = new MusteriRezervasyonlar();
                    MusteriEkran.Show();
                    MusteriEkran.BringToFront();
                    RezervasyonYap.kayitliUyeID = item.KayitliUyeID;
                    MusteriRezervasyonlar._kayitliUyeID = item.KayitliUyeID;
                    this.Visible = false;
                    _girisOnay = true;
                    break;
                }
            }
            foreach (var item1 in kayitliYonetici)
            {
                if (txtEmail.Text == item1.Email && txtSifre.Text == item1.Sifre)
                {
                    Yonetici = new Yonetici();
                    Yonetici.Show();
                    Yonetici.BringToFront();
                    this.Visible = false;
                    _girisOnay = true;
                    break;
                }
            }
            if (_girisOnay == false)
            {
                MessageBox.Show("Lütfen Bilgileri Kontrol Edip Tekrar Deneyiniz.!");
            }
        }

        private void GirisYap_Load(object sender, EventArgs e)
        {

        }
    }
            
}


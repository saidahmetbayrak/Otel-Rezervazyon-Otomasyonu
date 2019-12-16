using Otel_Rezervasyon_Sistemi.BLL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Otel_Rezervasyon_Sistemi.Formlar
{
    public partial class MusteriRezervasyonlar : Form
    {
        public MusteriRezervasyonlar()
        {
          
            InitializeComponent();
            
        }

        KayitliUyeController kayitliUyeController = new KayitliUyeController();
        List<KayitliUye> kayitliUye = new List<KayitliUye>();
        RezervasyonController RezervasyonController = new RezervasyonController();
        MusteriController MusteriController = new MusteriController();
        OdaController OdaController = new OdaController();
        public MusteriEkran MusteriEkran;

        public static int _kayitliUyeID = 0;
        DateTime girisTarihi;
        int rezervasyonID;
        int odaID;
        

        private void MusteriRezervasyonlar_Load(object sender, EventArgs e)
        {
            this.rezervasyon_TabloTableAdapter.Fill(this.otelRezervasyonDataSet.Rezervasyon_Tablo);

         
            dgvMusteriRez.DataSource = kayitliUyeController.KayitliUyeAitGecmisRezervasyon(_kayitliUyeID);


        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            girisTarihi = (DateTime)dgvMusteriRez.CurrentRow.Cells[3].Value;
            rezervasyonID = (int)dgvMusteriRez.CurrentRow.Cells[0].Value;
            odaID = (int)dgvMusteriRez.CurrentRow.Cells[9].Value;
            TimeSpan gunFarki = girisTarihi - DateTime.Now;
            double kalanGun = gunFarki.TotalDays;

            if (kalanGun >= 7 )
            {
                RezervasyonController.RezervasyonlariSil(rezervasyonID);
                OdaController.OdaDurumBos(odaID);
                dgvMusteriRez.DataSource = kayitliUyeController.KayitliUyeAitGecmisRezervasyon(_kayitliUyeID);

                MessageBox.Show("Rezervasyonunuz Başarı ile İptal Edilmiştir.");
            }
            else
            {
                MessageBox.Show("1 Hafta Öncesine Kadar Olan Rezervasyonlarınızı İptal Edebilirsiniz.!");
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            MusteriEkran.Visible = true;
            MusteriEkran.Show();
            MusteriEkran.BringToFront();
            this.Close();
        }
    }
}

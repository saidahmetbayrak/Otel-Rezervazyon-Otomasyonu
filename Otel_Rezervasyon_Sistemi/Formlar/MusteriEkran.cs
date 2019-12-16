using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon_Sistemi.Formlar
{
    public partial class MusteriEkran : Form
    {
        public MusteriEkran()
        {
            InitializeComponent();
        }
        RezervasyonYap RezervasyonYap;
        MusteriRezervasyonlar MusteriRezervasyonlar;

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            RezervasyonYap = new RezervasyonYap();
            RezervasyonYap.Show();
            RezervasyonYap.BringToFront();
            this.Visible = false;
        }

        private void btnGecmisRez_Click(object sender, EventArgs e)
        {
            MusteriRezervasyonlar = new MusteriRezervasyonlar();
            MusteriRezervasyonlar.Show();
            MusteriRezervasyonlar.BringToFront();
            MusteriRezervasyonlar.MusteriEkran = this;
            this.Visible = false;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

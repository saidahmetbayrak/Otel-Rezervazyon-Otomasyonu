using Otel_Rezervasyon_Sistemi.BLL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Otel_Rezervasyon_Sistemi.Formlar
{
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }

        RezervasyonYap RezervasyonYap = new RezervasyonYap();
        FiyatController fiyatController = new FiyatController();
        Oda Oda = new Oda();
        OdaController OdaController = new OdaController();
        Musteri Musteri = new Musteri();
        int c = 0;
        int y = 0;
        int sayac = 0;
        Button button;
        List<string> musteriListe;
        string a = string.Empty;
        string b = string.Empty;

        private void Yonetici_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otelRezervasyonDataSet.Musteri_Tablo' table. You can move, or remove it, as needed.
           // this.musteri_TabloTableAdapter.Fill(this.otelRezervasyonDataSet.Musteri_Tablo);
           // RezervasyonYap.Yonetici = this;
            cmbOranlar.DataSource = fiyatController.FiyatlariGetir();
            cmbOranlar.DisplayMember = "FiyatTipi";
            cmbOranlar.ValueMember = "FiyatID";

            

        }

        private void btnOranDegistir_Click(object sender, EventArgs e)
        {
            int fiyatID = (int)cmbOranlar.SelectedValue;
            decimal fiyat = Convert.ToDecimal(txtOranlar.Text);
            fiyatController.FiyatGuncelle(fiyatID, fiyat);
        }

        private void cmbOranlar_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= cmbOranlar.Items.Count; i++)
            {
                if (cmbOranlar.SelectedIndex == i - 1)
                {
                    txtOranlar.Text = fiyatController.FiyatGetirID(i).ToString();
                }
            }



        }

        //private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        //{
        //    //if (nudOdaSayisi.Value >= sayac)
        //    //{
        //    //    c++;
        //    //    sayac++;
        //    //    Button button = new Button();
        //    //    button.Left = 50*c;
        //    //    if (c%6==0)
        //    //    {
        //    //        y += 50;
        //    //        button.Left = 50;
        //    //        c = 1;
        //    //    }
        //    //    button.Top = 10 + y;
        //    //    button.Size = new Size(50, 50);
        //    //    button.Name = "button1_" + sayac.ToString();

        //    //    grpOdalar.Controls.Add(button);
        //    //}
        //    //else
        //    //{
        //    //    grpOdalar.Controls.RemoveByKey("button1_" + sayac.ToString());
        //    //    sayac--;
        //    //}
        //}

        private void btnOdaYarat_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < nudOdaSayisi.Value; i++)
            {
                if ((nudOdaSayisi.Value >= sayac))
                {
                    c++;
                    sayac++;
                    button = new Button();
                    button.Left = 50 * c;
                    if (c % 5 == 0)
                    {
                        y += 50;
                        button.Left = 50;
                        c = 1;
                    }
                    button.Top = 25 + y;
                    button.Size = new Size(50, 50);
                    button.Name = "button_" + sayac.ToString();
                    button.Text = $"Oda {sayac}";
                    grpOdalar.Controls.Add(button);
                    if ((OdaController.OdaNumarasi(sayac) != button.Text) && OdaController.OdaIDGetir() != sayac)
                    {
                        Oda.OdaNumarasi = button.Text;
                        OdaController.OdaEkle(Oda);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            y = 0;
            c = 0;
            sayac = 0;
        }



        private void btnOdaDurum_Click(object sender, EventArgs e)
        {
            cmbBosOdalar.DataSource = null;
            cmbDoluOdalar.DataSource = null;
            cmbDoluOdalar.DataSource = OdaController.TarihAralıgınaGoreDoluOdalar(dtpGirisTarihi.Value.Date, dtpCikisTarihi.Value.Date);
            cmbBosOdalar.DataSource = OdaController.TarihAralıgınaGoreBosOdalar(dtpGirisTarihi.Value.Date, dtpCikisTarihi.Value.Date);

        }


        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoluOda_Click_1(object sender, EventArgs e)
        {
            lstMusteri.Items.Clear();
            musteriListe = OdaController.TarihAralıgınaGoreDoluOdalardaKalacakMusteriler(dtpGirisTarihi.Value.Date, dtpCikisTarihi.Value.Date);

            foreach (var item in musteriListe)
            {
                lstMusteri.Items.Add(new ListViewItem(item));
            }

        }
    }
}


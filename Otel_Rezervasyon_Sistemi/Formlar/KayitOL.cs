using Otel_Rezervasyon_Sistemi.BLL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon_Sistemi.Formlar
{
    public partial class KayitOL : Form
    {
        public KayitOL()
        {
            InitializeComponent();
        }
        KayitliUye kayitliUye;
        KayitliUyeController KayitliUyeController = new KayitliUyeController();
        Regex regexItem = new Regex("^[a-zA-Z0-9]*$");
        public AnaEkran AnaEkran;


        private void btnUyeOl_Click(object sender, EventArgs e)
        {
                txtEmail.Text = Regex.Replace(txtEmail.Text, @"\s+", "");

                if (txtEmail.Text.Contains("@gmail.com") || txtEmail.Text.Contains("@hotmail.com"))
                {
                    if (txtSifre.Text.Length >=8 && txtSifre.Text.Length <= 16 )
                    {
                        if (regexItem.IsMatch(txtSifre.Text))
                        {
                        if (txtEmail.Text != KayitliUyeController.KayitliUyeMail(txtEmail.Text))
                        {
                            kayitliUye = new KayitliUye();
                            kayitliUye.Mail = txtEmail.Text;
                            kayitliUye.Sifre = txtSifre.Text;
                            KayitliUyeController.KayitliUyeEkle(kayitliUye);
                            MessageBox.Show("Başarıyla Kayıt Oldunuz.");
                        }
                        else
                        {
                            MessageBox.Show("Girdiğiniz Bilgilerde Üye Bulunmaktadır.");
                        }
                       
                        }
                        else
                        {
                        MessageBox.Show("Lütfen Şifrenizde Özel Karakter Kullanmayınız.!");
                        }
                    }
                    else
                    {
                     MessageBox.Show("Lütfen 8 ile 16 haneli şifre giriniz.!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Mail Adresinizi Kontrol Edip Tekrar Deneyinizi.");
                   
                }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            AnaEkran.Visible = true;
            AnaEkran.Show();
            AnaEkran.BringToFront();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //karakteri göster.
                txtSifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
    }
}

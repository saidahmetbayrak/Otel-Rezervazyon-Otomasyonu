namespace Otel_Rezervasyon_Sistemi.Formlar
{
    partial class Yonetici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici));
            this.cmbOranlar = new System.Windows.Forms.ComboBox();
            this.txtOranlar = new System.Windows.Forms.TextBox();
            this.btnOranDegistir = new System.Windows.Forms.Button();
            this.nudOdaSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblOdaSayisi = new System.Windows.Forms.Label();
            this.grpOdalar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdaYarat = new System.Windows.Forms.Button();
            this.musteriTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelRezervasyonDataSet = new Otel_Rezervasyon_Sistemi.OtelRezervasyonDataSet();
            this.musteri_TabloTableAdapter = new Otel_Rezervasyon_Sistemi.OtelRezervasyonDataSetTableAdapters.Musteri_TabloTableAdapter();
            this.btnOdaDurum = new System.Windows.Forms.Button();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblGiris = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.lstMusteri = new System.Windows.Forms.ListView();
            this.Musteriler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCikisYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBosOdalar = new System.Windows.Forms.ComboBox();
            this.cmbDoluOdalar = new System.Windows.Forms.ComboBox();
            this.btnDoluOda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelRezervasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOranlar
            // 
            this.cmbOranlar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOranlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOranlar.FormattingEnabled = true;
            this.cmbOranlar.Location = new System.Drawing.Point(179, 133);
            this.cmbOranlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOranlar.Name = "cmbOranlar";
            this.cmbOranlar.Size = new System.Drawing.Size(160, 24);
            this.cmbOranlar.TabIndex = 0;
            this.cmbOranlar.SelectedValueChanged += new System.EventHandler(this.cmbOranlar_SelectedValueChanged);
            // 
            // txtOranlar
            // 
            this.txtOranlar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOranlar.Location = new System.Drawing.Point(348, 134);
            this.txtOranlar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOranlar.Name = "txtOranlar";
            this.txtOranlar.Size = new System.Drawing.Size(132, 22);
            this.txtOranlar.TabIndex = 1;
            // 
            // btnOranDegistir
            // 
            this.btnOranDegistir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOranDegistir.BackColor = System.Drawing.Color.Silver;
            this.btnOranDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOranDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOranDegistir.ForeColor = System.Drawing.Color.Black;
            this.btnOranDegistir.Location = new System.Drawing.Point(179, 182);
            this.btnOranDegistir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOranDegistir.Name = "btnOranDegistir";
            this.btnOranDegistir.Size = new System.Drawing.Size(164, 39);
            this.btnOranDegistir.TabIndex = 2;
            this.btnOranDegistir.Text = "ORAN DEĞİŞTİR";
            this.btnOranDegistir.UseVisualStyleBackColor = false;
            this.btnOranDegistir.Click += new System.EventHandler(this.btnOranDegistir_Click);
            // 
            // nudOdaSayisi
            // 
            this.nudOdaSayisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudOdaSayisi.Location = new System.Drawing.Point(231, 319);
            this.nudOdaSayisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudOdaSayisi.Name = "nudOdaSayisi";
            this.nudOdaSayisi.Size = new System.Drawing.Size(160, 22);
            this.nudOdaSayisi.TabIndex = 3;
            // 
            // lblOdaSayisi
            // 
            this.lblOdaSayisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdaSayisi.AutoSize = true;
            this.lblOdaSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaSayisi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblOdaSayisi.Location = new System.Drawing.Point(12, 319);
            this.lblOdaSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOdaSayisi.Name = "lblOdaSayisi";
            this.lblOdaSayisi.Size = new System.Drawing.Size(176, 20);
            this.lblOdaSayisi.TabIndex = 4;
            this.lblOdaSayisi.Text = "Oda Sayısı Ayarla =";
            // 
            // grpOdalar
            // 
            this.grpOdalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpOdalar.Location = new System.Drawing.Point(507, 73);
            this.grpOdalar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOdalar.Name = "grpOdalar";
            this.grpOdalar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOdalar.Size = new System.Drawing.Size(404, 369);
            this.grpOdalar.TabIndex = 5;
            this.grpOdalar.TabStop = false;
            this.grpOdalar.Text = "ODALAR";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fiyatları Ayarla =";
            // 
            // btnOdaYarat
            // 
            this.btnOdaYarat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaYarat.BackColor = System.Drawing.Color.Silver;
            this.btnOdaYarat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaYarat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaYarat.ForeColor = System.Drawing.Color.Black;
            this.btnOdaYarat.Location = new System.Drawing.Point(231, 366);
            this.btnOdaYarat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdaYarat.Name = "btnOdaYarat";
            this.btnOdaYarat.Size = new System.Drawing.Size(160, 38);
            this.btnOdaYarat.TabIndex = 7;
            this.btnOdaYarat.Text = "ODA YARAT";
            this.btnOdaYarat.UseVisualStyleBackColor = false;
            this.btnOdaYarat.Click += new System.EventHandler(this.btnOdaYarat_Click);
            // 
            // musteriTabloBindingSource
            // 
            this.musteriTabloBindingSource.DataMember = "Musteri_Tablo";
            this.musteriTabloBindingSource.DataSource = this.otelRezervasyonDataSet;
            // 
            // otelRezervasyonDataSet
            // 
            this.otelRezervasyonDataSet.DataSetName = "OtelRezervasyonDataSet";
            this.otelRezervasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteri_TabloTableAdapter
            // 
            this.musteri_TabloTableAdapter.ClearBeforeFill = true;
            // 
            // btnOdaDurum
            // 
            this.btnOdaDurum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOdaDurum.BackColor = System.Drawing.Color.Silver;
            this.btnOdaDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdaDurum.ForeColor = System.Drawing.Color.Black;
            this.btnOdaDurum.Location = new System.Drawing.Point(1035, 555);
            this.btnOdaDurum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdaDurum.Name = "btnOdaDurum";
            this.btnOdaDurum.Size = new System.Drawing.Size(267, 46);
            this.btnOdaDurum.TabIndex = 13;
            this.btnOdaDurum.Text = "ODALARI GÖR";
            this.btnOdaDurum.UseVisualStyleBackColor = false;
            this.btnOdaDurum.Click += new System.EventHandler(this.btnOdaDurum_Click);
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCikisTarihi.Location = new System.Drawing.Point(1035, 510);
            this.dtpCikisTarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(265, 22);
            this.dtpCikisTarihi.TabIndex = 14;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGirisTarihi.Location = new System.Drawing.Point(1035, 464);
            this.dtpGirisTarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(265, 22);
            this.dtpGirisTarihi.TabIndex = 15;
            // 
            // lblGiris
            // 
            this.lblGiris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGiris.AutoSize = true;
            this.lblGiris.BackColor = System.Drawing.Color.Transparent;
            this.lblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblGiris.Location = new System.Drawing.Point(897, 465);
            this.lblGiris.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(121, 20);
            this.lblGiris.TabIndex = 16;
            this.lblGiris.Text = "Giris Tarihi =";
            // 
            // lblCikis
            // 
            this.lblCikis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCikis.AutoSize = true;
            this.lblCikis.BackColor = System.Drawing.Color.Transparent;
            this.lblCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikis.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCikis.Location = new System.Drawing.Point(897, 510);
            this.lblCikis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(122, 20);
            this.lblCikis.TabIndex = 17;
            this.lblCikis.Text = "Çıkış Tarihi =";
            // 
            // lstMusteri
            // 
            this.lstMusteri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstMusteri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Musteriler});
            this.lstMusteri.HideSelection = false;
            this.lstMusteri.Location = new System.Drawing.Point(939, 73);
            this.lstMusteri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstMusteri.Name = "lstMusteri";
            this.lstMusteri.Size = new System.Drawing.Size(827, 368);
            this.lstMusteri.TabIndex = 22;
            this.lstMusteri.UseCompatibleStateImageBehavior = false;
            this.lstMusteri.View = System.Windows.Forms.View.Details;
            // 
            // Musteriler
            // 
            this.Musteriler.Text = "Dolu Odalardaki Musteri Listesi";
            this.Musteriler.Width = 426;
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCikisYap.BackColor = System.Drawing.Color.Silver;
            this.btnCikisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikisYap.ForeColor = System.Drawing.Color.Black;
            this.btnCikisYap.Location = new System.Drawing.Point(1548, 20);
            this.btnCikisYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(219, 38);
            this.btnCikisYap.TabIndex = 23;
            this.btnCikisYap.Text = "ÇIKIŞ YAP";
            this.btnCikisYap.UseVisualStyleBackColor = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(1628, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Bos Odalar";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(1411, 465);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Dolu Odalar";
            // 
            // cmbBosOdalar
            // 
            this.cmbBosOdalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBosOdalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBosOdalar.FormattingEnabled = true;
            this.cmbBosOdalar.Location = new System.Drawing.Point(1605, 492);
            this.cmbBosOdalar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBosOdalar.Name = "cmbBosOdalar";
            this.cmbBosOdalar.Size = new System.Drawing.Size(160, 24);
            this.cmbBosOdalar.TabIndex = 26;
            // 
            // cmbDoluOdalar
            // 
            this.cmbDoluOdalar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbDoluOdalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoluOdalar.FormattingEnabled = true;
            this.cmbDoluOdalar.Location = new System.Drawing.Point(1393, 492);
            this.cmbDoluOdalar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDoluOdalar.Name = "cmbDoluOdalar";
            this.cmbDoluOdalar.Size = new System.Drawing.Size(160, 24);
            this.cmbDoluOdalar.TabIndex = 25;
            // 
            // btnDoluOda
            // 
            this.btnDoluOda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoluOda.BackColor = System.Drawing.Color.Silver;
            this.btnDoluOda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoluOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoluOda.ForeColor = System.Drawing.Color.Black;
            this.btnDoluOda.Location = new System.Drawing.Point(1455, 555);
            this.btnDoluOda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDoluOda.Name = "btnDoluOda";
            this.btnDoluOda.Size = new System.Drawing.Size(267, 46);
            this.btnDoluOda.TabIndex = 24;
            this.btnDoluOda.Text = "MÜŞTERİLERİ LİSTELE";
            this.btnDoluOda.UseVisualStyleBackColor = false;
            this.btnDoluOda.Click += new System.EventHandler(this.btnDoluOda_Click_1);
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Otel_Rezervasyon_Sistemi.Properties.Resources.aa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1816, 766);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBosOdalar);
            this.Controls.Add(this.cmbDoluOdalar);
            this.Controls.Add(this.btnDoluOda);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.lstMusteri);
            this.Controls.Add(this.lblCikis);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.btnOdaDurum);
            this.Controls.Add(this.btnOdaYarat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpOdalar);
            this.Controls.Add(this.lblOdaSayisi);
            this.Controls.Add(this.nudOdaSayisi);
            this.Controls.Add(this.btnOranDegistir);
            this.Controls.Add(this.txtOranlar);
            this.Controls.Add(this.cmbOranlar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Yonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AA";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Yonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelRezervasyonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOranlar;
        private System.Windows.Forms.TextBox txtOranlar;
        private System.Windows.Forms.Button btnOranDegistir;
        private System.Windows.Forms.NumericUpDown nudOdaSayisi;
        private System.Windows.Forms.Label lblOdaSayisi;
        private System.Windows.Forms.GroupBox grpOdalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdaYarat;
        private OtelRezervasyonDataSet otelRezervasyonDataSet;
        private System.Windows.Forms.BindingSource musteriTabloBindingSource;
        private OtelRezervasyonDataSetTableAdapters.Musteri_TabloTableAdapter musteri_TabloTableAdapter;
        private System.Windows.Forms.Button btnOdaDurum;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.ListView lstMusteri;
        private System.Windows.Forms.ColumnHeader Musteriler;
        private System.Windows.Forms.Button btnCikisYap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBosOdalar;
        private System.Windows.Forms.ComboBox cmbDoluOdalar;
        private System.Windows.Forms.Button btnDoluOda;
    }
}
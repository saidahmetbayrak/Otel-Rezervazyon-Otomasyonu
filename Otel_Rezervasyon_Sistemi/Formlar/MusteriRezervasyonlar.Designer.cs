namespace Otel_Rezervasyon_Sistemi.Formlar
{
    partial class MusteriRezervasyonlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriRezervasyonlar));
            this.dgvMusteriRez = new System.Windows.Forms.DataGridView();
            this.rezervasyonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitliUyeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyonTipiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yatakSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervasyonTabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.otelRezervasyonDataSet = new Otel_Rezervasyon_Sistemi.OtelRezervasyonDataSet();
            this.rezervasyon_TabloTableAdapter = new Otel_Rezervasyon_Sistemi.OtelRezervasyonDataSetTableAdapters.Rezervasyon_TabloTableAdapter();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriRez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonTabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelRezervasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteriRez
            // 
            this.dgvMusteriRez.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMusteriRez.AutoGenerateColumns = false;
            this.dgvMusteriRez.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMusteriRez.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriRez.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervasyonIDDataGridViewTextBoxColumn,
            this.kayitliUyeIDDataGridViewTextBoxColumn,
            this.rezervasyonTipiIDDataGridViewTextBoxColumn,
            this.girisTarihiDataGridViewTextBoxColumn,
            this.cikisTarihiDataGridViewTextBoxColumn,
            this.kisiSayisiDataGridViewTextBoxColumn,
            this.odaSayisiDataGridViewTextBoxColumn,
            this.yatakSayisiDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.odaIDDataGridViewTextBoxColumn});
            this.dgvMusteriRez.DataSource = this.rezervasyonTabloBindingSource;
            this.dgvMusteriRez.Location = new System.Drawing.Point(131, 13);
            this.dgvMusteriRez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMusteriRez.Name = "dgvMusteriRez";
            this.dgvMusteriRez.Size = new System.Drawing.Size(1042, 503);
            this.dgvMusteriRez.TabIndex = 0;
            // 
            // rezervasyonIDDataGridViewTextBoxColumn
            // 
            this.rezervasyonIDDataGridViewTextBoxColumn.DataPropertyName = "RezervasyonID";
            this.rezervasyonIDDataGridViewTextBoxColumn.HeaderText = "RezervasyonID";
            this.rezervasyonIDDataGridViewTextBoxColumn.Name = "rezervasyonIDDataGridViewTextBoxColumn";
            this.rezervasyonIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kayitliUyeIDDataGridViewTextBoxColumn
            // 
            this.kayitliUyeIDDataGridViewTextBoxColumn.DataPropertyName = "KayitliUyeID";
            this.kayitliUyeIDDataGridViewTextBoxColumn.HeaderText = "KayitliUyeID";
            this.kayitliUyeIDDataGridViewTextBoxColumn.Name = "kayitliUyeIDDataGridViewTextBoxColumn";
            // 
            // rezervasyonTipiIDDataGridViewTextBoxColumn
            // 
            this.rezervasyonTipiIDDataGridViewTextBoxColumn.DataPropertyName = "RezervasyonTipiID";
            this.rezervasyonTipiIDDataGridViewTextBoxColumn.HeaderText = "RezervasyonTipiID";
            this.rezervasyonTipiIDDataGridViewTextBoxColumn.Name = "rezervasyonTipiIDDataGridViewTextBoxColumn";
            // 
            // girisTarihiDataGridViewTextBoxColumn
            // 
            this.girisTarihiDataGridViewTextBoxColumn.DataPropertyName = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn.HeaderText = "GirisTarihi";
            this.girisTarihiDataGridViewTextBoxColumn.Name = "girisTarihiDataGridViewTextBoxColumn";
            // 
            // cikisTarihiDataGridViewTextBoxColumn
            // 
            this.cikisTarihiDataGridViewTextBoxColumn.DataPropertyName = "CikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.HeaderText = "CikisTarihi";
            this.cikisTarihiDataGridViewTextBoxColumn.Name = "cikisTarihiDataGridViewTextBoxColumn";
            // 
            // kisiSayisiDataGridViewTextBoxColumn
            // 
            this.kisiSayisiDataGridViewTextBoxColumn.DataPropertyName = "KisiSayisi";
            this.kisiSayisiDataGridViewTextBoxColumn.HeaderText = "KisiSayisi";
            this.kisiSayisiDataGridViewTextBoxColumn.Name = "kisiSayisiDataGridViewTextBoxColumn";
            // 
            // odaSayisiDataGridViewTextBoxColumn
            // 
            this.odaSayisiDataGridViewTextBoxColumn.DataPropertyName = "OdaSayisi";
            this.odaSayisiDataGridViewTextBoxColumn.HeaderText = "OdaSayisi";
            this.odaSayisiDataGridViewTextBoxColumn.Name = "odaSayisiDataGridViewTextBoxColumn";
            // 
            // yatakSayisiDataGridViewTextBoxColumn
            // 
            this.yatakSayisiDataGridViewTextBoxColumn.DataPropertyName = "YatakSayisi";
            this.yatakSayisiDataGridViewTextBoxColumn.HeaderText = "YatakSayisi";
            this.yatakSayisiDataGridViewTextBoxColumn.Name = "yatakSayisiDataGridViewTextBoxColumn";
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            // 
            // odaIDDataGridViewTextBoxColumn
            // 
            this.odaIDDataGridViewTextBoxColumn.DataPropertyName = "OdaID";
            this.odaIDDataGridViewTextBoxColumn.HeaderText = "OdaID";
            this.odaIDDataGridViewTextBoxColumn.Name = "odaIDDataGridViewTextBoxColumn";
            // 
            // rezervasyonTabloBindingSource
            // 
            this.rezervasyonTabloBindingSource.DataMember = "Rezervasyon_Tablo";
            this.rezervasyonTabloBindingSource.DataSource = this.otelRezervasyonDataSet;
            // 
            // otelRezervasyonDataSet
            // 
            this.otelRezervasyonDataSet.DataSetName = "OtelRezervasyonDataSet";
            this.otelRezervasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervasyon_TabloTableAdapter
            // 
            this.rezervasyon_TabloTableAdapter.ClearBeforeFill = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIptal.BackColor = System.Drawing.Color.Silver;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.Black;
            this.btnIptal.Location = new System.Drawing.Point(324, 557);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(187, 52);
            this.btnIptal.TabIndex = 1;
            this.btnIptal.Text = "REZERVASYON İPTAL ET";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGeriDon.BackColor = System.Drawing.Color.Silver;
            this.btnGeriDon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnGeriDon.Location = new System.Drawing.Point(813, 557);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(187, 52);
            this.btnGeriDon.TabIndex = 2;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // MusteriRezervasyonlar
            // 
            this.AcceptButton = this.btnIptal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Otel_Rezervasyon_Sistemi.Properties.Resources.aa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnGeriDon;
            this.ClientSize = new System.Drawing.Size(1339, 643);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.dgvMusteriRez);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MusteriRezervasyonlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriRezervasyonlar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MusteriRezervasyonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriRez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonTabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelRezervasyonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriRez;
        private OtelRezervasyonDataSet otelRezervasyonDataSet;
        private System.Windows.Forms.BindingSource rezervasyonTabloBindingSource;
        private OtelRezervasyonDataSetTableAdapters.Rezervasyon_TabloTableAdapter rezervasyon_TabloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitliUyeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyonTipiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yatakSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnGeriDon;
    }
}
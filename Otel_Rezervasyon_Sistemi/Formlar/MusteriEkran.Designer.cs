namespace Otel_Rezervasyon_Sistemi.Formlar
{
    partial class MusteriEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriEkran));
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnGecmisRez = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.Silver;
            this.btnRezervasyonYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.Black;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(296, 316);
            this.btnRezervasyonYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(220, 54);
            this.btnRezervasyonYap.TabIndex = 0;
            this.btnRezervasyonYap.Text = "REZERVASYON YAP";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // btnGecmisRez
            // 
            this.btnGecmisRez.BackColor = System.Drawing.Color.Silver;
            this.btnGecmisRez.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGecmisRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGecmisRez.ForeColor = System.Drawing.Color.Black;
            this.btnGecmisRez.Location = new System.Drawing.Point(15, 316);
            this.btnGecmisRez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGecmisRez.Name = "btnGecmisRez";
            this.btnGecmisRez.Size = new System.Drawing.Size(220, 54);
            this.btnGecmisRez.TabIndex = 1;
            this.btnGecmisRez.Text = "TÜM REZERVASYONLARIM";
            this.btnGecmisRez.UseVisualStyleBackColor = false;
            this.btnGecmisRez.Click += new System.EventHandler(this.btnGecmisRez_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Silver;
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(573, 316);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(220, 54);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "ÇIKIŞ YAP";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // MusteriEkran
            // 
            this.AcceptButton = this.btnRezervasyonYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Otel_Rezervasyon_Sistemi.Properties.Resources.WhatsApp_Image_2019_10_31_at_16_38_43;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(811, 436);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGecmisRez);
            this.Controls.Add(this.btnRezervasyonYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MusteriEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriEkran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Button btnGecmisRez;
        private System.Windows.Forms.Button btnCikis;
    }
}
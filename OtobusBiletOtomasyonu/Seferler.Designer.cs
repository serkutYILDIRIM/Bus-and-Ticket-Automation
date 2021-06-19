namespace Otobus
{
    partial class Seferler
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
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Plakası = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tcno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullanıcıAdı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonXMLAl = new System.Windows.Forms.Button();
            this.buttonXMLKaydet = new System.Windows.Forms.Button();
            this.gridSefer = new System.Windows.Forms.DataGridView();
            this.groupBoxIsDetayEkleDuzenle = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textSaat = new System.Windows.Forms.TextBox();
            this.textNereye = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNereden = new System.Windows.Forms.TextBox();
            this.nereden = new System.Windows.Forms.Label();
            this.textSeferNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.labelDetay2 = new System.Windows.Forms.Label();
            this.labelDetay1 = new System.Windows.Forms.Label();
            this.groupBoxIsDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSefer)).BeginInit();
            this.groupBoxIsDetayEkleDuzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.dataGridView2);
            this.groupBoxIsDetay.Controls.Add(this.dataGridView1);
            this.groupBoxIsDetay.Controls.Add(this.buttonXMLAl);
            this.groupBoxIsDetay.Controls.Add(this.buttonXMLKaydet);
            this.groupBoxIsDetay.Controls.Add(this.gridSefer);
            this.groupBoxIsDetay.Controls.Add(this.groupBoxIsDetayEkleDuzenle);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(31, 7);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Size = new System.Drawing.Size(683, 496);
            this.groupBoxIsDetay.TabIndex = 13;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "Sefer Ekle/Düzenle";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Plakası,
            this.Plaka});
            this.dataGridView2.Location = new System.Drawing.Point(276, 406);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(450, 150);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.Visible = false;
            // 
            // Plakası
            // 
            this.Plakası.HeaderText = "Plakası";
            this.Plakası.Name = "Plakası";
            // 
            // Plaka
            // 
            this.Plaka.HeaderText = "Kapasite";
            this.Plaka.Name = "Plaka";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tcno,
            this.KullanıcıAdı,
            this.Ad,
            this.Sifre,
            this.Adres});
            this.dataGridView1.Location = new System.Drawing.Point(16, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Visible = false;
            // 
            // Tcno
            // 
            this.Tcno.HeaderText = "Ad";
            this.Tcno.Name = "Tcno";
            // 
            // KullanıcıAdı
            // 
            this.KullanıcıAdı.HeaderText = "Soyad";
            this.KullanıcıAdı.Name = "KullanıcıAdı";
            // 
            // Ad
            // 
            this.Ad.HeaderText = "TcNo";
            this.Ad.Name = "Ad";
            // 
            // Sifre
            // 
            this.Sifre.HeaderText = "Telefon";
            this.Sifre.Name = "Sifre";
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonXMLAl.Location = new System.Drawing.Point(445, 355);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(216, 45);
            this.buttonXMLAl.TabIndex = 15;
            this.buttonXMLAl.Text = "Bilgileri XML Dosyasından Al";
            this.buttonXMLAl.UseVisualStyleBackColor = false;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click_1);
            // 
            // buttonXMLKaydet
            // 
            this.buttonXMLKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonXMLKaydet.Location = new System.Drawing.Point(53, 355);
            this.buttonXMLKaydet.Name = "buttonXMLKaydet";
            this.buttonXMLKaydet.Size = new System.Drawing.Size(231, 45);
            this.buttonXMLKaydet.TabIndex = 14;
            this.buttonXMLKaydet.Text = "Dosyayı XML Olarak Kaydet";
            this.buttonXMLKaydet.UseVisualStyleBackColor = false;
            this.buttonXMLKaydet.Click += new System.EventHandler(this.buttonXMLKaydet_Click_1);
            // 
            // gridSefer
            // 
            this.gridSefer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSefer.Location = new System.Drawing.Point(6, 168);
            this.gridSefer.Name = "gridSefer";
            this.gridSefer.Size = new System.Drawing.Size(665, 181);
            this.gridSefer.TabIndex = 8;
            // 
            // groupBoxIsDetayEkleDuzenle
            // 
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label3);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label5);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.comboBox2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.dataGridView3);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.comboBox1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textSaat);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textNereye);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label4);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textNereden);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.nereden);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textSeferNo);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonSil);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonEkle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay1);
            this.groupBoxIsDetayEkleDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetayEkleDuzenle.Location = new System.Drawing.Point(18, 25);
            this.groupBoxIsDetayEkleDuzenle.Name = "groupBoxIsDetayEkleDuzenle";
            this.groupBoxIsDetayEkleDuzenle.Size = new System.Drawing.Size(643, 137);
            this.groupBoxIsDetayEkleDuzenle.TabIndex = 0;
            this.groupBoxIsDetayEkleDuzenle.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Şoför Ad Soyad";
            this.label5.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(75, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(176, 330);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(450, 150);
            this.dataGridView3.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textSaat
            // 
            this.textSaat.Location = new System.Drawing.Point(268, 96);
            this.textSaat.Name = "textSaat";
            this.textSaat.Size = new System.Drawing.Size(110, 20);
            this.textSaat.TabIndex = 6;
            // 
            // textNereye
            // 
            this.textNereye.Location = new System.Drawing.Point(268, 51);
            this.textNereye.Name = "textNereye";
            this.textNereye.Size = new System.Drawing.Size(110, 20);
            this.textNereye.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Saat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nereye";
            // 
            // textNereden
            // 
            this.textNereden.Location = new System.Drawing.Point(268, 7);
            this.textNereden.Name = "textNereden";
            this.textNereden.Size = new System.Drawing.Size(110, 20);
            this.textNereden.TabIndex = 4;
            // 
            // nereden
            // 
            this.nereden.AutoSize = true;
            this.nereden.Location = new System.Drawing.Point(202, 12);
            this.nereden.Name = "nereden";
            this.nereden.Size = new System.Drawing.Size(48, 13);
            this.nereden.TabIndex = 11;
            this.nereden.Text = "Nereden";
            // 
            // textSeferNo
            // 
            this.textSeferNo.Location = new System.Drawing.Point(78, 93);
            this.textSeferNo.Name = "textSeferNo";
            this.textSeferNo.Size = new System.Drawing.Size(110, 20);
            this.textSeferNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sefer No";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSil.Location = new System.Drawing.Point(492, 75);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(134, 53);
            this.buttonSil.TabIndex = 9;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click_1);
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEkle.Location = new System.Drawing.Point(492, 0);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(134, 53);
            this.buttonEkle.TabIndex = 7;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click_1);
            // 
            // labelDetay2
            // 
            this.labelDetay2.AutoSize = true;
            this.labelDetay2.Location = new System.Drawing.Point(19, 59);
            this.labelDetay2.Name = "labelDetay2";
            this.labelDetay2.Size = new System.Drawing.Size(32, 13);
            this.labelDetay2.TabIndex = 2;
            this.labelDetay2.Text = "Şoför";
            // 
            // labelDetay1
            // 
            this.labelDetay1.AutoSize = true;
            this.labelDetay1.Location = new System.Drawing.Point(19, 14);
            this.labelDetay1.Name = "labelDetay1";
            this.labelDetay1.Size = new System.Drawing.Size(41, 13);
            this.labelDetay1.TabIndex = 1;
            this.labelDetay1.Text = "Otobüs";
            // 
            // Seferler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(740, 472);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Name = "Seferler";
            this.Text = "Seferler";
            this.Load += new System.EventHandler(this.Seferler_Load);
            this.groupBoxIsDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSefer)).EndInit();
            this.groupBoxIsDetayEkleDuzenle.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIsDetay;
        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.Button buttonXMLKaydet;
        private System.Windows.Forms.DataGridView gridSefer;
        private System.Windows.Forms.GroupBox groupBoxIsDetayEkleDuzenle;
        private System.Windows.Forms.TextBox textSeferNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label labelDetay2;
        private System.Windows.Forms.Label labelDetay1;
        private System.Windows.Forms.TextBox textNereye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNereden;
        private System.Windows.Forms.Label nereden;
        private System.Windows.Forms.TextBox textSaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullanıcıAdı;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tcno;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plakası;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}
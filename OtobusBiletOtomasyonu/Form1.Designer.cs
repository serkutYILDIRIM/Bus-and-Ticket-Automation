namespace FormXmlKullanimi
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SiraNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxIsDetayEkleDuzenle = new System.Windows.Forms.GroupBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonDuzenle = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSiraNo = new System.Windows.Forms.TextBox();
            this.labelDetay2 = new System.Windows.Forms.Label();
            this.labelDetay1 = new System.Windows.Forms.Label();
            this.labelIsSiraNo = new System.Windows.Forms.Label();
            this.buttonXMLKaydet = new System.Windows.Forms.Button();
            this.buttonXMLAl = new System.Windows.Forms.Button();
            this.groupBoxIsDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxIsDetayEkleDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.dataGridView1);
            this.groupBoxIsDetay.Controls.Add(this.groupBoxIsDetayEkleDuzenle);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(12, 14);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Size = new System.Drawing.Size(542, 324);
            this.groupBoxIsDetay.TabIndex = 9;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "Kullanıcılar";
            this.groupBoxIsDetay.Enter += new System.EventHandler(this.groupBoxIsDetay_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiraNo,
            this.KullaniciAdi,
            this.Sifre});
            this.dataGridView1.Location = new System.Drawing.Point(18, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(503, 126);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // SiraNo
            // 
            this.SiraNo.HeaderText = "Sıra No";
            this.SiraNo.Name = "SiraNo";
            this.SiraNo.ReadOnly = true;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.ReadOnly = true;
            this.KullaniciAdi.Width = 180;
            // 
            // Sifre
            // 
            this.Sifre.HeaderText = "Sifre";
            this.Sifre.Name = "Sifre";
            this.Sifre.ReadOnly = true;
            this.Sifre.Width = 180;
            // 
            // groupBoxIsDetayEkleDuzenle
            // 
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonSil);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonDuzenle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonEkle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxSifre);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxKullaniciAdi);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textBoxSiraNo);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelIsSiraNo);
            this.groupBoxIsDetayEkleDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetayEkleDuzenle.Location = new System.Drawing.Point(18, 25);
            this.groupBoxIsDetayEkleDuzenle.Name = "groupBoxIsDetayEkleDuzenle";
            this.groupBoxIsDetayEkleDuzenle.Size = new System.Drawing.Size(503, 137);
            this.groupBoxIsDetayEkleDuzenle.TabIndex = 0;
            this.groupBoxIsDetayEkleDuzenle.TabStop = false;
            this.groupBoxIsDetayEkleDuzenle.Text = "Kullanıcıları Ekle ve Düzenle";
            this.groupBoxIsDetayEkleDuzenle.Enter += new System.EventHandler(this.groupBoxIsDetayEkleDuzenle_Enter);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(328, 88);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(130, 36);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonDuzenle
            // 
            this.buttonDuzenle.Location = new System.Drawing.Point(176, 88);
            this.buttonDuzenle.Name = "buttonDuzenle";
            this.buttonDuzenle.Size = new System.Drawing.Size(130, 36);
            this.buttonDuzenle.TabIndex = 7;
            this.buttonDuzenle.Text = "Düzenle";
            this.buttonDuzenle.UseVisualStyleBackColor = true;
            this.buttonDuzenle.Click += new System.EventHandler(this.buttonDuzenle_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(21, 88);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(130, 36);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(250, 52);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifre.TabIndex = 5;
            this.textBoxSifre.TextChanged += new System.EventHandler(this.textBoxSifre_TextChanged);
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(78, 52);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxKullaniciAdi.TabIndex = 4;
            this.textBoxKullaniciAdi.TextChanged += new System.EventHandler(this.textBoxKullaniciAdi_TextChanged);
            // 
            // textBoxSiraNo
            // 
            this.textBoxSiraNo.Location = new System.Drawing.Point(77, 29);
            this.textBoxSiraNo.Name = "textBoxSiraNo";
            this.textBoxSiraNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxSiraNo.TabIndex = 3;
            this.textBoxSiraNo.TextChanged += new System.EventHandler(this.textBoxSiraNo_TextChanged);
            // 
            // labelDetay2
            // 
            this.labelDetay2.AutoSize = true;
            this.labelDetay2.Location = new System.Drawing.Point(200, 52);
            this.labelDetay2.Name = "labelDetay2";
            this.labelDetay2.Size = new System.Drawing.Size(28, 13);
            this.labelDetay2.TabIndex = 2;
            this.labelDetay2.Text = "Sifre";
            this.labelDetay2.Click += new System.EventHandler(this.labelDetay2_Click);
            // 
            // labelDetay1
            // 
            this.labelDetay1.AutoSize = true;
            this.labelDetay1.Location = new System.Drawing.Point(15, 52);
            this.labelDetay1.Name = "labelDetay1";
            this.labelDetay1.Size = new System.Drawing.Size(64, 13);
            this.labelDetay1.TabIndex = 1;
            this.labelDetay1.Text = "Kullanıcı Adı";
            this.labelDetay1.Click += new System.EventHandler(this.labelDetay1_Click);
            // 
            // labelIsSiraNo
            // 
            this.labelIsSiraNo.AutoSize = true;
            this.labelIsSiraNo.Location = new System.Drawing.Point(15, 29);
            this.labelIsSiraNo.Name = "labelIsSiraNo";
            this.labelIsSiraNo.Size = new System.Drawing.Size(42, 13);
            this.labelIsSiraNo.TabIndex = 0;
            this.labelIsSiraNo.Text = "Sıra No";
            this.labelIsSiraNo.Click += new System.EventHandler(this.labelIsSiraNo_Click);
            // 
            // buttonXMLKaydet
            // 
            this.buttonXMLKaydet.Location = new System.Drawing.Point(45, 347);
            this.buttonXMLKaydet.Name = "buttonXMLKaydet";
            this.buttonXMLKaydet.Size = new System.Drawing.Size(170, 23);
            this.buttonXMLKaydet.TabIndex = 10;
            this.buttonXMLKaydet.Text = "Dosyayı XML Olarak Kaydet";
            this.buttonXMLKaydet.UseVisualStyleBackColor = true;
            this.buttonXMLKaydet.Click += new System.EventHandler(this.buttonXMLKaydet_Click);
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.Location = new System.Drawing.Point(353, 344);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(170, 23);
            this.buttonXMLAl.TabIndex = 11;
            this.buttonXMLAl.Text = "Bilgileri XML Dosyasından Al";
            this.buttonXMLAl.UseVisualStyleBackColor = true;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 394);
            this.Controls.Add(this.buttonXMLAl);
            this.Controls.Add(this.buttonXMLKaydet);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Name = "Form1";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxIsDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxIsDetayEkleDuzenle.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIsDetay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxIsDetayEkleDuzenle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonDuzenle;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSiraNo;
        private System.Windows.Forms.Label labelDetay2;
        private System.Windows.Forms.Label labelDetay1;
        private System.Windows.Forms.Label labelIsSiraNo;
        private System.Windows.Forms.Button buttonXMLKaydet;
        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiraNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifre;
    }
}


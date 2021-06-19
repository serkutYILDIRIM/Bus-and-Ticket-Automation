namespace Otobus
{
    partial class otobusler
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
            this.groupBoxIsDetayEkleDuzenle = new System.Windows.Forms.GroupBox();
            this.textSeferNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textKapasite = new System.Windows.Forms.TextBox();
            this.textPlaka = new System.Windows.Forms.TextBox();
            this.labelDetay2 = new System.Windows.Forms.Label();
            this.labelDetay1 = new System.Windows.Forms.Label();
            this.groupBoxIsDetay = new System.Windows.Forms.GroupBox();
            this.buttonXMLAl = new System.Windows.Forms.Button();
            this.buttonXMLKaydet = new System.Windows.Forms.Button();
            this.gridOtobus = new System.Windows.Forms.DataGridView();
            this.groupBoxIsDetayEkleDuzenle.SuspendLayout();
            this.groupBoxIsDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOtobus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIsDetayEkleDuzenle
            // 
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textSeferNo);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.label1);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonSil);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.buttonEkle);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textKapasite);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.textPlaka);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay2);
            this.groupBoxIsDetayEkleDuzenle.Controls.Add(this.labelDetay1);
            this.groupBoxIsDetayEkleDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetayEkleDuzenle.Location = new System.Drawing.Point(18, 25);
            this.groupBoxIsDetayEkleDuzenle.Name = "groupBoxIsDetayEkleDuzenle";
            this.groupBoxIsDetayEkleDuzenle.Size = new System.Drawing.Size(539, 137);
            this.groupBoxIsDetayEkleDuzenle.TabIndex = 0;
            this.groupBoxIsDetayEkleDuzenle.TabStop = false;
            this.groupBoxIsDetayEkleDuzenle.Enter += new System.EventHandler(this.groupBoxIsDetayEkleDuzenle_Enter);
            // 
            // textSeferNo
            // 
            this.textSeferNo.Location = new System.Drawing.Point(110, 90);
            this.textSeferNo.Name = "textSeferNo";
            this.textSeferNo.Size = new System.Drawing.Size(110, 20);
            this.textSeferNo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sefer No";
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(323, 80);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(134, 51);
            this.buttonSil.TabIndex = 9;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(323, 19);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(134, 53);
            this.buttonEkle.TabIndex = 7;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textKapasite
            // 
            this.textKapasite.Location = new System.Drawing.Point(110, 54);
            this.textKapasite.Name = "textKapasite";
            this.textKapasite.Size = new System.Drawing.Size(110, 20);
            this.textKapasite.TabIndex = 5;
            // 
            // textPlaka
            // 
            this.textPlaka.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPlaka.Location = new System.Drawing.Point(110, 11);
            this.textPlaka.Name = "textPlaka";
            this.textPlaka.Size = new System.Drawing.Size(110, 20);
            this.textPlaka.TabIndex = 4;
            // 
            // labelDetay2
            // 
            this.labelDetay2.AutoSize = true;
            this.labelDetay2.Location = new System.Drawing.Point(44, 59);
            this.labelDetay2.Name = "labelDetay2";
            this.labelDetay2.Size = new System.Drawing.Size(48, 13);
            this.labelDetay2.TabIndex = 2;
            this.labelDetay2.Text = "Kapasite";
            // 
            // labelDetay1
            // 
            this.labelDetay1.AutoSize = true;
            this.labelDetay1.Location = new System.Drawing.Point(44, 14);
            this.labelDetay1.Name = "labelDetay1";
            this.labelDetay1.Size = new System.Drawing.Size(34, 13);
            this.labelDetay1.TabIndex = 1;
            this.labelDetay1.Text = "Plaka";
            // 
            // groupBoxIsDetay
            // 
            this.groupBoxIsDetay.Controls.Add(this.buttonXMLAl);
            this.groupBoxIsDetay.Controls.Add(this.buttonXMLKaydet);
            this.groupBoxIsDetay.Controls.Add(this.gridOtobus);
            this.groupBoxIsDetay.Controls.Add(this.groupBoxIsDetayEkleDuzenle);
            this.groupBoxIsDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxIsDetay.Location = new System.Drawing.Point(32, 8);
            this.groupBoxIsDetay.Name = "groupBoxIsDetay";
            this.groupBoxIsDetay.Size = new System.Drawing.Size(603, 324);
            this.groupBoxIsDetay.TabIndex = 12;
            this.groupBoxIsDetay.TabStop = false;
            this.groupBoxIsDetay.Text = "Otobüs Ekle/Düzenle";
            this.groupBoxIsDetay.Enter += new System.EventHandler(this.groupBoxIsDetay_Enter);
            // 
            // buttonXMLAl
            // 
            this.buttonXMLAl.Location = new System.Drawing.Point(341, 295);
            this.buttonXMLAl.Name = "buttonXMLAl";
            this.buttonXMLAl.Size = new System.Drawing.Size(216, 23);
            this.buttonXMLAl.TabIndex = 15;
            this.buttonXMLAl.Text = "Bilgileri XML Dosyasından Al";
            this.buttonXMLAl.UseVisualStyleBackColor = true;
            this.buttonXMLAl.Click += new System.EventHandler(this.buttonXMLAl_Click);
            // 
            // buttonXMLKaydet
            // 
            this.buttonXMLKaydet.Location = new System.Drawing.Point(16, 295);
            this.buttonXMLKaydet.Name = "buttonXMLKaydet";
            this.buttonXMLKaydet.Size = new System.Drawing.Size(231, 23);
            this.buttonXMLKaydet.TabIndex = 14;
            this.buttonXMLKaydet.Text = "Dosyayı XML Olarak Kaydet";
            this.buttonXMLKaydet.UseVisualStyleBackColor = true;
            this.buttonXMLKaydet.Click += new System.EventHandler(this.buttonXMLKaydet_Click);
            // 
            // gridOtobus
            // 
            this.gridOtobus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOtobus.Location = new System.Drawing.Point(18, 169);
            this.gridOtobus.Name = "gridOtobus";
            this.gridOtobus.Size = new System.Drawing.Size(539, 112);
            this.gridOtobus.TabIndex = 8;
            // 
            // otobusler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(664, 373);
            this.Controls.Add(this.groupBoxIsDetay);
            this.Name = "otobusler";
            this.Text = "otobuskaydet";
            this.Load += new System.EventHandler(this.otobusler_Load);
            this.groupBoxIsDetayEkleDuzenle.ResumeLayout(false);
            this.groupBoxIsDetayEkleDuzenle.PerformLayout();
            this.groupBoxIsDetay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOtobus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxIsDetayEkleDuzenle;
        private System.Windows.Forms.TextBox textKapasite;
        private System.Windows.Forms.TextBox textPlaka;
        private System.Windows.Forms.Label labelDetay2;
        private System.Windows.Forms.Label labelDetay1;
        private System.Windows.Forms.GroupBox groupBoxIsDetay;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.DataGridView gridOtobus;
        private System.Windows.Forms.Button buttonXMLKaydet;
        private System.Windows.Forms.Button buttonXMLAl;
        private System.Windows.Forms.TextBox textSeferNo;
        private System.Windows.Forms.Label label1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otobus
{
    public partial class BiletSatis : Form
    {
        public static string cinsiyet1;//koltuklara "bay/bayan" olarak cinsiyet atamamızı sağlıyor
        public  string seferNo1;//sefer seçmemizi sağlıyor
       public string  tarih2, m1, secilentarih, secilenkoltuk,nereden,nereye;
        int s1; 
        string[,] Dizi = new string[100, 2];
        KayıtFormu kayit = new KayıtFormu();
        public BiletSatis()
        {
            InitializeComponent();
        }

        private void BiletSatis_Load(object sender, EventArgs e)
        {
            tarih2 = dateTimePicker1.Text;//tarih atanan yer
            label1.Visible = false;
            label2.Visible = false;

            string DosyaYolu2 = "Seferler" + ".xml";
            //XML dosyamızın var olup olmadığını kontrol için ilk önce bir değişkene dosya yolunu atıyoruz.
            if (System.IO.File.Exists(DosyaYolu2))
            {//Eğer Dosyo yolunda belirtilen değer var ise aşağıdaki işlemler yapılıyor.
                DataSet ds = new DataSet();
                //Az önce oluşturduğumuz dataset private olduğundan burada yeniden oluşturuyoruz.
                ds.ReadXml("Seferler.xml");

                foreach (DataRow item in ds.Tables["Seferler"].Rows)
                {
                    //tablosundaki satırlar kadar foreach döngüsüne sokuyoruz.
                    int n = dataGridView2.Rows.Add();
                    //Satır sayısını n değişkenine aktarıyoruz.
                    dataGridView2.Rows[n].Cells[0].Value = item[2].ToString();
                    //DataGridView'in n satırının 0. sütununu datasetten gelen 0.sütun ile eşitliyoruz.
                    dataGridView2.Rows[n].Cells[1].Value = item[4].ToString();
                    //DataGridView'in n satırının 1. sütununu datasetten gelen 1.sütun ile eşitliyoruz.
                  dataGridView2.Rows[n].Cells[2].Value = item[5].ToString();
                    dataGridView2.Rows[n].Cells[3].Value = item[1].ToString();
                }
            }//if bitisi
            else {//Eğer XML dosyası yok ise 
                MessageBox.Show("Kullanıcı.XML Bulunamadı.XML Dosyasını Oluşturun.");
                //MessageBox ile uyarı veriliyor.
            }
            Listele();//listeleme yapılıyor

            Listele();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
                comboBox1.Items.Add(Convert.ToString(dataGridView2.Rows[i].Cells[0].Value));
         
        }

        void koltukDoldur(int koltuksayisi, int sira)//koltukların oluşturulduğu yer
        {
            int j;
            //koltuk listesinin temizlenmesini sağlar
            flowLayoutPanel1.Controls.Clear();
            for (int i = 1; i <= koltuksayisi; i++)//koltuklara özelliklerin atandığı yer
            {
                Button koltuk = new Button();
                koltuk.ContextMenuStrip = contextMenuStrip1;
                koltuk.MouseDown += Koltuk_MouseDown;//mouse tıklandığında
                koltuk.Width = 40;//eni boyu 40-40 olan koltuklar
                koltuk.Height = 40;
                koltuk.Text = i.ToString();//koltuk numaraları veriliyor
                j = i - 1;
                //       MessageBox.Show(Convert.ToString(dataGridView1.Rows[j].Cells[4].Value));


               
                    if (Dizi[i, 0] == "bay")//bay seçilirse renk "blue" oluyor koltuk mavi rengini alıyor
                        koltuk.BackColor = Color.Blue;
                    if (Dizi[i, 0] == "bayan")//bayan seçilitse renk "pink" oluyor koltuk pembe rengini alıyor
                           koltuk.BackColor = Color.Pink;
               
                if (koltuksayisi - 3 == i)//koltukların oluşturulduğu yer
                    koltuk.Margin = new Padding(20, 0, 0, 0);
                else if (koltuksayisi - 1 == i)
                    koltuk.Margin = new Padding(0);
                else if (sira * 4 - 2 == i)
                    koltuk.Margin = new Padding(0, 0, 120, 0);
                else if (i % 4 == 3 && i < (sira-1) * 4)
                    koltuk.Margin = new Padding(40, 0, 0, 0);
                else if (i % 4 == 1 && i > sira * 4)
                    koltuk.Margin = new Padding(40, 0, 0, 0);
                else
                    koltuk.Margin = new Padding(0);

                flowLayoutPanel1.Controls.Add(koltuk);//koltuklarımız ekleniyor
                Listele();//Koltuklar yenileniyor
            }

        

        }
        Button tiklanan;//Hangi butona tıklandığını tutan değişken
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = (Button)sender;//hangi koltuğa tıklandıysa o koltuk tıklanan değişkenine atanıyor
          
        }
     
        private void bayToolStripMenuItem_Click(object sender, EventArgs e)//bay seçilirse cinsiyet bayan oluyor kiralaya "blue" gönderilerek koltuk rengi
        {                                                                  //mavi oluyor
        cinsiyet1 = "bay";
            kirala(Color.Blue);
        }

        private void kirala(Color renk)//kirala metoduyla koltuklara rezervasyon yapıyoruz
        {
            string Nereden1 = textBox1.Text;//nereden nereye  olduğunu belirliyoruz
          string  Nereye1 = textBox2.Text;
            KayıtFormu kayit = new KayıtFormu();
            BiletSatisController bilet = new BiletSatisController();
            kayit.txtSeferNo.Text = seferNo1;
            kayit.txtCinsiyet.Text =cinsiyet1;//gelen bilgileri "kayıt formundaki" "text'lere" atıyoruz
            kayit.txtdate.Text= tarih2;
            kayit.txtNereden.Text = Nereden1;
            kayit.txtNereye.Text = Nereye1;
            kayit.txtKoltuk.Text = tiklanan.Text;
            DialogResult sonuc = kayit.ShowDialog();
            if (sonuc == DialogResult.OK)//"sonuc" değişkeni kayıtın yapılıp yapılmadığını tutuyor.Kayıt yapılmışsa (Yani sonuc==OK) koltuğun rengi "renk" değişkeninde
            {                            //tutulan renk oluyor
                tiklanan.BackColor = renk;

            }
            yenile();//kayıt yapıldığında ekranın yenilenmesi için "yenile" metodu çağırılıyor
                
            
        }
        private void bayanToolStripMenuItem_Click(object sender, EventArgs e)
       { 
            cinsiyet1 = "bayan";
            kirala(Color.Pink);//menu stripte "bayan" seçilmişse "kirala" metoduna "pink" rengi gönderiliyor ve koltuğun rengi "pembe" oluyor
        }
        
        private void btn_Kaydet_Click_1(object sender, EventArgs e)
        {
            BiletSatisController bilet = new BiletSatisController();//bilgileri düzenledikten sonra kayıt etmek için gerekli olan kayıt butonu.

            DataTable dt = (DataTable)gridBilet.DataSource;
            bilet.YolcuKaydet(dt);
            MessageBox.Show("Bilgiler kaydedildi");
        }

        private void btn_Listele_Click(object sender, EventArgs e)//kayıtlatı listeleme butonumuz
        {
            flowLayoutPanel1.Visible = true;
            if (seferNo1 == null)
                MessageBox.Show("Önce Sefer seçmelisiniz");//sefer seçilmemişse
            else {
                kayitlariListele();//sefer seçilmişse "kayıtlarıListele" metodu çağırılarak kayıtlar listeleniyor
                kayitlariListele();
            }
        }
        private void Listele()//listeleme metodumuz
        {
            BiletSatisController bilet = new BiletSatisController();//kayıt listemiz getiriliyor

            DataTable dt = bilet.KayıtListesiGetir();
            gridBilet.DataSource = dt;
           }
         private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonSil_Click_2(object sender, EventArgs e)//Bilet sildiğimiz yer
        {
            secilentarih = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            secilenkoltuk = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //  MessageBox.Show(Convert.ToString(secilentarih));
            //   MessageBox.Show(Convert.ToString(secilenkoltuk));
            for (int i = 0; i < gridBilet.Rows.Count; i++)
            {
                if ((secilentarih == Convert.ToString(gridBilet.Rows[i].Cells[6].Value)) && (secilenkoltuk == Convert.ToString(gridBilet.Rows[i].Cells[5].Value)))
                {
                    //  MessageBox.Show(Convert.ToString( i));
                    gridBilet.Rows[i].Selected = true;
                    gridBilet.Rows.RemoveAt(gridBilet.SelectedRows[0].Index);


                }

            }
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            //kaydet
            BiletSatisController bilet = new BiletSatisController();

            DataTable dt = (DataTable)gridBilet.DataSource;
            bilet.YolcuKaydet(dt);
            MessageBox.Show("Bilgiler kaydedildi");
            yenile();//bileti sildikten sonra ekranı yeniliyoruz ve butonları görünür hale getiriyoruz
            Listele();
            dataGridView1.Visible = true;
            buttonSil.Visible = true;
            btn_Kaydet.Visible = true;
            btn_Listele.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//sefer seçtiğimiz combobox
        {
            seferNo1 = comboBox1.Text;//sefer seçtiğimizde aşağıdaki öğeler görünür hale geliyor
            label3.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            dateTimePicker1.Visible = true;
            btn_Listele.Visible = true;
            
            string sefernosu = comboBox1.Text;//seferNo'muz combobox'tan alınıyor
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (sefernosu == Convert.ToString(dataGridView2.Rows[i].Cells[0].Value))
                {
                    textBox1.Text = Convert.ToString(dataGridView2.Rows[i].Cells[1].Value);

                    textBox2.Text = Convert.ToString(dataGridView2.Rows[i].Cells[2].Value);
                    textBox3.Text = Convert.ToString(dataGridView2.Rows[i].Cells[3].Value);
                }
               
            }
     
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tarih2 = dateTimePicker1.Text;//tarihi tuttuğumuz yer
        }
        public void yenile()
        {
            Dizi = new string[100, 2];
            string DosyaYolu = "BiletKayıt" + ".xml";
            //XML dosyamızın var olup olmadığını kontrol için ilk önce bir değişkene dosya yolunu atıyoruz.
            if (System.IO.File.Exists(DosyaYolu))
            {//Eğer Dosyo yolunda belirtilen değer var ise aşağıdaki işlemler yapılıyor.
                DataSet ds = new DataSet();
                //Az önce oluşturduğumuz dataset private olduğundan burada yeniden oluşturuyoruz.
                ds.ReadXml("BiletKayıt.xml");
                dataGridView1.Rows.Clear();
                foreach (DataRow item in ds.Tables["Kayıtlar"].Rows)
                {

                    if (item[6].ToString() == tarih2 && item[9].ToString() == seferNo1)
                    {
                        int n = dataGridView1.Rows.Add();
                        //tablosundaki satırlar kadar foreach döngüsüne sokuyoruz.

                        //Satır sayısını n değişkenine aktarıyoruz.
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        //DataGridView'in n satırının 0. sütununu datasetten gelen 0.sütun ile eşitliyoruz.
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        //DataGridView'in n satırının 1. sütununu datasetten gelen 1.sütun ile eşitliyoruz.
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();

                        ds.EndInit();
                    }
                }
                for (int s = 0; s < dataGridView1.RowCount; s++)
                {
                    m1 = Convert.ToString(dataGridView1.Rows[s].Cells[4].Value);
                    s1 = Convert.ToInt16(dataGridView1.Rows[s].Cells[5].Value);
                    Dizi[s1, 0] = m1;

                }
                tarih2 = dateTimePicker1.Text;

                koltukDoldur(58, 8);
                label4.Visible = true;
            }//if bitisi
            else
            {//Eğer XML dosyası yok ise 
                MessageBox.Show("biletsatis.XML Bulunamadı.XML Dosyasını Oluşturun.");
                //MessageBox ile uyarı veriliyor.
            }
        }
        public void kayitlariListele()//kayıtları listelediğimiz "metodumuz"
        {
            yenile();
            Listele();
            dataGridView1.Visible = true;
            buttonSil.Visible = true;
            btn_Kaydet.Visible = true;
            btn_Listele.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }
    }
}

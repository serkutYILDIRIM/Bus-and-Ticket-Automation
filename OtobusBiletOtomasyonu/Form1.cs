using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;              //XML işlemerini yapabilmek için System.XML'i projemize dahil ediyoruz.

 

namespace FormXmlKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {        }

        private void buttonEkle_Click(object sender, EventArgs e)
        { 
            //Ekle butonuna bastığımızda yapılacaklar.

            int n = dataGridView1.Rows.Add();
            // n adında integer bir değişken oluşturuyoruz bunu datagridview'e satır eklerken kullanıyoruz.
            dataGridView1.Rows[n].Cells[0].Value=textBoxSiraNo.Text;
            //Datagridview'in n satırı  0.sütununa textboxsiraNo'nun Text'ini ekliyoruz.
            dataGridView1.Rows[n].Cells[1].Value=textBoxKullaniciAdi.Text;
            //Datagridview'in n satırı  1.sütununa textboxKullaniciAdi'nin Text'ini ekliyoruz.
            dataGridView1.Rows[n].Cells[2].Value=textBoxSifre.Text;
            //Datagridview'in n satırı  2.sütununa textboxSifre'nin Text'ini ekliyoruz.
             
            textBoxSiraNo.Clear();
            //Verileri ekledikten sonra textbox'ı yeni veri girişi için temizliyoruz.
            textBoxKullaniciAdi.Clear();
            //Verileri ekledikten sonra textbox'ı yeni veri girişi için temizliyoruz.
            textBoxSifre.Clear();
            //Verileri ekledikten sonra textbox'ı yeni veri girişi için temizliyoruz.

        }

        private void buttonXMLKaydet_Click(object sender, EventArgs e)
        { 
            //XML Kaydet butonuna tıkladığımızda yapılacaklar.
            DataSet ds = new DataSet("Otubus");
           
     
            DataTable dt = new DataTable("Kullanicilar");
             
            dt.Columns.Add("SiraNo");//Datatable'ın Sütununa "Sıra No" ekliyoruz.
            dt.Columns.Add("KullaniciAdi");//Datatable'ın Sütununa "KullaniciAdi" ekliyoruz.
            dt.Columns.Add("Sifre");//Datatable'ın Sütununa "Sifre" ekliyoruz.
            ds.Tables.Add(dt);//Sütunları tablo içine ekliyoruz.


           foreach (DataGridViewRow r in dataGridView1.Rows)
           {//Oluşacak satır sayısıı bilmediğimizden dolayı foreach döngüsü içinde 
               //DataGridView'in satır sayısı kadar değer döndürüyoruz.
          DataRow row = ds.Tables["Kullanicilar"].NewRow();
          //Kullanicilar'da oluşturduğumuz tablo değerlerini eklemek için kullanıyoruz.
           

           row["SiraNo"] = r.Cells[0].Value.ToString();
               //Satırdaki SıraNo'nun değerini DetaGridView'den alıyoruz ve geçerli satırın 0.sütünunu alıyoruz.
           row["KullaniciAdi"] = r.Cells[1].Value.ToString();
           //Satırdaki KullaniciAdi değerini DetaGridView'den alıyoruz ve geçerli satırın 1.sütünunu alıyoruz.
           row["Sifre"] = r.Cells[2].Value.ToString();
           //Satırdaki Sifre değerini DetaGridView'den alıyoruz ve geçerli satırın 2.sütünunu alıyoruz.


           ds.Tables["Kullanicilar"].Rows.Add(row);
               //Dataset içindeki Kullanicilar tablosuna satırları ekliyoruz.
           } 
           ds.WriteXml("Veri1.xml");
            //Verileri Dataset ile XML'e yazıyoruz.

        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        { 
            string DosyaYolu = "Veri1" + ".xml";
            //XML dosyamızın var olup olmadığını kontrol için ilk önce bir değişkene dosya yolunu atıyoruz.
            if (System.IO.File.Exists(DosyaYolu))
            {//Eğer Dosyo yolunda belirtilen değer var ise aşağıdaki işlemler yapılıyor.
                DataSet ds = new DataSet();
                //Az önce oluşturduğumuz dataset private olduğundan burada yeniden oluşturuyoruz.
                ds.ReadXml("Veri1.xml");
                //Dataset'imiz ile daha önceden oluşturduğumuz "Veri.xml" dosyasını okutuyoruz.

                foreach (DataRow item in ds.Tables["Kullanicilar"].Rows)
                {//XML dosyasındaki veri sayısını bilmediğimizden "Kullanicilar" 
                    //tablosundaki satırlar kadar foreach döngüsüne sokuyoruz.
                    int n = dataGridView1.Rows.Add();
                    //Satır sayısını n değişkenine aktarıyoruz.
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    //DataGridView'in n satırının 0. sütununu datasetten gelen 0.sütun ile eşitliyoruz.
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    //DataGridView'in n satırının 1. sütununu datasetten gelen 1.sütun ile eşitliyoruz.
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    //DataGridView'in n satırının 2. sütununu datasetten gelen 1.sütun ile eşitliyoruz.

                } 
            }//if bitisi
            else {//Eğer XML dosyası yok ise 
                MessageBox.Show("Veri1.XML Bulunamadı.XML Dosyasını Oluşturun.");
                //MessageBox ile uyarı veriliyor.
            }


        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        { 
            //DatagridView'in mauseClick Event'ini kullanarak seçili satıra tıklandığından 
            //ilgili textboxların içeriğinin dolmasını sağlıyoruz.
            textBoxSiraNo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxKullaniciAdi.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBoxSifre.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {//Düzenle butonuna bastığımızda datagridview'den değeri textboxlara çekiyoruz.
        
            dataGridView1.SelectedRows[0].Cells[0].Value = textBoxSiraNo.Text;
            dataGridView1.SelectedRows[0].Cells[1].Value = textBoxKullaniciAdi.Text;
            dataGridView1.SelectedRows[0].Cells[2].Value = textBoxSifre.Text;
        } 

        private void buttonSil_Click(object sender, EventArgs e)
        {//Sil butonuna tıklandığından DataGridView'de tıklamış olduğumuz satırı siliyoruz.
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBoxIsDetay_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxIsDetayEkleDuzenle_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSiraNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDetay2_Click(object sender, EventArgs e)
        {

        }

        private void labelDetay1_Click(object sender, EventArgs e)
        {

        }

        private void labelIsSiraNo_Click(object sender, EventArgs e)
        {

        }
    }
}

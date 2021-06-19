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
    public partial class Seferler : Form//Seferlerin eklendiği form
    {
        public Seferler()
        {
            InitializeComponent();
        }

     

        private void buttonSil_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonXMLKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridSefer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DatagridView'in mauseClick Event'ini kullanarak seçili satıra tıklandığından 
            //ilgili textboxların içeriğinin dolmasını sağlıyoruz.
            comboBox2.Text = gridSefer.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = gridSefer.SelectedRows[0].Cells[1].Value.ToString();
            textSeferNo.Text = gridSefer.SelectedRows[0].Cells[2].Value.ToString();
            
            textSaat.Text=gridSefer.SelectedRows[0].Cells[4].Value.ToString();
          
           textNereden.Text= gridSefer.SelectedRows[0].Cells[5].Value.ToString();
           textNereye.Text=  gridSefer.SelectedRows[0].Cells[6].Value.ToString();





        }
        private void dataGridSeferler_MouseClick(object sender, MouseEventArgs e)//datagridteki bilgiler textlere atanıyor
        {
            comboBox2.Text = gridSefer.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = gridSefer.SelectedRows[0].Cells[1].Value.ToString();
            textSeferNo.Text = gridSefer.SelectedRows[0].Cells[2].Value.ToString();

            textSaat.Text = gridSefer.SelectedRows[0].Cells[4].Value.ToString();

            textNereden.Text = gridSefer.SelectedRows[0].Cells[5].Value.ToString();
            textNereye.Text = gridSefer.SelectedRows[0].Cells[6].Value.ToString();

        }
        private void Listele()//Kayıtların listelendiği metot
        {
            SeferlerKaydet Sefer = new SeferlerKaydet();

            DataTable dt = Sefer.SeferlerListesiGetir();
            gridSefer.DataSource = dt;
        }

        private void buttonEkle_Click_1(object sender, EventArgs e)//kayıt eklenen buton
        {

            SeferlerKaydet Sefer = new SeferlerKaydet();

            Sefer.PLAKA = comboBox2.Text;//Textboxlardaki bilgiler "get-set" metotları yardımıyla değişkenlere atanıyor
           Sefer.SEFERNO =( textSeferNo.Text);
         
            Sefer.SAAT = textSaat.Text;
            Sefer.TcKİMLİK = (comboBox1.Text);
            Sefer.NEREDEN = textNereden.Text;
            Sefer.NEREYE = textNereye.Text;

            Sefer.SeferlerleriKaydet();//kayıt ediliyor


            Listele();//liste yenileniyor
            MessageBox.Show("Sefer eklendi");//mesaj veriliyor
            DataTable dt = (DataTable)gridSefer.DataSource;
            Sefer.SeferlerleriKaydet(dt);//xml'e kayıt ediliyor
            MessageBox.Show("Bilgiler kaydedildi");//mesaj veriliyor
        }

        private void buttonXMLAl_Click_1(object sender, EventArgs e)
        {
            Listele();//listeleme metodu çağırılıyor
        }

        private void Seferler_Load(object sender, EventArgs e)
        {
            string DosyaYolu = "Soforler" + ".xml";
            //XML dosyamızın var olup olmadığını kontrol için ilk önce bir değişkene dosya yolunu atıyoruz.
            if (System.IO.File.Exists(DosyaYolu))
            {//Eğer Dosyo yolunda belirtilen değer var ise aşağıdaki işlemler yapılıyor.
                DataSet ds = new DataSet();
                //Az önce oluşturduğumuz dataset private olduğundan burada yeniden oluşturuyoruz.
                ds.ReadXml("Soforler.xml");

                foreach (DataRow item in ds.Tables["Soforler"].Rows)
                {
                    //tablosundaki satırlar kadar foreach döngüsüne sokuyoruz.
                    int n = dataGridView1.Rows.Add();
                    //Satır sayısını n değişkenine aktarıyoruz.
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    //DataGridView'in n satırının 0. sütununu datasetten gelen 0.sütun ile eşitliyoruz.
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    //DataGridView'in n satırının 1. sütununu datasetten gelen 1.sütun ile eşitliyoruz.
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();

                }
            }//if bitisi
            else {//Eğer XML dosyası yok ise 
                MessageBox.Show("Kullanıcı.XML Bulunamadı.XML Dosyasını Oluşturun.");
                //MessageBox ile uyarı veriliyor.
            }


            string DosyaYolu2 = "Otobusler" + ".xml";
            //XML dosyamızın var olup olmadığını kontrol için ilk önce bir değişkene dosya yolunu atıyoruz.
            if (System.IO.File.Exists(DosyaYolu2))
            {//Eğer Dosyo yolunda belirtilen değer var ise aşağıdaki işlemler yapılıyor.
                DataSet ds = new DataSet();
                //Az önce oluşturduğumuz dataset private olduğundan burada yeniden oluşturuyoruz.
                ds.ReadXml("Otobusler.xml");

                foreach (DataRow item in ds.Tables["Otobusler"].Rows)
                {
                    //tablosundaki satırlar kadar foreach döngüsüne sokuyoruz.
                    int n = dataGridView2.Rows.Add();
                    //Satır sayısını n değişkenine aktarıyoruz.
                    dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                    //DataGridView'in n satırının 0. sütununu datasetten gelen 0.sütun ile eşitliyoruz.
                    dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();
                    //DataGridView'in n satırının 1. sütununu datasetten gelen 1.sütun ile eşitliyoruz.

                }
            }//if bitisi
            else {//Eğer XML dosyası yok ise 
                MessageBox.Show("Kullanıcı.XML Bulunamadı.XML Dosyasını Oluşturun.");
                //MessageBox ile uyarı veriliyor.
            }



            Listele();//listeleme metodu çağırılıyor
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                comboBox1.Items.Add(Convert.ToString(dataGridView1.Rows[i].Cells[2].Value));

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                comboBox2.Items.Add(Convert.ToString(dataGridView2.Rows[i].Cells[0].Value));
        }

      

        private void buttonSil_Click_1(object sender, EventArgs e)
        {
            //Sil butonuna tıklandığından DataGridView'de tıklamış olduğumuz satırı siliyoruz.
            gridSefer.Rows.RemoveAt(gridSefer.SelectedRows[0].Index);
        }

        private void buttonXMLKaydet_Click_1(object sender, EventArgs e)//bilgilerin kayıt edildiği buton
        {
            SeferlerKaydet Sefer = new SeferlerKaydet();

            DataTable dt = (DataTable)gridSefer.DataSource;
            Sefer.SeferlerleriKaydet(dt);//xml'e kayıt ediliyor
            MessageBox.Show("Bilgiler kaydedildi");//mesaj veriliyor
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//seferlerin seçildiği combobox
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (comboBox1.Text == Convert.ToString(dataGridView1.Rows[i].Cells[2].Value))
                {
                    label3.Text = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + " " + Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                    label5.Visible = true;
                }
        }
    }
}

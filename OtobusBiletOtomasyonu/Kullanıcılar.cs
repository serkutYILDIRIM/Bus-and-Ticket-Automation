using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Otobus
{
    public partial class Kullanıcılar : Form//Kullanıcı eklediğimiz form
    {
        public Kullanıcılar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { }

     

        private void buttonXMLKaydet_Click(object sender, EventArgs e)//Kaydetme butonumuz
        {
            KullanıcıKaydet kullanıcı = new KullanıcıKaydet();

            DataTable dt = (DataTable)gridKullanıcı.DataSource;
            kullanıcı.KullanıcılarıKaydet(dt);
            MessageBox.Show("Bilgiler kaydedildi");

        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();//listeleme işlemi yapan metot
        }


        private void buttonSil_Click_1(object sender, EventArgs e)
        {
            //Sil butonuna tıklandığından DataGridView'de tıklamış olduğumuz satırı siliyoruz.
            gridKullanıcı.Rows.RemoveAt(gridKullanıcı.SelectedRows[0].Index);
        }

        private void buttonEkle_Click_1(object sender, EventArgs e)
        {
            KullanıcıKaydet kullanıcı = new KullanıcıKaydet();//textboxlara yazdıklarımız "kullanıcı" sınıfındaki değişkenlere "get-set"metotları ile atanıyor

            kullanıcı.SıraNo = textBoxSiraNo.Text;
            kullanıcı.KullanıcıAdı= textBoxKullaniciAdi.Text;
            kullanıcı.Sifre = textBoxSifre.Text;
            kullanıcı.AD = textBoxAd.Text;
            kullanıcı.SOYAD = textBoxSoyad.Text;
            kullanıcı.TcKİMLİK = textBoxTcKimlik.Text;


            kullanıcı.KullanıcılarıKaydet();//en sonda kayıt ediliyor


            Listele();//liste kayıtlar eklendikten sonra tekrar çağırılıyor
            MessageBox.Show("Kullanıcı eklendi");

       

            DataTable dt = (DataTable)gridKullanıcı.DataSource;
            kullanıcı.KullanıcılarıKaydet(dt);
            MessageBox.Show("Bilgiler kaydedildi");
        }

        private void buttonDuzenle_Click_1(object sender, EventArgs e)
        {
            //Düzenle butonuna bastığımızda datagridview'den değeri textboxlara çekiyoruz.

            gridKullanıcı.SelectedRows[0].Cells[0].Value = textBoxSiraNo.Text;
            gridKullanıcı.SelectedRows[0].Cells[1].Value = textBoxKullaniciAdi.Text;
            gridKullanıcı.SelectedRows[0].Cells[2].Value = textBoxSifre.Text;
            gridKullanıcı.SelectedRows[0].Cells[3].Value = textBoxAd.Text;
            gridKullanıcı.SelectedRows[0].Cells[4].Value = textBoxSoyad.Text;
            gridKullanıcı.SelectedRows[0].Cells[5].Value = textBoxTcKimlik.Text;
        }

        private void gridKullanıcı_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DatagridView'in mauseClick Event'ini kullanarak seçili satıra tıklandığından 
            //ilgili textboxların içeriğinin dolmasını sağlıyoruz.
            textBoxSiraNo.Text = gridKullanıcı.SelectedRows[0].Cells[0].Value.ToString();
            textBoxKullaniciAdi.Text = gridKullanıcı.SelectedRows[0].Cells[1].Value.ToString();
            textBoxSifre.Text = gridKullanıcı.SelectedRows[0].Cells[2].Value.ToString();
            textBoxAd.Text = gridKullanıcı.SelectedRows[0].Cells[3].Value.ToString();
            textBoxSoyad.Text = gridKullanıcı.SelectedRows[0].Cells[4].Value.ToString();
            textBoxTcKimlik.Text = gridKullanıcı.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void dataGridKullanıcı_MouseClick(object sender, MouseEventArgs e)
        {

            textBoxSiraNo.Text = gridKullanıcı.SelectedRows[0].Cells[0].Value.ToString();
            textBoxKullaniciAdi.Text = gridKullanıcı.SelectedRows[0].Cells[1].Value.ToString();
            textBoxSifre.Text = gridKullanıcı.SelectedRows[0].Cells[2].Value.ToString();
            textBoxAd.Text = gridKullanıcı.SelectedRows[0].Cells[3].Value.ToString();
            textBoxSoyad.Text = gridKullanıcı.SelectedRows[0].Cells[4].Value.ToString();
            textBoxTcKimlik.Text = gridKullanıcı.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void Listele()//kayıtlarımızı listeleyen metotdumuz
        {
            KullanıcıKaydet kullanıcı = new KullanıcıKaydet();

            DataTable dt = kullanıcı.KullanıcıListesiGetir();
            gridKullanıcı.DataSource = dt;
        }

        private void textBoxSiraNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kullanıcılar_Load(object sender, EventArgs e)
        {
            Listele();//kullanıcıları listeliyoruz
        }

        private void groupBoxIsDetayEkleDuzenle_Enter(object sender, EventArgs e)
        {

        }
    }

}

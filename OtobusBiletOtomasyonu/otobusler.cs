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
    public partial class otobusler : Form//otobüsleri eklediğimiz sınıfımız
    {
        public otobusler()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            OtobusKaydet otobus = new OtobusKaydet();

            otobus.PLAKA = textPlaka.Text;//textbox'lardan gelen bilgileri "get-set" metotları yardımıyla değişkenlere atıyor
            otobus.KAPASİTE = textKapasite.Text;
            otobus.SEFERNO = textSeferNo.Text;

            otobus.OtobusleriKaydet();//değişkenlere "get-set" yardımı ile atanan bilgiler kayıt ediliyor


            Listele();//liste yenileniyor
            MessageBox.Show("Otobus eklendi");//mesaj veriliyor


            DataTable dt = (DataTable)gridOtobus.DataSource;
            otobus.OtobusleriKaydet(dt);//xml'le kayıt ediliyor
            MessageBox.Show("Bilgiler kaydedildi");//mesaj veriliyor
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            //Sil butonuna tıklandığından DataGridView'de tıklamış olduğumuz satırı siliyoruz.
            gridOtobus.Rows.RemoveAt(gridOtobus.SelectedRows[0].Index);
            OtobusKaydet otobus = new OtobusKaydet();

            DataTable dt = (DataTable)gridOtobus.DataSource;
            otobus.OtobusleriKaydet(dt);//xml'le kayıt ediliyor
            MessageBox.Show("Bilgiler kaydedildi");//mesaj veriliyor
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            //Düzenle butonuna bastığımızda datagridview'den değeri textboxlara çekiyoruz.

            gridOtobus.SelectedRows[0].Cells[0].Value = textPlaka.Text;
            gridOtobus.SelectedRows[0].Cells[1].Value = textKapasite.Text;
            gridOtobus.SelectedRows[0].Cells[2].Value = textSeferNo.Text;
        }

        private void buttonXMLKaydet_Click(object sender, EventArgs e)
        {
            OtobusKaydet otobus = new OtobusKaydet();

            DataTable dt = (DataTable)gridOtobus.DataSource;
            otobus.OtobusleriKaydet(dt);//xml'le kayıt ediliyor 
            MessageBox.Show("Bilgiler kaydedildi");
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();//liste xml'den alınıyor
        }

        private void gridOtobus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DatagridView'in mauseClick Event'ini kullanarak seçili satıra tıklandığından 
            //ilgili textboxların içeriğinin dolmasını sağlıyoruz.

        }
        private void dataGridOtobusler_MouseClick(object sender, MouseEventArgs e)
        {

            textPlaka.Text = gridOtobus.SelectedRows[0].Cells[0].Value.ToString();//Datagrid'e tıklandığında ilgili textbox'ların seçilmesini sağlıyoruz
            textKapasite.Text = gridOtobus.SelectedRows[0].Cells[1].Value.ToString();
            textSeferNo.Text = gridOtobus.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void Listele()//kayıtların listelendiği yer
        {
            OtobusKaydet otobus = new OtobusKaydet();

            DataTable dt = otobus.OtobusListesiGetir();
            gridOtobus.DataSource = dt;
        }

        private void groupBoxIsDetayEkleDuzenle_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxIsDetay_Enter(object sender, EventArgs e)
        {

        }

        private void otobusler_Load(object sender, EventArgs e)
        {
            Listele();//form açıldığında kayıtların gelmesi için "listele" metodu çağırılıyor
        }
    }
}

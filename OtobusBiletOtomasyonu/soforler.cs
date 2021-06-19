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
    public partial class soforler : Form//şoforlerin eklendiği form
    {
        public soforler()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)//sofor ekleme butonumuz
        {
            SoforKaydet sofor = new SoforKaydet();

            sofor.AD = txtAd.Text;//texbox'lardaki bilgiler "get-set" metotlarıyla değişkenlere atanıyor
            sofor.SOYAD = txtSoyad.Text;
            sofor.TcKİMLİK = txtTC.Text;
            sofor.TELEFON = txtTel.Text;
            sofor.ADRES = txtAdres.Text;

            sofor.SoforleriKaydet();//kayıt ediliyor


            Listele();//liste yenileniyor
            MessageBox.Show("Şöför eklendi");//mesaj veriliyor
          

            DataTable dt = (DataTable)gridSofor.DataSource;
            sofor.SoforleriKaydet(dt);//xml'e kayıt edliyor
            MessageBox.Show("Bilgiler kaydedildi");//mesaj veriliyor
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)//düzemleme işlemi yapılan buton
        {
            //Düzenle butonuna bastığımızda datagridview'den değeri textboxlara çekiyoruz.

            gridSofor.SelectedRows[0].Cells[0].Value = txtAd.Text;
            gridSofor.SelectedRows[0].Cells[1].Value = txtSoyad.Text;
            gridSofor.SelectedRows[0].Cells[2].Value = txtTC.Text;
            gridSofor.SelectedRows[0].Cells[3].Value = txtTel.Text;
            gridSofor.SelectedRows[0].Cells[4].Value = txtAdres.Text;
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            //Sil butonuna tıklandığından DataGridView'de tıklamış olduğumuz satırı siliyoruz.
            gridSofor.Rows.RemoveAt(gridSofor.SelectedRows[0].Index);
        }

        private void buttonXMLKaydet_Click(object sender, EventArgs e)//kayıt işlemi yapılan buton
        {
            SoforKaydet sofor = new SoforKaydet();

            DataTable dt = (DataTable)gridSofor.DataSource;
            sofor.SoforleriKaydet(dt);//xml'e kayıt ediliyor
            MessageBox.Show("Bilgiler kaydedildi");//mesaj veriliyor
        }

        private void buttonXMLAl_Click(object sender, EventArgs e)
        {
            Listele();//kayıtlar listeleniyor
        }

        private void gridSofor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DatagridView'in mauseClick Event'ini kullanarak seçili satıra tıklandığından 
            //ilgili textboxların içeriğinin dolmasını sağlıyoruz.
        }
        private void dataGridSofor_MouseClick(object sender, MouseEventArgs e)
        {

            txtAd.Text = gridSofor.SelectedRows[0].Cells[0].Value.ToString();//ilgili hücreye tıklamamızı sağlıyor
            txtSoyad.Text = gridSofor.SelectedRows[0].Cells[1].Value.ToString();
            txtTC.Text = gridSofor.SelectedRows[0].Cells[2].Value.ToString();
            txtTel.Text = gridSofor.SelectedRows[0].Cells[3].Value.ToString();
            txtAdres.Text = gridSofor.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void Listele()//listeleme metodumuz
        {
            SoforKaydet sofor = new SoforKaydet();

            DataTable dt = sofor.SoforListesiGetir();
            gridSofor.DataSource = dt;
        }

        private void soforler_Load(object sender, EventArgs e)
        {
            Listele();//form açıldığında kayıtların gelmesini sağlıyor
        }
    }
}

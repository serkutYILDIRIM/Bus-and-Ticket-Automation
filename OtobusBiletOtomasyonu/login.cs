using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;

namespace Otobus
{
    public partial class login : Form
    {
        void yavruform(Form yavru)//Form içinde form açmak için "yavruform" metodunu kullanıyoruz
        {

            yavru.Show();

        }

        public login()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string DosyaYolu = "Kullanıcılar" + ".xml";
            //XML dosyamızın var olup olmadığını kontrol için ilk önce bir değişkene dosya yolunu atıyoruz.
            if (System.IO.File.Exists(DosyaYolu))
            {//Eğer Dosyo yolunda belirtilen değer var ise aşağıdaki işlemler yapılıyor.
                DataSet ds = new DataSet();
                //Az önce oluşturduğumuz dataset private olduğundan burada yeniden oluşturuyoruz.
                ds.ReadXml("Kullanıcılar.xml");

                foreach (DataRow item in ds.Tables["Kullanıcılar"].Rows)
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




        }

        private void btnGiris_Click(object sender, EventArgs e)//Kullanıcı bilgilerinin doğruluğu burda kontrol ediliyor.Doğruysa giriş yapılıyor,yanlışsa
        {if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")//"Yanlış şifre veya kullanıcı adı" mesajı veriliyor
                label3.Text = "Kullanıcı adı veya Şifre boş olamaz";
            else {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((txtKullaniciAdi.Text == Convert.ToString(dataGridView1.Rows[i].Cells[1].Value)) && (txtSifre.Text == Convert.ToString(dataGridView1.Rows[i].Cells[2].Value)))
                    {
                        this.Visible = false;
                        AnaSayfa frm = new AnaSayfa();

                        frm.ShowDialog();
                    }
                    else
                    { label3.Text = "Yanlış Şifre veya Kullanıcı adı"; }
                }
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

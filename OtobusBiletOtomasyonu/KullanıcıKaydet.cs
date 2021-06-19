using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Otobus
{
    class KullanıcıKaydet:İnsan//"İnsan" sınıfından kalıtım alındığı için "insan" sınıfının altındaki değişkenlerede erişebiliyoruz.Bu sayede aynı değişkenleri defalarca
    {                          //yazmıyoruz
        private string sıraNo;//Değişkenleri "private" yaparak erişimi engelledik
        private string kullanıcıAdı;
        private string sifre;
        public string SıraNo//Değişkenleri kapsulleme yaparak direk erişimi engelledik.Kullanıcı bizim istediğimiz şekilde değişkenlere erişiyor
        {
            get { return sıraNo; }
            set { sıraNo = value; }
        }
        public string KullanıcıAdı
        {
            get { return kullanıcıAdı; }
            set { kullanıcıAdı = value; }
        }
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }

        public static string dosyaYolu = "Kullanıcılar.xml";//xml dosya yolumuz

        private DataSet dsKullanıcılar = new DataSet("KullanıcıListesi");
        private DataTable dataTableKullanıcı = new DataTable("Kullanıcılar");

        //Constructor (kurucu metod, class ismi ile aynı)
        public KullanıcıKaydet()
        {
            DataSetOlustur();
        }

        private void DataSetOlustur()
        {
            if (System.IO.File.Exists(dosyaYolu)) //Daha önce dosya oluşturulmuşsa dosyadan bilgileri oku
            {
                dsKullanıcılar.ReadXml(dosyaYolu);
                dataTableKullanıcı = dsKullanıcılar.Tables[0];
            }
            else //Dosya yoksa ilk defa kayıt için DataTable oluştur:
            {
                dataTableKullanıcı.Columns.Add("SıraNo");
                dataTableKullanıcı.Columns.Add("KullanıcıAdı");
                dataTableKullanıcı.Columns.Add("Sifre");
                dataTableKullanıcı.Columns.Add("Ad");
                dataTableKullanıcı.Columns.Add("Soyad");
                dataTableKullanıcı.Columns.Add("TcKimlik");

                dsKullanıcılar.Tables.Add(dataTableKullanıcı);

                dsKullanıcılar.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);
            }

        }

        public DataTable KullanıcıListesiGetir()
        {
            return dataTableKullanıcı;

        }

        public void KullanıcılarıKaydet()
        {
            //Kayıt ekleme:
            DataRow row = dataTableKullanıcı.NewRow();
            row["SıraNo"] = sıraNo;
            row["KullanıcıAdı"] = kullanıcıAdı;
            row["Sifre"] = sifre;
            row["Ad"] = Ad;
            row["Soyad"] = Soyad;
            row["TcKimlik"] = tcKimlik;
            dataTableKullanıcı.Rows.Add(row);

            dsKullanıcılar.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);

        }

        public void KullanıcılarıKaydet(DataTable dt)
        {
            //Gridview tamamını tablo olarak kaydetmek için Datasetteki Datatable önce silinir:
            dsKullanıcılar.Tables.Clear();
            //Yeni Datatable kopyalanır:
            dataTableKullanıcı = dt.Copy();
            //Datatable tekrar datasete eklenir:
            dsKullanıcılar.Tables.Add(dataTableKullanıcı);

            dsKullanıcılar.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);
        }

    }
}


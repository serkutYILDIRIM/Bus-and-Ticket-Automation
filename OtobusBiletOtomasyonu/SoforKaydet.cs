using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otobus
{
    class SoforKaydet:İnsan//İnsan sınıfından kalıtım aldık
    {
        private string telefon;//Değişkenleri "private" yaparak dışarıdan erişimi engelledik
        private string adres;
        public string TELEFON//Değişkenleri kapsulleyerek kullanıcıların değişkenlere direk erişimini engelledik.Bizim istediğimiz şekilde değişkenlere erişiliyor
        {
            get { return telefon; }
            set { telefon = value; }
        }
        public string ADRES
        {
            get { return adres; }
            set { adres = value; }
        }
        public static string dosyaYolu = "Soforler.xml";//xml dosya yolumuz

        private DataSet dsSoforler = new DataSet("SoforListesi");
        private DataTable dataTableSofor = new DataTable("Soforler");

        //Constructor (kurucu metod, class ismi ile aynı)
        public SoforKaydet()
        {
            DataSetOlustur();
        }
        private void DataSetOlustur()
        {
            if (System.IO.File.Exists(dosyaYolu)) //Daha önce dosya oluşturulmuşsa dosyadan bilgileri oku
            {
                dsSoforler.ReadXml(dosyaYolu);
                dataTableSofor = dsSoforler.Tables[0];
            }
            else //Dosya yoksa ilk defa kayıt için DataTable oluştur:
            {
                dataTableSofor.Columns.Add("Ad");
                dataTableSofor.Columns.Add("Soyad");
                dataTableSofor.Columns.Add("TcKimlik");
                dataTableSofor.Columns.Add("Telefon");
                dataTableSofor.Columns.Add("Adres");

                dsSoforler.Tables.Add(dataTableSofor);

                dsSoforler.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);
            }

        }
        public DataTable SoforListesiGetir()
        {
            return dataTableSofor;

        }

        public void SoforleriKaydet()
        {
            //Kayıt ekleme:
            DataRow row = dataTableSofor.NewRow();
            row["Ad"] = Ad;
            row["Soyad"] = Soyad;
            row["TcKimlik"] = tcKimlik;
            row["Telefon"] = telefon;
            row["Adres"] = adres;
            dataTableSofor.Rows.Add(row);

            dsSoforler.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);

        }
        public void SoforleriKaydet(DataTable dt)
        {
            //Gridview tamamını tablo olarak kaydetmek için Datasetteki Datatable önce silinir:
            dsSoforler.Tables.Clear();
            //Yeni Datatable kopyalanır:
            dataTableSofor = dt.Copy();
            //Datatable tekrar datasete eklenir:
            dsSoforler.Tables.Add(dataTableSofor);

            dsSoforler.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);
        }

    }
}

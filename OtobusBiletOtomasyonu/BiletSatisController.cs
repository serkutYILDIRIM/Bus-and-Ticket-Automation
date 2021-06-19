using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Otobus
{
    class BiletSatisController:İnsan//insan sınıfından kalıtım alındı
    {
        private string Telefon;
        private string Fiyat;
        private string koltukNo;
        private string tarih;
        private string nereden;//"SeferlerKaydet" sınıfıda buradan "OtobusKaydet" sınıfı üzerinden dolaylı yoldan kalıtım almış oldu
        private string nereye;
        private string seferNo;//OtobusKaydet'te seferNo burdan kalıtımla alındı

        public string TELEFON//Değişkenleri kapsülleyerek direk erişimi engelledik.Kullanıcı bizim istediğimiz yolla değişkene erişiyor
        {
            get { return Telefon; }
            set { Telefon = value; }
        }
        public string FİYAT
        {
            get { return Fiyat; }
            set { Fiyat = value; }
        }

        public string KOLTUKNO
        {
            get { return koltukNo; }
            set { koltukNo = value; }
        }
        public string TARİH
        {
            get { return tarih; }
            set { tarih = value; }
        }
        public string NEREDEN
        {
            get { return nereden; }
            set { nereden = value; }
        }
        public string NEREYE
        {
            get { return nereye; }
            set { nereye = value; }
        }
        public string SEFERNO
        {
            get { return seferNo; }
            set { seferNo = value; }
        }
        public static string dosyaYolu = "BiletKayıt.xml";
        private DataSet dsKayıtlar = new DataSet("KayıtListesi");
        private DataTable dataTableKayıt = new DataTable("Kayıtlar");
        public BiletSatisController()
        {
            DataSetOlustur();
        }
        private void DataSetOlustur()
        {
            if (System.IO.File.Exists(dosyaYolu)) //Daha önce dosya oluşturulmuşsa dosyadan bilgileri oku
            {
                dsKayıtlar.ReadXml(dosyaYolu);
                dataTableKayıt = dsKayıtlar.Tables[0];
            }
            else //Dosya yoksa ilk defa kayıt için DataTable oluştur:
            {
                dataTableKayıt.Columns.Add("Ad");
                dataTableKayıt.Columns.Add("Soyad");
                dataTableKayıt.Columns.Add("Telefon");
                dataTableKayıt.Columns.Add("Fiyat");
                dataTableKayıt.Columns.Add("Cinsiyet");
                dataTableKayıt.Columns.Add("KoltukNo");
                dataTableKayıt.Columns.Add("Tarih");
                dataTableKayıt.Columns.Add("Nereden");
                dataTableKayıt.Columns.Add("Nereye");
                dataTableKayıt.Columns.Add("SeferNo");

                dsKayıtlar.Tables.Add(dataTableKayıt);

                dsKayıtlar.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);
            }

        }
        public DataTable KayıtListesiGetir()
        {
            return dataTableKayıt;
        }
        public void YolcuKaydet()
        {
            //Kayıt ekleme:
            DataRow row = dataTableKayıt.NewRow();
            row["Ad"] = Ad;
            row["Soyad"] = Soyad;
            row["Telefon"] = Telefon;
            row["Fiyat"] = Fiyat;
            row["Cinsiyet"] = cinsiyet;
            row["KoltukNo"] = koltukNo;
            row["Tarih"] = tarih;
            row["Nereden"] = nereden;
            row["Nereye"] = nereye;
            row["SeferNo"] = seferNo;
            dataTableKayıt.Rows.Add(row);

            dsKayıtlar.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);

        }
        public void YolcuKaydet(DataTable dt)
        {
            //Gridview tamamını tablo olarak kaydetmek için Datasetteki Datatable önce silinir:
            dsKayıtlar.Tables.Clear();
            //Yeni Datatable kopyalanır:
      dataTableKayıt = dt.Copy();
            //Datatable tekrar datasete eklenir:
            dsKayıtlar.Tables.Add(dataTableKayıt);

            dsKayıtlar.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);



        }
    }

}

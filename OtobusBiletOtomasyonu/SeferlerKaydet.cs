using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Otobus
{
   
     class SeferlerKaydet :OtobusKaydet //"OtobusKaydet" kalıtımla "BiletSatışController'a"bağlı olduğu için "BiletSatışController'daki" özelliklerede 
    {                                   //erişebiliyoruz."BiletSatisController" sınıfıda kalıtımla "İnsan" sınıfına bağlı olduğu için "İnsan" sınıfındaki
        private string saat;            //özelliklerede erişebiliyoruz.Dolayısıyla kalıtım sayesinde bir özelliği bir sınıfta tanımlamamız yeterli hale 
                                        //geliyor
        public string SAAT
        {
            get { return saat; }
            set { saat = value; }
        }


        public static new string dosyaYolu = "Seferler.xml";//"new" anahtar sözcüğü kullanarak "OtobusKaydet" sınıfındaki "dosyaYolu" değişkenini
                                                            // ezdik(override ettik)
        private DataSet dsSeferlerler = new DataSet("Seferler");// Son derste anlatılan konu
        private DataTable dataTableSeferler = new DataTable("Seferler");

        //Constructor (kurucu metod, class ismi ile aynı)
        public SeferlerKaydet()
        {
            DataSetOlustur();
        }
        private void DataSetOlustur()
        {
            if (System.IO.File.Exists(dosyaYolu)) //Daha önce dosya oluşturulmuşsa dosyadan bilgileri oku
            {
                dsSeferlerler.ReadXml(dosyaYolu);
                dataTableSeferler = dsSeferlerler.Tables[0];
            }
            else //Dosya yoksa ilk defa kayıt için DataTable oluştur:
            {//tablomuzu oluşturuyoruz
                dataTableSeferler.Columns.Add("Plaka");
               
                dataTableSeferler.Columns.Add("saat");
                dataTableSeferler.Columns.Add("seferno");
                dataTableSeferler.Columns.Add("tcno");
                dataTableSeferler.Columns.Add("nereden");
                dataTableSeferler.Columns.Add("nereye");
                dsSeferlerler.Tables.Add(dataTableSeferler);

                dsSeferlerler.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);
            }

        }
        public DataTable SeferlerListesiGetir()
        {
            return dataTableSeferler;

        }

        public void SeferlerleriKaydet()
        {
            //Kayıt ekleme:
            DataRow row = dataTableSeferler.NewRow();
            row["plaka"] = PLAKA;
     
            row["saat"] = saat;
            row["seferno"] = SEFERNO;
            row["nereden"] = NEREDEN;
            row["nereye"] = NEREYE;
            row["tcno"] = tcKimlik;
            dataTableSeferler.Rows.Add(row);

            dsSeferlerler.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);

        }
        public void SeferlerleriKaydet(DataTable dt)
        {
            //Gridview tamamını tablo olarak kaydetmek için Datasetteki Datatable önce silinir:
            dsSeferlerler.Tables.Clear();
            //Yeni Datatable kopyalanır:
            dataTableSeferler = dt.Copy();
            //Datatable tekrar datasete eklenir:
            dsSeferlerler.Tables.Add(dataTableSeferler);

            dsSeferlerler.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);
        }

    }




   
}









  
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otobus
{
    class OtobusKaydet:BiletSatisController//"BiletSatisController" Sınıfı "İnsan" sınıfından kalıtım aldığı için insan sınıfının altındaki özelliklerede
    {                                      //erişebiliyoruz
        private string plaka;//değişkenleri gizleyerek dışarıdan erişimi engelledik
        private string kapasite;
        public string PLAKA//Değişkenleri kapsulleyerek kullanıcının istediğimiz şekilde değişkenlere erişmesini sağlıyoruz.
        {
            get { return plaka; }
            set { plaka = value; }
        }
        public string KAPASİTE
        {
            get { return kapasite; }
            set { kapasite = value; }
        }

        public static new string dosyaYolu = "Otobusler.xml";//"new" anahtar sözcüğü kullanarak "BiletSatisCotroller" sınıfındaki "dosyaYolu" değişkenini
                                                             // ezdik(override ettik)
        private DataSet dsOtobusler = new DataSet("OtobusListesi");//Son derste anlatılan konu
        private DataTable dataTableOtobus = new DataTable("Otobusler");

        //Constructor (kurucu metod, class ismi ile aynı)
        public OtobusKaydet()
        {
            DataSetOlustur();
        }
        private void DataSetOlustur()
        {
            if (System.IO.File.Exists(dosyaYolu)) //Daha önce dosya oluşturulmuşsa dosyadan bilgileri oku
            {
                dsOtobusler.ReadXml(dosyaYolu);
                dataTableOtobus = dsOtobusler.Tables[0];
            }
            else //Dosya yoksa ilk defa kayıt için DataTable oluştur:
            {
                dataTableOtobus.Columns.Add("Plaka");
                dataTableOtobus.Columns.Add("Kapasite");
                dataTableOtobus.Columns.Add("SeferNo");

                dsOtobusler.Tables.Add(dataTableOtobus);

                dsOtobusler.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);
            }

        }
        public DataTable OtobusListesiGetir()
        {
            return dataTableOtobus;

        }

        public void OtobusleriKaydet()
        {
            //Kayıt ekleme:
            DataRow row = dataTableOtobus.NewRow();
            row["Plaka"] = plaka;
            row["Kapasite"] = kapasite;
            row["SeferNo"] = SEFERNO;
            dataTableOtobus.Rows.Add(row);

            dsOtobusler.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);

        }
        public void OtobusleriKaydet(DataTable dt)
        {
            //Gridview tamamını tablo olarak kaydetmek için Datasetteki Datatable önce silinir:
            dsOtobusler.Tables.Clear();
            //Yeni Datatable kopyalanır:
            dataTableOtobus = dt.Copy();
            //Datatable tekrar datasete eklenir:
            dsOtobusler.Tables.Add(dataTableOtobus);

            dsOtobusler.WriteXml(dosyaYolu, XmlWriteMode.WriteSchema);
        }

    }
}

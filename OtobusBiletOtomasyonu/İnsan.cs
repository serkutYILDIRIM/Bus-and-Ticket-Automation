using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otobus
{
    class İnsan //Kalıtımda en üstteki sınıfımız.Diğer sınıflar "İnsan" sınıfından kalıtım alıyor.Birbirlerindende kalıtım alarak yeni ek özellikler
    {           //ekleniyor
        protected string Ad;//Türediği sınıflarda değişkenlere ihtiyaç olduğu için protected kullandık
        protected string Soyad;
        protected string tcKimlik;
        protected string cinsiyet;
        public string AD//Değişkenleri kapsülleyerek direk erişimi engelledik.Kullanıcı bizim istediğimiz yolla değişkene erişiyor
        {
            get { return Ad; }
            set { Ad = value; }
        }
        public string SOYAD
        {
            get { return Soyad; }
            set { Soyad = value; }
        }
        public string CİNSİYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }
        public string TcKİMLİK
        {
            get { return tcKimlik; }
            set { tcKimlik = value; }
        }

    }
}

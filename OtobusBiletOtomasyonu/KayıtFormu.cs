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
    public partial class KayıtFormu : Form
    {
        public KayıtFormu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BiletSatisController bilet = new BiletSatisController();

            bilet.AD = txtAd.Text;
            bilet.SOYAD = txtSoyad.Text;
            bilet.TELEFON = txtTelefon.Text;
            bilet.FİYAT = txtFiyat.Text;
            bilet.CİNSİYET = txtCinsiyet.Text;
            bilet.KOLTUKNO = txtKoltuk.Text;
            bilet.TARİH = txtdate.Text;
            bilet.NEREDEN = txtNereden.Text;
            bilet.NEREYE = txtNereye.Text;
            bilet.AD = txtAd.Text;
            bilet.SEFERNO = txtSeferNo.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
            bilet.YolcuKaydet();




        }

        private void KayıtFormu_Load(object sender, EventArgs e)
        {
     
        }

        private void txtCinsiyet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

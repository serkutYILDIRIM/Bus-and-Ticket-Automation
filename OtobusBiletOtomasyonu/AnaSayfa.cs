using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
namespace Otobus
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {

            InitializeComponent();//projenin ana sayfası burası.Login ekranından sonra buraya geliyoruz.Diğer formlara "anaSayfa" formundan seçilerek gidiliyor
           
        }
       



       
        void yavruform(Form yavru)// Form içinde form açmamızı sağlıyor.Aynı form içinde aynı formu açıyor
        {

            yavru.Show();

        }
        private void kullanıcılarıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ekleSilDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ekleSilDüzenleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Kullanıcılar frm = new Kullanıcılar();//Kullanıcılar sınıfından "frm" nesnesi türettik yeni formumuzu açmak için "yavruform" metoduna gönderdik
            yavruform(frm);                       //yavruform yeni form açmamızı sağlıyor
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login frm = new login();//Kullanıcılar sınıfından "frm" nesnesi türettik yeni formumuzu açmak için "yavruform" metoduna gönderdik
            yavruform(frm);         //yavruform yeni form açmamızı sağlıyor
        }

        private void otobüslerToolStripMenuItem_Click(object sender, EventArgs e)//otobüs formuna gidiyor
        {

            otobusler frm = new otobusler();
            frm.ShowDialog();
        }

        private void şoförlerToolStripMenuItem_Click(object sender, EventArgs e)//şoforler formuna gidiyor
        {
            soforler frm = new soforler();
            frm.ShowDialog();
        }

        private void biletSatisToolStripMenuItem_Click(object sender, EventArgs e)//kullanıcı formuna gidiyor
        {
            BiletSatis frm = new BiletSatis();
            frm.ShowDialog();
        }

        private void seferlerToolStripMenuItem_Click(object sender, EventArgs e)//seferler formuna gidiyor
        {
            Seferler frm = new Seferler();
            frm.ShowDialog();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)//anasayfamız
        {

        }
    
       

        private void button1_Click(object sender, EventArgs e)//bilet satış formuna gidiyor
        {
            BiletSatis frm = new BiletSatis();
            frm.ShowDialog();
        }

       
    }
}
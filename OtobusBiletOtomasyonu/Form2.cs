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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void yavruform(Form yavru)
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
        Form3 frm = new Form3();
            yavruform(frm);
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            login frm = new login();
            yavruform(frm);
        }

        private void otobüslerToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            otobuskaydet frm = new otobuskaydet();
            frm.ShowDialog();
        }

        private void şoförlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        soforler frm = new soforler();
            frm.ShowDialog();
        }

        private void biletSatisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BiletSatis frm = new BiletSatis();
            frm.ShowDialog();
        }
    }
}

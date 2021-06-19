using Otobus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormXmlKullanimi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new login());//login ekranından proje başlıyor
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
        }
    }
}

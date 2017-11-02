
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScraperNameSpace;

namespace AbsenceCheck
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Scraper s = new Scraper();
            var x = s.getHtmlDomFromFile("Sebastian_Spaqaj_Gustav_LectioFravaer.html");

            var ting = x.DocumentNode
                .SelectNodes("//table[id='s_m_Content_Content_fravaertbl']");

            Console.WriteLine(ting[0].InnerText);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

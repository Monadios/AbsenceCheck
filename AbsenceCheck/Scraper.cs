using System;

using HtmlAgilityPack;
using System.Text;

namespace ScraperNameSpace
{
    public class Scraper
    {
        private string ting;

        public Scraper()
        {
          
        }

        public HtmlDocument getHtmlDomFromWeb(string url)
        {
            var web = new HtmlWeb();
            web.OverrideEncoding = Encoding.UTF8;
            var doc = web.Load(url);
            return doc;
        }

        public HtmlDocument getHtmlDomFromFile(string path)
        {
            var doc = new HtmlDocument();
            doc.Load(path);
            return doc;
        }
    }
}

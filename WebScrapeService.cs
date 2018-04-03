using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace PraiseTeam.Services
{
    public class WebScrapeService : IWebScrapeService
    {

        public List<string> WebScrape()
        {
            List<string> scrape = new List<string>();
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("https://calvarychapel.com/content/conferences");
            HtmlNode[] nodes = document.DocumentNode.SelectNodes("//article[@class='simple-post clearfix']").ToArray();

            foreach (HtmlNode node in nodes)
            {
                scrape.Add((node.OuterHtml) + "<hr />");
            }
            return scrape;
        }
    }
}

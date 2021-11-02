using System;
using System.Threading.Tasks;
using CsvHelper;
using HtmlAgilityPack;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace FTaskFanning
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://www.emag.bg/");
            foreach (var item in doc.DocumentNode.SelectNodes("//p[@class='product-new-price']"))
            {
                Console.WriteLine(item.InnerText);
            }
            Console.ReadLine();
        }
    }
}
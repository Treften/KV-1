﻿using System;
using HtmlAgilityPack;
namespace AGi
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = @"https://2droida.ru/collection/smartfony";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(html);

            HtmlNodeCollection nodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='product-preview__title']/a");
          
            foreach (HtmlNode node in nodes)
            {
                htmlDoc = web.Load($@"https://2droida.ru{node.GetAttributeValue("href","")}");
                 HtmlNode pp = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='product-preview__price']/span");
                   if (pp == null)
                       {
                           Console.WriteLine($"{node.InnerText} Покупка только в розницу");
                           continue;
                       }
                Console.WriteLine(" Название: " +
                node.InnerText+ " Цена: "+ pp.InnerText);
            }
            Console.ReadLine();
        }
    }
}

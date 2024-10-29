using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LB6
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var parser = new Parser();
            string url = "https://2droida.ru/collection/galaxy-a05s/product/samsung-galaxy-a05s-6128gb-green-zelenyy";
            /* using (PhoneContext db = new PhoneContext())
             {
                 db.Brands.Add(new Brand(1,"Name"));
                 db.SaveChanges();
             }*/
          
                parser.Parse(url);
            string mainPage = "https://2droida.ru/collection/smartfony";
            List<string> phones = await parser.GetLinks(mainPage);
            foreach (string phoneUrl in phones)
            parser.Parse(phoneUrl);
           
            Console.ReadLine();
        }
    }
}

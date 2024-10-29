using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
namespace LB6
{
    class Parser
    {
        public async void Parse(string url)
        {
            IConfiguration config = Configuration.Default.WithDefaultLoader();
            IBrowsingContext context = BrowsingContext.New(config);
            IDocument doc = await context.OpenAsync(url);
            Smartphone smart = new Smartphone();
              IElement name = doc.QuerySelector("div.product__area-title");
            if (name != null)
            {
                smart.Name = name.TextContent.Trim();
            }
             
            var els = doc.QuerySelectorAll("div.product__property-value");
            if (els.Length > 0)
            {
                smart.Id = Guid.NewGuid();
                smart.Screen = FormatValue(els[0].TextContent);
                smart.Proccessor = FormatValue(els[1].TextContent);
                smart.Camera = FormatValue(els[2].TextContent);
                smart.RAM = FormatValue(els[3].TextContent);
           //  smart.brand = "brand";
       //         smart.BrandId = 1;
                using (PhoneContext db = new PhoneContext())
                {
                    db.Smartphones.Add(smart);
                    db.SaveChanges();
                }
            }

            Console.WriteLine(smart.GetInfo());
        }
        string FormatValue(string str)
        {
           
            string s = str.Trim();
             return   String.Join("", s.Split('@', ',', '.', ';', '\'','"'));
          

        }
        public async Task<List<string>> GetLinks(string url)
        {
            Console.WriteLine("Начинаем загрузку главной страницы");
            IConfiguration config = Configuration.Default.WithDefaultLoader();
            IBrowsingContext context = BrowsingContext.New(config);
            IDocument doc = await context.OpenAsync(url);
            Console.WriteLine("Начинаем считывание главной страницы");
          
            IEnumerable<IElement> aElements = doc.All.Where(block =>
            block.LocalName == "a"
            && block.ParentElement.LocalName == "div"
            && block.ParentElement.ClassList.Contains("product-preview__title"));
            List<string> output = new List<string>();
            foreach (IElement a in aElements.ToList())
                output.Add($"https://2droida.ru{a.GetAttribute("href")}");
            Console.WriteLine("Считывание главной страницы завершено");
            return output;
        }

    }
}

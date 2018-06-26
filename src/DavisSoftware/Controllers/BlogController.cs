using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace DavisSoftware.Controllers
{
    public class BlogController : Controller
    {
        public string Archive(DateTime? entryDate)
        {
            return "You wants Blog Entry on Date:=" + entryDate.ToString();
        }

        public ActionResult Index(int? year, int? month) 
        {
            //var face = new DavisSoftware.Models.BlogArticleModel()
            //{
            //    DateTime = DateTime.Parse("2010-06-04"),
            //    Heading = "Lessons from support",
            //    Content = "Here is a <strong>bold</strong> example"
            //};

            //TextWriter writer = new StreamWriter(@"C:\Temp\blah.xml");
            //var ser = new XmlSerializer(typeof(DavisSoftware.Models.BlogArticleModel));
            //ser.Serialize(writer, face);
            //writer.Close();

            var searchPattern = "";
            searchPattern += year.HasValue ? year.Value.ToString("D4") : "";
            searchPattern += month.HasValue ? month.Value.ToString("D2") : "";
            searchPattern += "*";

            var posts = Directory.EnumerateFiles(Server.MapPath("/BlogData"), searchPattern);

            if (!posts.Any())
            {
                return new HttpNotFoundResult();
            }
            if(posts.Count() > 1)
            {
                return new JsonResult() { Data = "There should ne be more than one" };
            }

            var reader = new StreamReader(posts.First());
            var ser = new XmlSerializer(typeof(Models.BlogArticleModel));
            var model = ser.Deserialize(reader);

            return View(model);
        }


    }
}
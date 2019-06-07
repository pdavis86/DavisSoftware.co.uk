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
            return "You want Blog Entry on Date:=" + entryDate.ToString();
        }

        public ActionResult Index(int? year, int? month)
        {
            var searchPattern =
                (year.HasValue ? year.Value.ToString("D4") : "")
                + (month.HasValue ? month.Value.ToString("D2") : "")
                + "*";

            var posts = Directory.EnumerateFiles(Server.MapPath("/BlogData"), searchPattern);

            if (!posts.Any())
            {
                return new HttpNotFoundResult();
            }
            if (posts.Count() > 1)
            {
                return new JsonResult() { Data = "There should not be more than one" };
            }

            var reader = new StreamReader(posts.First());
            var ser = new XmlSerializer(typeof(Models.BlogArticleModel));
            var model = ser.Deserialize(reader);

            return View(model);
        }


    }
}
using System.Web.Mvc;

namespace DavisSoftware.Controllers
{
    public class PagesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
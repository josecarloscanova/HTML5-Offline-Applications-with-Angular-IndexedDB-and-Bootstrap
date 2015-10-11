using System.Web;
using System.Web.Mvc;

namespace ApplicationCache.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
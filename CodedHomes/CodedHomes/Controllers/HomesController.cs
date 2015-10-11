using System.Web.Mvc;

namespace CodedHomes.Controllers
{
    public class HomesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View("edit");
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}
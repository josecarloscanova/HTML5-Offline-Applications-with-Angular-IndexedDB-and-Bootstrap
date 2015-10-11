using System.Web;
using System.Web.Mvc;

namespace ApplicationCache.Controllers
{
    public class ManifestController : Controller
    {
        public ActionResult Index()
        {
            Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
            Response.ContentType = "text/cache-manifest";
            return View();
        }
    }
}
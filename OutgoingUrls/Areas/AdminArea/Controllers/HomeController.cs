using System.Web.Mvc;

namespace OutgoingUrls.Areas.AdminArea.Controllers
{
    public class HomeController : Controller
    {
        // GET: AdminArea/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
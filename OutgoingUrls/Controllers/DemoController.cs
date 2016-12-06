using System.Web.Mvc;

namespace OutgoingUrls.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult CustomVariable()
        {
            return View();
        }

        public ActionResult Alpha(dynamic model)
        {
            return View(model);
        }
    }
}
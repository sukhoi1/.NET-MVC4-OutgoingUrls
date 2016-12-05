using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;

namespace OutgoingUrls.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult CustomVariable()
        {
            return View();
        }

        public ActionResult Alpha()
        {
            return View();
        }
    }
}
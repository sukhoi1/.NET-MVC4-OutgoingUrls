using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace OutgoingUrls.Helper
{
    public static class AlphaHelperClass
    {
        public static MvcHtmlString AlphaHelper<T>(this HtmlHelper helper, string absolutePathToView, T model)
        {
            return helper.Partial(absolutePathToView, model);
        }
    }
}
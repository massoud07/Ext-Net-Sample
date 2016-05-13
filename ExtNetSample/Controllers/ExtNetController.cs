using System.Web.Mvc;
using Ext.Net;
using Ext.Net.MVC;

namespace ExtNetSample.Controllers
{
    public class ExtNetController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
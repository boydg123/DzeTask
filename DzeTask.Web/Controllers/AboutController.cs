using System.Web.Mvc;

namespace DzeTask.Web.Controllers
{
    public class AboutController : DzeTaskControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
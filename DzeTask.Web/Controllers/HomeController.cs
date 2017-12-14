using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace DzeTask.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : DzeTaskControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
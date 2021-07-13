using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

namespace Vika_Shop.Controllers
{
	public class KosController: System.Web.Mvc.Controller
	{
        public IActionResult Index()
        {
            return (IActionResult)View();
        }
    }
}


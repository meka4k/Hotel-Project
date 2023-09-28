using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult _AdminLayout()
        {
            return View();
        }

        public IActionResult HeadPartial()
        {
            return PartialView();
        }

        public IActionResult PreloaderPartial()
        {
            return PartialView();
        }

        public IActionResult NavHeaderPartial()
        {
            return PartialView();
        }

        public IActionResult HeaderPartial()
        {
            return PartialView();
        }
        public IActionResult SidebarPartial()
        {
            return PartialView();
        }

        public IActionResult FooterPartial()
        {
            return PartialView();
        }

        public IActionResult ScriptPartial()
        {
            return PartialView();
        }
    }
}

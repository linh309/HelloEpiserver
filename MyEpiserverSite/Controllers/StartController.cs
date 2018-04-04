using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace MyEpiserverSite.Controllers
{
    public class StartController : PageController<Models.Pages.StartPage>
    {
        // GET: Start
        public ActionResult Index(StartPage startPage)
        {
            return View(startPage);
        }
    }
}
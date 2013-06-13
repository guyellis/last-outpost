using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LastOutpost.Controllers
{
    public class TravelController : Controller
    {
        public ActionResult Index(int? id, string slug)
        {
            return T(id, slug);
        }

        public ActionResult T(int? id, string slug)
        {
            if (!id.HasValue)
            {
                id = 1;
            }

            switch (id.Value)
            {
                case 1:
                default:
                    ViewBag.Travel = "_Art";
                    break;
                case 2:
                    ViewBag.Travel = "_Beach";
                    break;
                case 3:
                    ViewBag.Travel = "_Spain";
                    break;
                case 4:
                    ViewBag.Travel = "_Thorn";
                    break;
                case 5:
                    ViewBag.Travel = "_Mallorca";
                    break;
                case 6:
                    ViewBag.Travel = "_Wacky";
                    break;
            }

            return View("Index");
        }

    }
}

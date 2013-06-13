using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LastOutpost.Controllers
{
    public class MedicalController : Controller
    {
        public ActionResult Index(int? id, string slug)
        {
            return M(id, slug);
        }

        public ActionResult M(int? id, string slug)
        {
            if (!id.HasValue)
            {
                id = 1;
            }

            switch (id.Value)
            {
                case 1:
                default:
                    ViewBag.Medical = "_Depression";
                    break;
                case 2:
                    ViewBag.Medical = "_Door";
                    break;
                case 3:
                    ViewBag.Medical = "_Entry";
                    break;
            }

            return View("Index");
        }

    }
}

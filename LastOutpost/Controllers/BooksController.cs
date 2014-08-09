using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LastOutpost.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Index(int? id, string slug)
        {
            return B(id, slug);
        }

        public ActionResult B(int? id, string slug)
        {
            if (!id.HasValue)
            {
                id = 10;
            }

            switch (id.Value)
            {
                case 1:
                    ViewBag.Book = "_Echoes";
                    break;
                case 2:
                    ViewBag.Book = "_Rural";
                    break;
                case 3:
                    ViewBag.Book = "_Communicating";
                    break;
                case 4:
                    ViewBag.Book = "_Review";
                    break;
                case 5:
                    ViewBag.Book = "_Despatches";
                    break;
                case 6:
                    ViewBag.Book = "_SoftEdges";
                    break;
                case 7:
                    ViewBag.Book = "_Ruminations";
                    break;
                case 8:
                    ViewBag.Book = "_Hypertension";
                    break;
                case 9:
                    ViewBag.Book = "_Learning";
                    break;
                case 10:
                default:
                    ViewBag.Book = "_Chaos";
                    break;
            }

            return View("Index");
        }
    }
}

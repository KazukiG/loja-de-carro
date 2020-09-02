using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrilhaOnline.Presentation.Rent.UI.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cars()
        {
            return View();
        }

        public ActionResult Parts()
        {
            return View();
        }

        public ActionResult _partialCreateCars()
        {
            return View();
        }
    }
}
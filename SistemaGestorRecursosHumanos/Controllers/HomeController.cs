using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaGestorRecursosHumanos.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult mantenimiento()
        {
            return View();
        }
        
        public ActionResult procesos()
        {
            return View();
        }
    }
}
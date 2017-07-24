using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRRSystem.Controllers
{

        public class HomeController : Controller
        {
            //
            // GET: /Home/

            public ActionResult Index()
            {
                return View();
            }

            public ActionResult Activities()
            {
                return View();
            }
            public ActionResult Rooms()
            {
                return View();
            }
            public ActionResult Reservation()
            {
                return View();
            }
            public ActionResult Details()
            {
                return View();
            }
            public ActionResult Contact()
            {
                return View();
            }

        }
    }

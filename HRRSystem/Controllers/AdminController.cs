using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRRSystem.Models;

namespace HRRSystem.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            HRRSEntities db = new HRRSEntities();
            IEnumerable<Admin> admins = db.Admins.ToList();
            return View(admins);
        }

        public ActionResult Reservations()
        {
            return View();
        }
        public ActionResult All()
        {
            HRRSEntities db = new HRRSEntities();
            IEnumerable<Reservation> res = db.Reservations.ToList();
            return View("_reservationdata", res);
        }

        public ActionResult Checkins()
        {
            HRRSEntities db = new HRRSEntities();
            DateTime date = Convert.ToDateTime("2/2/2017");
            IEnumerable<Reservation> res = db.Reservations.Where(x => x.check_in == date).ToList();
            return View("_reservationdata", res);
        }

        public ActionResult Checkouts()
        {
            HRRSEntities db = new HRRSEntities();
            DateTime date = Convert.ToDateTime("2/2/2017");
            IEnumerable<Reservation> res = db.Reservations.Where(x => x.check_out == date).ToList();
            return View("_reservationdata", res);
        }
    }
}

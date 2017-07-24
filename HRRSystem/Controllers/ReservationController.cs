using HRRSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRRSystem.Controllers
{
    public class ReservationController : Controller
    {
        //
        // GET: /Reservation/

        public ActionResult Index()
        {
            Reservation res = new Reservation();
            res.name = Request.Form["userName"];
            res.nic=Request.Form["userNic"];
            res.check_in = Convert.ToDateTime("02/02/2017");
            res.check_out = Convert.ToDateTime("03/02/2017");
            res.rooms = "SingleRoom";
            res.adults = 5;

            //ViewBag.Name=Request.Form["userName"];
            //ViewBag.Nic=Request.Form["userNic"];
            HRRSEntities hrrsEntites = new HRRSEntities();
            hrrsEntites.AddReservation(res);
            //return View(ViewBag);
            return RedirectToAction("index", "Home");
        }



    }

    }

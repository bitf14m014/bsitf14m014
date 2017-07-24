using HRRSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRRSystem.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {

            Contact contact = new Contact();
            string userName = Request.Form["userName"];
            string userEmial = Request.Form["userEmail"];
            string userMobile = Request.Form["userMobile"];
            string userSubject = Request.Form["userSubject"];
            contact.name = userName;
            contact.email = userEmial;
            contact.mobile = userMobile;
            contact.consubject = userSubject;
            HRRSEntities hrrsEntities = new HRRSEntities();
            hrrsEntities.AddContacts(contact);


            return RedirectToAction("index", "Home");
        }


    }
}

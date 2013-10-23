using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMD_Tickets.Controllers
{
    public class AttendeesController : Controller
    {
        //
        // GET: /Attendees/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Grant()
        {
            Models.AttendeeModel am = new Models.AttendeeModel();
            ViewBag.attendee = am.selectAll();
            return View();
        }
    }
}
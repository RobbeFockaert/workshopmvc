﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace IMD_Tickets.Controllers
{
    public class TicketsController : Controller
    {
        //
        // GET: /Tickets/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Grant()
        {
            Models.TicketModel tm = new Models.TicketModel();
            ViewBag.tickets = tm.selectAll();
            return View();
        }
        public void insertTicket(){
            Models.TicketModel tm = new Models.TicketModel();
            tm.insert();
        }
    }
}

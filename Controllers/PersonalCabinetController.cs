﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATOM.Controllers
{
    public class PersonalCabinetController : Controller
    {
        // GET: PersonalCabinet
        public ActionResult EmployerCabinet()
        {
            return View();
        }

        public ActionResult ImproverCabinet()
        {
            return View();
        }

        public ActionResult VladykaCabinet()
        {
            return View();
        }
    }
}
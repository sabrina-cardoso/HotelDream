﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelDreamWeb.Controllers
{
    public class ReservarController : Controller
    {
        // GET: Reservar
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void DetalheQuarto()
        {
            Response.Redirect("/Hospede/Login");
        }

        public ActionResult detalhedopedido1()
        {
            return View();
        }
    }
}
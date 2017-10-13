using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Addresses.Models;

namespace Addresses.Controllers
{
   public class HomeController : Controller
   {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpGet("/AddressBook")]
      public ActionResult Contact()
      {
        return View();
      }

      [HttpGet("AddressBook/New")]
      public ActionResult Form()
      {
        return View();
      }
   }
}

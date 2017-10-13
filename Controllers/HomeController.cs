using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ToDoLists.Models;

namespace Addresses.Controllers
{
   public class HomeController : Controllers
   {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      
   }
}

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
      public ActionResult ViewContact()
      {
        List<Contact> allContact = Contact.GetAll();
        return View(allContact);
      }

      [HttpPost("/AddressBook/New/Contact")]
      public ActionResult ResultContact()
      {
        Contact newContact = new Contact(Request.Form["name-contact"],Request.Form["number-contact"],Request.Form["address-contact"]);
        return View("ContactAdd");
      }

      [HttpGet("AddressBook/New")]
      public ActionResult Form()
      {
        return View();
      }

      [HttpGet("AddressBook/New/Contact")]
      public ActionResult ContactAdd()
      {
        return View();
      }

   }
}

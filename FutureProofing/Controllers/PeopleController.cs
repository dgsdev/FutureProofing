using Microsoft.AspNetCore.Mvc;
using People.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleViewer.Controllers
{
    public class PeopleController : Controller
    {
        PersonReader reader = new PersonReader();
        public IActionResult UseConcreteType()
        {
            ViewData["Title"] = "Using Concrete Type";
            return View("Index", null);
        }
        public IActionResult UseAbstractType()
        {
            ViewData["Title"] = "Using Abstract Type";
            return View("Index", null);
        }
    }
}

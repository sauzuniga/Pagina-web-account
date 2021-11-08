using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Apps.Models;

namespace Apps.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.name = "Saul";
            personal.lastname= "Zuniga";
            personal.age=20;
            personal.email = "saulzuniga606@gmail.com";
            personal.number = 56464684;
            personal.address ="Residencial Terranova,calle el rocio poniente,San Miguel,San Miguel";
            return View(personal);
        }
    }
}
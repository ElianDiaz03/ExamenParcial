using EjercicioParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EjercicioParcial.Controllers
{
    public class automaticoController : Controller
    {
        // GET: automatico
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Indexx()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Dinero()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ErrorNumero()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Indexx(automatico p)
        {
            if (p.Dinero % 5 == 0)
            {
                return Redirect("Dinero");
            }
            else
            {
                return Redirect("ErrorNumero");
            }


           
            


        }
       
    }
}
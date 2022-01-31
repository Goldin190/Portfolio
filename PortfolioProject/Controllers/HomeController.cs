using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace PortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int age = (DateTime.Today.Year - DateTime.Parse("03-02-1999").Year);
            if(DateTime.Parse("03-02-1999") > DateTime.Today.AddYears(-age))
            {
                age-=1;
            }
            ViewBag.Age = age.ToString();
            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Moje Projekty";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakt";

            return View();
        }
    }
}
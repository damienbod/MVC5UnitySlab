using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5UnitySlab.Business;

namespace MVC5UnitySlab.Controllers
{
    [RoutePrefix("MyHome")] 
    public class HomeController : Controller
    {
        private IBusinessClass2 _businessClass2;
        private IBusinessClass _businessClass;

        public HomeController(IBusinessClass2 businessClass2, IBusinessClass businessClass)
        {
            _businessClass = businessClass;
            _businessClass2 = businessClass2;
        }

         [Route("{Index}")] 
        public ActionResult Index()
        {
            _businessClass.Hello();
            _businessClass2.Hello();
            _businessClass2.SayHello("using unity happily");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INF272_F4Y.Models;

namespace INF272_F4Y.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        dbF4Entities db = new dbF4Entities();
        public ActionResult Index() 
        {         
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult SearchResults()
        {
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        public ActionResult ViewProfile()
        {
            return View();
        }

        public ActionResult ViewProfileEmployee()
        {
            return View();
        }

        public ActionResult ViewProfileEmployer()
        {
            return View();
        }

        public ActionResult LoginEmp()
        {
            return View();
        }

        public ActionResult UpdateEmp()
        {
            return View();
        }

        public ActionResult RegisterEmp()
        {
            return View();
        }
    }
}
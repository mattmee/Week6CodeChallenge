using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week6CodeChallenge.Models;

namespace Week6CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else
                return View();
        }

        public ActionResult About()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else
                return View();
        }

        public ActionResult Work()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else
                return View();
        }

        public ActionResult Careers()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else
                return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            if (Request.IsAjaxRequest())
                return PartialView();
            else
                return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            //process stuff...send email, form to database, whatever...
            ContentDataAccess.InsertContact(contact);
            return PartialView();
        }
    }
}
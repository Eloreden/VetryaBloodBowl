using System.Linq;
using System.Web.Mvc;
using System.Diagnostics;
using VetryaBloodBowl.Models;
using VetryaBloodBowl.DAL;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using System.Web;
using Microsoft.Owin.Security;
using System;
using System.Web.Helpers;

namespace VetryaBloodBowl.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripUp.Models;

namespace TripUp.WebMVC.Controllers
{
    [Authorize]
    public class TripController : Controller
    {
        // GET: Trip
        public ActionResult Index()
        {
            var model = new TripListItem[0];
            return View(model);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TripUp.WebMVC.Controllers
{
    public class ItineraryController : Controller
    {
        // GET: Itinerary
        public ActionResult Index()
        {
            return View();
        }
    }
}
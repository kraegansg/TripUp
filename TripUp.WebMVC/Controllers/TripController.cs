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

        //Add method here VVV
        //GET
        public ActionResult Create()
        {
            return View();
        }

        //Add code here VVVV
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TripCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}
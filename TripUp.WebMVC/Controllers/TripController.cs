using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripUp.Models;
using TripUp.Services;

namespace TripUp.WebMVC.Controllers
{
    [Authorize]
    public class TripController : Controller
    {
        // GET: Trip
        public ActionResult Index()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TripService(userId);
            var model = service.GetTrips();
            return View(model);
        }

        //Add method here VVV
        //GET
        public ActionResult Create()
        {
            return View();
        }

        //Add code here VVVV
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TripCreate model)
        {
            if (ModelState.IsValid) return View(model);

            var service = CreateTripMethod();

            if (service.CreateTrip(model))
            {
                TempData["SaveResult"] = "Trip created successfully.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Trip could not be created.");
            return View(model);
            
        }

        private TripService CreateTripMethod()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TripService(userId);
            return service;
        }
    }
}
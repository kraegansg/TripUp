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

            var service = CreateTripService();

            if (service.CreateTrip(model))
            {
                TempData["SaveResult"] = "Trip created successfully.";
                return RedirectToAction("Index");
            };
            ModelState.AddModelError("", "Trip could not be created.");
            return View(model);
            
        }

        public ActionResult Details(int id)
        {
            var svc = CreateTripService();
            var model = svc.GetTripById(id);

            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var service = CreateTripService();
            var detail = service.GetTripById(id);
            var model =
                new TripEdit
                {
                    TripId = detail.TripId,
                    TripName = detail.TripName,
                    Destination = detail.Destination,
                    StartingLocation = detail.StartingLocation,
                    TravelBuddies = detail.TravelBuddies,

                };
            return View(model);
        }

        private TripService CreateTripService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var service = new TripService(userId);
            return service;
        }
    }
}
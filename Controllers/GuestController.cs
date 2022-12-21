using Hotel_Management_Project.DAL;
using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_Project.Controllers
{
    public class GuestController : Controller
    {
        DataContext db = new DataContext();
        private IGuestRepository _guestRepository;
        public GuestController()
        {
            _guestRepository = new GuestRepository(new Models.DataContext());
        }
        // GET: Guest
        public ActionResult Index()
        {
            var model = _guestRepository.GetAllGuest();
            return View(model);
        }

       

        // GET: Guest/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: Guest/Create
        [HttpPost]
        public ActionResult Create(Guest model)
        {
            try
            {
                 _guestRepository.AddGuest(model);



                  return RedirectToAction("Index", "Guest");



            }
            catch
            {
                return View();
            }
        }

        // GET: Guest/Edit/5
        public ActionResult Edit(int id)
        {
            if (TempData["Failed"] != null)
            {
                ViewBag.Failed = "Edit book Failed";

            }
            Guest model = _guestRepository.GetGuestById(id);
            return View(model);
        }

        // POST: Guest/Edit/5
        [HttpPost]
        public ActionResult Edit(Guest collection)
        {
            if (ModelState.IsValid)
            {
                int result = _guestRepository.UpdateGuest(collection);

                if (result > 0)
                {
                    return RedirectToAction("Index", "Guest");
                }
                else
                {
                    return RedirectToAction("Index", "Guest");
                }
            }
            return View();
        }

        // GET: Guest/Delete/5
        public ActionResult Delete(int id)
        {
            Guest guest = _guestRepository.GetGuestById(id);
            return View(guest);
        }

        // POST: Guest/Delete/5
        [HttpPost]
        public ActionResult Delete(Guest collection)
        {
           
            
            
            try
            {
                // TODO: Add delete logic here
                _guestRepository.DeleteGuest(collection.guest_id);


               return RedirectToAction("Index", "Guest");


            }
            catch
            {
                return View();
            }
        }
    }
}

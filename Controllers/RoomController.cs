using Hotel_Management_Project.DAL;
using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_Project.Controllers
{
    public class RoomController : Controller
    {
        // GET: Room
        private _IRoomRepository _roomRepository;

        public RoomController()
        {
            _roomRepository = new RoomRepository(new Models.DataContext());
        }

        public ActionResult Index()
        {
            var model = _roomRepository.GetAllRoom();
            return View(model);

        }
        public ActionResult Create()
        {
            if (TempData["Failed"] != null)
            {
                ViewBag.Failed = "Add Room Failed";
            }
            return View();
        }
        [HttpPost]
        public ActionResult Create(Room model)
        {
            if (ModelState.IsValid)
            {
                int result = _roomRepository.AddRoom(model);

                if (result > 0)
                {
                    return RedirectToAction("Index", "Room");
                }
                else
                {
                    TempData["Failed"] = "Failed";
                    return RedirectToAction("Create", "Room");
                }

            }
            return View();

        }
        public ActionResult Edit(int id)
        {
            if (TempData["Failed"] != null)
            {
                ViewBag.Failed = "Edit book Failed";

            }
            Room model = _roomRepository.GetRoomById(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(Room model)
        {
            if (ModelState.IsValid)
            {
                int result = _roomRepository.updateRoom(model);

                if (result > 0)
                {
                    return RedirectToAction("Index", "Room");
                }
                else
                {
                    return RedirectToAction("Index", "Room");
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            Room room = _roomRepository.GetRoomById(id);
            return View(room);
        }

        [HttpPost]
        public ActionResult Delete(Room model)
        {
            _roomRepository.DeleteRoom(model.room_id);

            return RedirectToAction("Index", "Room");
        }
    }
}
using Hotel_Management_Project.DAL;
using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_Project.Controllers
{
    public class ManagerController : Controller
    {


        private readonly _IManager manageRepsitory;
        public ManagerController()
        {
            manageRepsitory = new ManagerRepo(new Models.DataContext());
        }
        // GET: Manager
        public ActionResult Index()
        {
            var model = manageRepsitory.GetAllManager();



            return View(model);
        }

       

        // GET: Manager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manager/Create
        [HttpPost]
        public ActionResult Create(ManagerAccount collection)
        {
            try
            {
                // TODO: Add insert logic here

                manageRepsitory.AddManager(collection);

                return RedirectToAction("Index", "Manager");


            }
            catch
            {
                return View();
            }
        }

        // GET: Manager/Edit/5
        public ActionResult Edit(int id)
        {
            ManagerAccount model = manageRepsitory.GetManagerById(id);
            return View(model);
        }

        // POST: Manager/Edit/5
        [HttpPost]
        public ActionResult Edit(ManagerAccount collection)
        {
            try
            {
                // TODO: Add update logic here
                manageRepsitory.UpdateManage(collection);

                return RedirectToAction("Index","Manager");
            }
            catch
            {
                return View();
            }
        }

        // GET: Manager/Delete/5
        public ActionResult Delete(int id)
        {
            manageRepsitory.DeleteManager(id);
            return RedirectToAction("Index", "Manager");
        }

        // POST: Manager/Delete/5
        [HttpPost]
        public ActionResult Delete(ManagerAccount collection)
        {
            TempData["Message"] = "<script>alert('Do you want to delete')</script>";
            try
            {
                // TODO: Add delete logic here
                manageRepsitory.DeleteManager(collection.man_id);

               

                return RedirectToAction("Index","Manager");
            }
            catch
            {
                return View();
            }
        }
    }
}

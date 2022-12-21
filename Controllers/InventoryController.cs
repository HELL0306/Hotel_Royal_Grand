using Hotel_Management_Project.DAL;
using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_Project.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory
        // GET: I
        private readonly _Iinventory _inventoryRepsitory;
        public InventoryController()
        {
            _inventoryRepsitory = new InventoryRepository(new Models.DataContext());
        }



        public ActionResult Index()
        {
            var model = _inventoryRepsitory.GetAllInventroy();



            return View(model);
        }



        // GET: Inventory/Details/5



        // GET: Inventory/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: Inventory/Create
        [HttpPost]
        public ActionResult Create(Inventory collection)
        {
            try
            {
                // TODO: Add insert logic here
                
                _inventoryRepsitory.AddInventory(collection);
                    
                  return RedirectToAction("Index", "Inventory");
                    
                   




              
            }
            catch
            {
                return View();
            }
        }



        // GET: Inventory/Edit/5
        public ActionResult Edit(int id)
        {
            Inventory model = _inventoryRepsitory.GetInventoryById(id);
            return View(model);
        }
        // POST: Inventory/Edit/5
        [HttpPost]
        public ActionResult Edit(Inventory collection)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    int result = _inventoryRepsitory.UpdateInventory(collection);
                    if (result > 0)
                    {
                        return RedirectToAction("Index", "Inventory");
                    }
                    else
                    {
                        return RedirectToAction("Edit", "Inventory");
                    }
                }



                return RedirectToAction("Index");

            }





            catch
            {
                return View();
            }
        }



        // GET: Inventory/Delete/5
        public ActionResult Delete(int id)
        {
            _inventoryRepsitory.DeleteInventory(id);
            return RedirectToAction("Index", "Inventory");
        }




        // POST: Inventory/Delete/5
        [HttpPost]
        public ActionResult Delete(Inventory collection)
        {
            try
            {
                // TODO: Add delete logic here
                if (TempData["Failed"] != null)
                {
                    ViewBag.Failed = "Delete Book Failed";
                }
                _inventoryRepsitory.DeleteInventory(collection.inventory_id);
                return RedirectToAction("Index", "Inventory");




            }
            catch
            {
                return View();
            }
        }
    }
}

using Hotel_Management_Project.DAL;
using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_Project.Controllers
{
    public class ReceptionistController : Controller
    {
        // GET: Receptionist

        private ReceptionistRepo receprepository;

        public ReceptionistController()
        {
            receprepository = new ReceptionistRepo(new Models.DataContext());

        }


        public ActionResult Index()
        {
            var model = receprepository.GetAllReceptionist();



            return View(model);
        }

      

        // GET: Receptionist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Receptionist/Create
        [HttpPost]
        public ActionResult Create(ReceptionistAccount collection)
        {
            try
            {
                // TODO: Add insert logic here

                receprepository.AddReceptionist(collection);



                return RedirectToAction("Index", "Receptionist");
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Receptionist/Edit/5
        public ActionResult Edit(int id)
        {
            ReceptionistAccount model = receprepository.GetReceptionistById(id);
            return View(model);
        }

        // POST: Receptionist/Edit/5
       
        [HttpPost]
        public ActionResult Edit(ReceptionistAccount collection)
        {
            try
            {
                // TODO: Add update logic here
                 receprepository.UpdateReceptionist(collection);

                return RedirectToAction("Index","Receptionist");
            }
            catch
            {
                return View();
            }
        }

        // GET: Receptionist/Delete/5
        public ActionResult Delete(int id)
        {
            receprepository.DeleteReceptionist(id);
            return RedirectToAction("Index", "Receptionist");
        }

        // POST: Receptionist/Delete/5
        [HttpPost]
        public ActionResult Delete(ReceptionistAccount collection)
        {
          
            try
            {
                // TODO: Add delete logic here
                receprepository.DeleteReceptionist(collection.rec_id);
                return RedirectToAction("Index", "Receptionist");

                
            }
            catch
            {
                return View();
            }
        }
    }
}

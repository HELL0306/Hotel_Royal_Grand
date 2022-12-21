using Hotel_Management_Project.DAL;
using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_Project.Controllers
{
    public class DepartmentController : Controller
    {
        private DeparmentRepository departmentrepository;

        public DepartmentController()
        {
            departmentrepository = new DeparmentRepository(new Models.DataContext());
               
        }

        // GET: Department
        public ActionResult Index()
        {
            var model = departmentrepository.GetAllDepartment();
            return View(model);
        }

        // GET: Department/Details/5


        // GET: Department/Create
        public ActionResult Create()
        {
           


            return View();
        }

        // POST: Department/Create
        [HttpPost]
        public ActionResult Create(Department collection)
        {
            try
            {
                // TODO: Add insert logic here
                departmentrepository.AddDepartment(collection);

                return RedirectToAction("Index", "Department");
             }

            catch
            {
                return View();
            }
        }

        // GET: Department/Edit/5
        public ActionResult Edit(int id)
        {
           
           Department model = departmentrepository.GetDepartmentById(id);
            return View(model);
        }

        // POST: Department/Edit/5
        [HttpPost]
        public ActionResult Edit(Department collection)
        {
            
            
                departmentrepository.UpdateDepartment(collection);

                return RedirectToAction("Index", "Department");
               
         }
            
        
    

        // GET: Department/Delete/5
        public ActionResult Delete(int id)
        {
            departmentrepository.DeleteDepartment(id);
            return RedirectToAction("Index", "Department");



        }
        // POST: Department/Delete/5
        [HttpPost]
        public ActionResult Delete(Department collection)
        {
            try
            {
                // TODO: Add delete logic here
               
                departmentrepository.DeleteDepartment(collection.Dept_id);
                return RedirectToAction("Index", "Department");




            }
            catch
            {
                return View();
            }
        }
    }
}

using Hotel_Management_Project.DAL;
using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_Project.Controllers
{
    public class BillController : Controller
    {
        DataContext db = new DataContext();
        // GET: Bill
        private readonly _IBillRepository billrepsitory;
        public BillController()
        {
            billrepsitory = new BillRepository(new Models.DataContext());
        }
        // GET: Bill
        public ActionResult Index()
        {
            var model = billrepsitory.GetAllBill();



            return View(model);
        }






        // GET: Bill/Create
        public ActionResult Create()
        {
            var list = new List<string>();
            list.Add("Cash");
            list.Add("Online");
            ViewBag.payment = new SelectList(list, "Transaction_Type");

            var ResservationId = db.Reservations.ToList();
            ViewBag.ReservationId = new SelectList(ResservationId, dataValueField: "reservation_id", dataTextField: "reservation_id");
            return View();
        }



        // POST: Bill/Create
        [HttpPost]
        public ActionResult Create(Bill collection)
        {
            try
            {
                // TODO: Add insert logic here
                


                if (ModelState.IsValid)
                {
                    int result = billrepsitory.AddBill(collection);
                    if (result > 0)
                    {
                        return RedirectToAction("Index", "Bill");
                    }
                    else
                    {
                        TempData["Failed"] = "Failed";
                        return RedirectToAction("Create", "Bill");
                    }
                }




                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        // GET: Bill/Edit/5
        public ActionResult Edit(int id)
        {
            if (TempData["Failed"] != null)
            {
                ViewBag.Failed = "Edit bill Failed";





            }
            Bill model = billrepsitory.GetBillById(id);
            return View(model);



        }
        [HttpPost]
        public ActionResult Edit(Bill collection)
        {
            if (ModelState.IsValid)
            {
                int result = billrepsitory.UpdateBill(collection);





                if (result > 0)
                {
                    return RedirectToAction("Index", "Bill");
                }
                else
                {
                    return RedirectToAction("Index", "Bill");
                }
            }



            return View();

        }



        // GET: Bill/Delete/5
        public ActionResult Delete(int id)
        {
            billrepsitory.DeleteBill(id);
            return RedirectToAction("Index", "Bill");
        }



        // POST: Bill/Delete/5
        [HttpPost]
        public ActionResult Delete(Bill collection)
        {//_roomRepository.DeleteRoom(model.room_id);






            try
            {
                billrepsitory.DeleteBill(collection.billing_no);





                return RedirectToAction("Index", "Bill");



            }
            catch
            {
                return View();
            }
        }
    }
}

using Hotel_Management_Project.DAL;
using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_Project.Controllers
{
            public class ReservationController : Controller
            {
        
        DataContext db = new DataContext();
        // GET: Reservation
        // GET: Reservation
        private ReservationRepository reservationrepository;
                public ReservationController()
                {
                    reservationrepository = new ReservationRepository(new Models.DataContext());


                }
                public ActionResult Index()
                {
                    var model = reservationrepository.GetAllReservation();
                    return View(model);
                }


                // GET: Reservation/Create
                public ActionResult Create()
                {
                    

            
                    
                     
                    var RoomType = db.Rooms.ToList();
            ViewBag.Room_Types = new SelectList(RoomType, dataValueField: "room_id", dataTextField:"RoomTypes") ;



                    var Recep_Name = db.ReceptionistAccounts.ToList();
                    ViewBag.Recep_Name = new SelectList(Recep_Name, dataValueField: "rec_id", dataTextField: "emp_name");



                    var Guestname = db.Guests.ToList();
                    ViewBag.Guest_Name = new SelectList(Guestname, dataValueField: "guest_id", dataTextField: "guest_name");
                    return View();
        }

        // Room room, Guest guest ,ReceptionistAccount recep
                // POST: Reservation/Create
                [HttpPost]
                public ActionResult Create(Reservation collection   )
                {
                    try
                    {
                // TODO: Add insert logic here
                var RoomType = db.Rooms.ToList();
                ViewBag.Room_Types = new SelectList(RoomType, dataValueField: "room_id", dataTextField: "RoomTypes");

                var Guestname = db.Guests.ToList();
                 ViewBag.Guest_Name = new SelectList(Guestname, dataValueField: "guest_id", dataTextField: "guest_name");

                var Recep_Name = db.ReceptionistAccounts.ToList();
              ViewBag.Recep_Name = new SelectList(Recep_Name, dataValueField: "rec_id", dataTextField: "emp_name");


                if (ModelState.IsValid)
                {
                    reservationrepository.AddReservation(collection);

                    TempData["ReservationSuccessfully"] = "<script>('Room is reserved successfully')</script>";
                    return RedirectToAction("Index", "Reservation");

                } 
                else
                {
                    TempData["Reservation"] = "<script>('Room Reserved already')</script>";
                    return View();
                }
                           
                    }
                    catch
                    {
                        return View();
                    }
                }



                // GET: Reservation/Edit/5
                public ActionResult Edit(int id)
                {
                    Reservation model = reservationrepository.GetReservationById(id);
                    return View(model);
                }



                // POST: Reservation/Edit/5
                [HttpPost]
                public ActionResult Edit(Reservation collection)
                {
                    try
                    {
                        // TODO: Add update logic here
                
                
                            reservationrepository.UpdateReservation(collection);
                    
                    
                                return RedirectToAction("Index", "Reservation");
                
                              
                    
                        }


                    catch
                    {
                        return View();
                    }
                }



                // GET: Reservation/Delete/5
                public ActionResult Delete(int id)
                {
            using(DataContext db = new DataContext())
            {
                return View(db.Reservations.Where(x => x.reservation_id == id).FirstOrDefault());
            }
                    //var a = reservationrepository.GetReservationById(id);

            //return RedirectToAction("Index", "Reservation");

            
                }



                // POST: Reservation/Delete/5
               // [HttpPost]
              //  public ActionResult Delete(int id,Reservation r)
              //  {



           // try
           // {
            // TODO: Add delete logic here


            //return RedirectToAction("Index");
          /*  using(DataContext db = new DataContext())
                {
                    Reservation reser= db.Reservations.Where(x=>x.reservation_id == id).FirstOrDefault();
                    db.Reservations.Remove(reser);
                    db.SaveChanges();
                }

                return View("Index");    

             }
            catch
             
            {
                     
                return View();
                    }

                }*/
    
        

      
      
        
            }
        }

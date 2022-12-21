using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DataContext db = new DataContext();
        public ActionResult IndexReceptionist()
        {
            return View();
        }






        [HttpPost]
       
        public ActionResult IndexReceptionist(ReceptionistAccount st)
        {
           
            {

                var recep = db.ReceptionistAccounts.Where(model => model.mail_id == st.mail_id && model.password == st.password).FirstOrDefault();
                if (recep != null)

                {

                    //   We will show this on dashboard if successfully run

                    Session["UserId"] = st.rec_id.ToString();
                    Session["Staff_name"] = st.mail_id.ToString();


                  
                  TempData["LoginSuccessMessage"] = "<script>alert('Login Successfullly')</script>";

                    //TempData["Request"] = "<script>alert('is there any room available in your royal grand hotel')</script>";

                    //TempData["Reply"] = "<script>alert('yes Room is available')</script>";

                    return RedirectToAction("IndexReceptionist", "DashBoard");

                   

                }
            }

            ViewBag.ErrorMessage = "<script>alert('Username and password is invalid')</script>";
            return View();


        }
        public ActionResult IndexManager()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult IndexManager(ManagerAccount ma)
        {
           
          

            var recep = db.ManagerAccounts.Where(model => model.mail_id == ma.mail_id && model.password == ma.password).FirstOrDefault();
            if (recep != null)

            {

                //   We will show this on dashboard if successfully run

                Session["UserId"] = ma.man_id.ToString();
                Session["Staff_name"] = ma.mail_id.ToString();
               






                TempData["LoginSuccessMessage"] = "<script>alert('Login Successfullly')</script>";
                return RedirectToAction("IndexManager", "DashBoard");


            }


            ViewBag.ErrorMessage = "<script>alert('Username and password is invalid')</script>";
            return View();


        }
        public ActionResult IndexOwner()
        {
            return View();
        }

        [HttpPost]
        
        public ActionResult IndexOwner(OwnerAccount owa)
        {
            
            

            var recep = db.OwnerAccounts.Where(model => model.ownerEmail == owa.ownerEmail && model.password ==owa.password).FirstOrDefault();
            if (recep != null)

            {

                //   We will show this on dashboard if successfully run

                Session["UserId"] = owa.own_Id.ToString();
                Session["owner_Email"] = owa.ownerEmail.ToString();
               






                TempData["LoginSuccessMessage"] = "<script>alert('Login Successfullly')</script>";
                return RedirectToAction("IndexOwner", "DashBoard");


            }


            ViewBag.ErrorMessage = "<script>alert('Username and password is invalid')</script>";
            return View();


        }




    }
}







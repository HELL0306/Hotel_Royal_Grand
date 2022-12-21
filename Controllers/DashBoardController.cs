using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Management_Project.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
       
        public ActionResult IndexReceptionist()
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("IndexReceptionist", "Login");

            }
            else
            {
                return View();
            }
        }

        public ActionResult LogoutReceptionist()
        {
            //means current session destroy
            Session.Abandon();

            return RedirectToAction("IndexReceptionist", "Login");

        }

       
        public ActionResult IndexManager()
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("IndexManager", "Login");

            }
            else
            {
                return View();
            }
        }
        public ActionResult LogoutManager()
        {
            //means current session destroy
            Session.Abandon();

            return RedirectToAction("IndexManager", "Login");

        }

        public ActionResult IndexOwner()
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("IndexOwner", "Login");

            }
            else
            {
                return View();
            }
        }
        public ActionResult LogoutOwner()
        {
            //means current session destroy
            Session.Abandon();

            return RedirectToAction("IndexOwner", "Login");

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]

        public ActionResult AddOrEdit()
        {
            Users userModel = new Users();
            return View(userModel);
        }
      [HttpPost]
      public ActionResult AddOrEdit(Users userModel)
        {
            using ( BazaKsiazkiEntities dbModel = new BazaKsiazkiEntities ())
            {
                if(dbModel.Users.Any( x=>x.UserName == userModel.UserName))
                {
                    ViewBag.DuplicateMessage = "UserName already exist";
                    return View("AddOrEdit", userModel);

                }

                dbModel.Users.Add(userModel);
                dbModel.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessege = "Registration Successful";
            return View("AddOrEdit", new Users());
                    }
    }
}
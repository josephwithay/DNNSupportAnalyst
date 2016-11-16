using DNN_SupportAnalyst_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DNN_SupportAnalyst_Homework.Controllers
{
    public class HomeController : Controller
    {
        private DNNHomeworkEntities UserDB = new DNNHomeworkEntities();

        public ActionResult Index()
        {
            return View();
        }

        // GET: Userlist
        public ActionResult UserList()
        {
            var users = this.UserDB.Users;
            ViewBag.Message = "List of user currently registered";
            return this.View(users);
        }

       /* public ActionResult DisplayList(string fName, string lName, string email, string username)
        {
            //retrieve user information from database
            var userModel = new User
            {
                firstName = fName,
                lastName = lName,
                userName = username,
                email = email,
            };
            return this.View(userModel);
        }*/

        /*public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}
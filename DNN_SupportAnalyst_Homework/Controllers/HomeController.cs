using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BridgeLayer;

namespace DNN_SupportAnalyst_Homework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Userlist
        public ActionResult UserList()
        {
            UsersBridgeLayer usersBridgeLayer = new UsersBridgeLayer();
            List<User> users = usersBridgeLayer.Users.ToList();
            ViewBag.Message = "List of users currently registered";

            return View(users);
        }

        // GET: CreateUser
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        // POST: Users/CreateUser
        [HttpPost]
        public ActionResult Register(string firstName, string lastName, string userName, string email)
        {
            User user = new User();
            user.firstName = firstName;
            user.lastName = lastName;
            user.userName = userName;
            user.email = email;

            UsersBridgeLayer userBridgeLayout = new UsersBridgeLayer();
            userBridgeLayout.AddUser(user);

            return View();
            /*
             * Just for debugging purposes
            if (ModelState.IsValid)
            {
                foreach (string key in formCollection.AllKeys)
                {
                    Response.Write("Key = " + key + "  ");
                    Response.Write("Value = " + formCollection[key]);
                    Response.Write("<br/>");
                }
            } */           
        }
    }
}
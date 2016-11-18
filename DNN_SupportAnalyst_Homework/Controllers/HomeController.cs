﻿using DNN_SupportAnalyst_Homework.Models;
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
            ViewBag.Message = "List of users currently registered";
            return this.View(users);
        }

        // GET: CreateUser
        public ActionResult Register()
        {
            return View();
        }
    }
}
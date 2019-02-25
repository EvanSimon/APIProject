using Newtonsoft.Json.Linq;
using RecipesProjects.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace RecipesProjects.Controllers
{
    public class HomeController : Controller
    {
        UserInput userChoice = new UserInput();
        private DBMovieContext db = new DBMovieContext();
        public ActionResult Index()
        {
            
            return View(userChoice);
        }
        [HttpPost]
        public ActionResult Index(UserInput userChoice)
        {
            Session["UserInput"] = userChoice;

            return RedirectToAction("About");
        }

        public ActionResult About()
        {
            userChoice =(UserInput) Session["UserInput"];

            if(userChoice == null)
            {
                Movie obj = new Movie();
                string Movename = userChoice.MovieName.Trim();
                obj = MovieDAL.GetPost("http://www.omdbapi.com/?s" + "t="+ Movename + "&apikey=70a772b9&");
                db.Movies.Add(obj);
                db.SaveChanges();
                return View(obj);
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
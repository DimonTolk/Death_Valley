using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeathValley.Models;

namespace DeathValley.Controllers
{
    public class HomeController : Controller
    {

        DataBaseContext db = new DataBaseContext();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.min = -5;
            ViewBag.max = 5;
            string points = "[1,1],[0,0],[-1,1]";
            ViewBag.points = points;
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserData data)
        {
            if (ModelState.IsValid)
            {
                db.UserDatas.Add(data);
                db.SaveChanges();
                string points = "";
                float x = data.RangeFrom;
                while(x<=data.RangeTo)
                {
                    var p = new Point();
                    p.ChartID = data.UserDataId;
                    p.PointX = (int)x;
                    float funcValue = data.a*x*x+data.b*x+data.c;
                    p.PointY = (int)funcValue;
                    points += p.ToString();
                    db.Points.Add(p);
                    db.SaveChanges();
                    x += data.step;
                }
                ViewBag.points = points;
                ViewBag.min = data.RangeFrom;
                ViewBag.max = data.RangeTo;

                return View();
            }
            ViewBag.points = "[1,1],[0,0],[-1,1]";
            ViewBag.min = -10;
            ViewBag.max = 10;
            return View(data);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session["a"] = "3";
            ViewBag.ActiveButton = "True";
            ViewBag.NameSortParm = "name_desc";
            ViewBag.ENUL = "DarkRed";



            Movie movie = new Movie();
            movie.ID = 1;
            movie.Title = "12";
            student st1 = new student();
            st1.ID = 1;
            st1.name = "name1";
            List<student> list = new List<student>();
            list.Add(st1);
            movie.studentList = list;
            ViewBag.studentList = list;
            return View(movie);
          



        }

        public static Boolean IsUnique()
        {
            return true;
        }

        public ActionResult Table(string sortOrder)
        {
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
           
            return View();


        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult CalculateSimpleInterestResult()
        {
            decimal principle = Convert.ToDecimal(Request["txtAmount"].ToString());
            decimal rate = Convert.ToDecimal(Request["txtRate"].ToString());
            int time = Convert.ToInt32(Request["txtYear"].ToString());

            decimal simpleInteresrt = (principle * time * rate) / 100;

            StringBuilder sbInterest = new StringBuilder();
            sbInterest.Append("<b>Amount :</b> " + principle + "<br/>");
            sbInterest.Append("<b>Rate :</b> " + rate + "<br/>");
            sbInterest.Append("<b>Time(year) :</b> " + time + "<br/>");
            sbInterest.Append("<b>Interest :</b> " + simpleInteresrt);
            return Content(sbInterest.ToString());
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public enum Color
        {
            [Display(Name = "Dark red")]
            DarkRed,
            [Display(Name = "Very dark red")]
            VeryDarkRed,
            [Display(Name = "Red or just black?")]
            ReallyDarkRed
        }
    }
}
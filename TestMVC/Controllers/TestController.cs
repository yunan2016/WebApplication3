using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Index()
        {
            foreach (string upload in Request.Files)
            {

                string path = AppDomain.CurrentDomain.BaseDirectory + "uploads/";
                string filename = Path.GetFileName(Request.Files[upload].FileName);
                Request.Files[upload].SaveAs(Path.Combine(path, filename));
            }
            return View();
        }
     
    }
   
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HappyMVC.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/TextFiles"));
            return View(files);
        }

        public ActionResult Content(string file)
        {
            string txt = System.IO.File.ReadAllText(file);
            return View("Content", (object)txt);
        }
    }
}
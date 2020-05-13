using AIAMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AIAMVC.Controllers
{
    public class SongsController : Controller
    {
        // GET: Songs
        public ActionResult Index()
        {
            var model = new Song
            {
                Id = 0,
                Name = "Fear of The Dark",
                Artist = "Iron Maiden",
                Genre = "Heavy Metal"
            };
            //return Content("Hello World");
            return View(model);
        }

        public ActionResult Square(int id)
        {
            return Content((id * id).ToString());
        }
    }
}
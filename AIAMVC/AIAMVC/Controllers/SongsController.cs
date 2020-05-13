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
            return Content("Hello World");
        }

        public ActionResult Square(int id)
        {
            return Content((id*id).ToString());
        }
    }
}
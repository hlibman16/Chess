using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GamesOnline.Controllers
{
    public class PongController : Controller
    {
        // GET: Pong
        public ActionResult Index()
        {
            return View();
        }
    }
}
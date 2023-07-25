using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddBook()
        {
            // 책 추가 뷰로 리다이렉트
            return RedirectToAction("AddBook", "Board");
        }
    }
}

// BoardController.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult List(int? Id)
        {
            if (Id == null)
                return HttpNotFound("에러메시지");

            DocumentsData documentsData = new DocumentsData();
            return View(documentsData);
        }
    }
}
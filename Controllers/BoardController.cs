using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public string List(int? Id)
        {
            if (Id == null)
                return "Error Message Board";
            return "보드리스트: " + Id.Value;
        }
    }
}
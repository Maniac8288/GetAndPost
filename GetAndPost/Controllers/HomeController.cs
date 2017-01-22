using GetAndPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetAndPost.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Author author)
        {

            return View(author);
        }
        [HttpPost]
        public string Array(List<string> names)
        {
            string fin = "";
            for (int i = 0; i < names.Count; i++)
            {
                fin += names[i] + ";  ";
            }
            return fin;
        }
    
    }
}

       
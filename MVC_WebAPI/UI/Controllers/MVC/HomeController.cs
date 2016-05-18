using DataLayer.DBLayer;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models;

namespace WebApi_exam.Controllers.MVC
{
    public class HomeController : Controller
    {

        RentDBModel context = new RentDBModel();
        

        public ActionResult Index()
        {
            ArgListForFind model = new ArgListForFind();
            return View(model);
            
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public string Search(ObjForSearch obj)
        {
            Searcher sercher = new Searcher(context, obj.Id, obj.Str);
            var res = sercher.Search();
            string str = String.Empty;

            foreach (var item in res)
            {
                str = str += item.ContactaName;    
            }
            return str;
            // return string.Format("id - {0} str - {1}", obj.Id, obj.Str);            
        }


    }
}
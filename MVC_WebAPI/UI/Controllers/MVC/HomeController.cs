using DataLayer.DBLayer;
using DataLayer.ForSearch;
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
                str = str += ("<br />" + item.ContactaName + " тел.: " + item.Telephon);
            }
            return str;            
        }

        // [HttpPost]
        //public PartialViewResult Search(ObjForSearch obj)
        //{
        //    Searcher sercher = new Searcher(context, obj.Id, obj.Str);
        //    IEnumerable<Rent> list = sercher.Search();
        //    List<string> nameList = new List<string>();
        //    foreach (var item in list)
        //    {
        //        nameList.Add(item.RentName);
        //    }

        //    NameList model = new NameList();
        //    model.Names = nameList;

        //    return PartialView(model);

        //    //RentsList model = new RentsList(list.ToList<Rent>());
        //    //return PartialView(model);            
        //}
    }
}
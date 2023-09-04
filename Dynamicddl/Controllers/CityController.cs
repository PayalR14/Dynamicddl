using Dynamicddl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dynamicddl.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCityNameddl( int State_Id)
        {
            try
            {
                return Json(new { model = new CityModel().GetCityNameddl(State_Id) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { model = ex.Message }, JsonRequestBehavior.AllowGet)
;
            }
        }
    }
}
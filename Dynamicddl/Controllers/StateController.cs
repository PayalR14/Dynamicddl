using Dynamicddl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Dynamicddl.Controllers
{
    public class StateController : Controller
    {
        // GET: State
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetStateNameListddl()
        {
            try
            {
                return Json(new { model = new StateModel().GetStateName() }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { model = ex.Message }, JsonRequestBehavior.AllowGet)
;            }
        }
        
    }
}
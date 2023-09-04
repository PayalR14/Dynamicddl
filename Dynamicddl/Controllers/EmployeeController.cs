using Dynamicddl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dynamicddl.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SaveEmployee(EmployeeModel model)
        {
            try
            {
                return Json(new { message = new EmployeeModel().saveEmployee(model) }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                return Json(new {message= ex.Message},JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetEmployeeList(EmployeeModel model)
        {
            try
            {
                return Json(new { model = new EmployeeModel().GetEmpList(model) }, JsonRequestBehavior.AllowGet);
            }
            catch(Exception Ex)
            {
                return Json(new {Ex.Message},JsonRequestBehavior.AllowGet); 
            }
        }
    }
}
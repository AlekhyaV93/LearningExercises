using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCDemo.Models;
using System.Management.Automation;

namespace FirstMVCDemo.Controllers
{
    public class DepartmentController : Controller
    {
        //
        // GET: /Department/
        public ActionResult Details()
        {
            DepartmentContext dctxt = new DepartmentContext();
            List<Department> departments = dctxt.Departments.ToList();
            return View(departments);
        }


        //example for using angularjs
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAllDepartments()
        {
           // var shell= PowerShell.Create();
            DepartmentContext dct = new DepartmentContext();
            List<Department> dpts = dct.Departments.ToList();
            return Json(dpts, JsonRequestBehavior.AllowGet);

        }

        public JsonResult GetEmployeeByDptID(int id)
        {

            EmployeeContext ectxt = new EmployeeContext();
            //How to convert list of employees where departmentID is x to Employee list
            var em = from e in ectxt.Employees where e.departmentID == id select e;
            return Json(em, JsonRequestBehavior.AllowGet);
        }
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace FirstMVCDemo.Controllers
{
    public class NewEmployeeController : Controller
    { //
        // GET: /NewEmployee/
        public ActionResult Index()
        {

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<NewEmployees> employees = employeeBusinessLayer.Employees.ToList();

            return View(employees);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {

            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            /*
             FormCollection formCollection
             if (ModelState.IsValid)
            {
                foreach (string key in formCollection.AllKeys)
                {
                    Response.Write("Key " + key + " ");
                    Response.Write("Value = " + formCollection[key]);
                    Response.Write("<br/>");
            
                }
            }*/

            if (ModelState.IsValid)
            {

                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                NewEmployees employees = new NewEmployees();
                UpdateModel<NewEmployees>(employees);
                //Instead of giving value to each property of employee "UpdateModel" is used
                /*employee.Name=formCollection["Name"];
                employee.Gender=formCollection["Gender"];
                employee.DateOfBirth= Convert.ToDateTime(formCollection["DateOfBirth"]);
                employee.City=formCollection["City"];
                */
                employeeBusinessLayer.AddEmmployee(employees);

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_get(int id)
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            NewEmployees employee = employeeBusinessLayer.Employees.Single(emp => emp.ID == id);
            return View(employee);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            //to preventing unwanted updates we do modelbinding using include properties or exclude properties
            EmployeeBusinessLayer employeeBusinessLayer =
                    new EmployeeBusinessLayer();
            NewEmployees employee = employeeBusinessLayer.Employees.Single(emp => emp.ID == id);
            UpdateModel(employee, new string[] { "ID", "Gender", "City", "DateOfBirth" });
            
            if (ModelState.IsValid)
            {

                employeeBusinessLayer.SaveEmmployee(employee);

                return RedirectToAction("Index");
            }
            return View(employee);
        }

    }
}
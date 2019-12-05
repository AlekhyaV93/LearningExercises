using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVCDemo.Models;

namespace FirstMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        
        // GET: /Employee/
        public ActionResult View1(int id)
        {
           /* Employee emp = new Employee()
            {
                employeeID = 316660,
                employeeName = "Alekhya",
                gender = "Female",
                city = "Visakhapatnam"

            };*/

            EmployeeContext empCtxt = new EmployeeContext();
            Employee emp = empCtxt.Employees.Single(e => e.employeeID == id);
            return View(emp);
        }

        

        public ActionResult View2(int id)
        {
           
            EmployeeContext empCtxt = new EmployeeContext();
            List<Employee> employees = empCtxt.Employees.ToList().FindAll(e => e.departmentID == id);
            return View(employees);
        }
        
	}
}
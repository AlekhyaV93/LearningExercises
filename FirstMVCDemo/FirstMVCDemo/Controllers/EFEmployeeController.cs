using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstMVCDemo.Models;
using System.Data.Entity.Validation;

namespace FirstMVCDemo.Controllers
{
    public class EFEmployeeController : Controller
    {
        private EmployeeDataModelContext db = new EmployeeDataModelContext();

        // GET: /EFEmployee/
        public ActionResult Index()
        {
            var tblemployees = db.tblEmployees.Include(t => t.tblDepartment);
            return View(tblemployees.ToList());
        }

       

        // GET: /EFEmployee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmployee tblemployee = db.tblEmployees.Find(id);
            if (tblemployee == null)
            {
                return HttpNotFound();
            }
            return View(tblemployee);
        }

       
        // GET: /EFEmployee/Create
        public ActionResult Create()
        {
            ViewBag.departmentID = new SelectList(db.tblDepartments, "departmentId", "departmentName");
            return View();
        }

        // POST: /EFEmployee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="employeeName,employeeID,gender,city,departmentID")] tblEmployee tblemployee)
        {
            if (ModelState.IsValid)
            {
                db.tblEmployees.Add(tblemployee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.departmentID = new SelectList(db.tblDepartments, "departmentId", "departmentName", tblemployee.departmentID);
            return View(tblemployee);
        }

        

        // GET: /EFEmployee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmployee tblemployee = db.tblEmployees.Find(id);
            if (tblemployee == null)
            {
                return HttpNotFound();
            }
            ViewBag.departmentID = new SelectList(db.tblDepartments, "departmentId", "departmentName", tblemployee.departmentID);
            return View(tblemployee);
        }

        // POST: /EFEmployee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="employeeName,employeeID,gender,city,departmentID")] tblEmployee tblemployee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblemployee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.departmentID = new SelectList(db.tblDepartments, "departmentId", "departmentName", tblemployee.departmentID);
            return View(tblemployee);
        }

        

        // GET: /EFEmployee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblEmployee tblemployee = db.tblEmployees.Find(id);
            if (tblemployee == null)
            {
                return HttpNotFound();
            }
            return View(tblemployee);
        }

        // POST: /EFEmployee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblEmployee tblemployee = db.tblEmployees.Find(id);
            db.tblEmployees.Remove(tblemployee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //for angular js json methods

        public ActionResult EmpData()
        {
            return View();
        }

        public JsonResult GetAllData()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var employees = db.tblEmployees.ToList();
            return Json(
               employees
                , JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDataByEmployeeId(int id)
        {
            db.Configuration.ProxyCreationEnabled = false;

            tblEmployee employee = db.tblEmployees.Find(id);
            return Json(employee, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]
        public JsonResult SaveEmpDetails(tblEmployee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.tblEmployees.Add(employee);
                    int a = db.SaveChanges();

                    return Json(new
                    {
                        success = true
                    });
                }

                else
                {
                    return Json(new
                    {
                        error = "Invalid ModelState"
                    });
                }

                
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    error=ex.Message

                });
            }
            //DbEntityValidationException(i.e exceptions related to that input is not in the desired pattern)
                //DbUpdateexception(i.e exceptions related to primary key violation)
                
           /* catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }*/

        }

        [HttpPost]
        public JsonResult updateEmpDetails(tblEmployee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(employee).State = EntityState.Modified;
                    db.SaveChanges();

                    return Json(new
                    {
                        success = true
                    });

                }
                else
                {
                    return Json(new
                    {
                        error = "ModelState not valid"
                    });
 
                }

                
            }

            catch (Exception ex)
            {
                return Json(new
                {
                    error = ex.Message

                });
            }

        }

        [HttpPost]
        public JsonResult DelEmpDetails(int id)
        {
            try
            {
                tblEmployee employee = db.tblEmployees.Find(id);
                db.tblEmployees.Remove(employee);
                db.SaveChanges();

                return Json(new
                {
                    success = true
                });
            }

            catch (Exception ex)
            {
                return Json(new
                {
                    error = ex.Message

                });
            }



        }

         

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

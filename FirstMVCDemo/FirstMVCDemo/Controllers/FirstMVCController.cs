using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCDemo.Controllers
{
    public class FirstMVCController : Controller
    {
        //
        // GET: /FirstMVC/
       /* public ActionResult Index()
        {
            return View();
        }*/
        
        //viewbag exapmle

       /* public ActionResult Index()
      {
          ViewBag.Countries = new List<string>(){
                "India",
                "US",
                "Australia"
            };
          return View();

      }*/

        // viewdata example
        public ActionResult Index()
        {
            ViewData["Countries"]= new List<string>(){
                "India",
                "US",
                "Australia"
            };
            return View();

        }

	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(int departmentid)
        {
            EmployeeContext ec = new EmployeeContext();
            // List<Employee> emplist=   ec.employees.ToList();
            List<Employee> emplist = ec.employees.Where(x => x.departmentID == departmentid).ToList();


            return View(emplist);
        }


        public ActionResult EmployeeDetails(int id)
        {
            EmployeeContext ec = new EmployeeContext();
            Employee emp = ec.employees.Single(x => x.ID == id);
           

            return View(emp);
        }
    }
}
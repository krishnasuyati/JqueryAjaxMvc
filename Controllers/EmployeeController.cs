using JqueryAjaxMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JqueryAjaxMvc.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetAllEmployee());
        }
        IEnumerable<Employee> GetAllEmployee()
        {
            using(DBmodel db = new DBmodel() )
            {
                return db.Employees.ToList<Employee>();
            }
        }
        public ActionResult AddOrEdit(int id=0)
        {
            Employee emp = new Employee();
            return View(emp);
        }
        [HttpPost]
        public ActionResult AddOrEdit()
        {
            return View();
        }
    }
}
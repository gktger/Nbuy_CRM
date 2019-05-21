using CRM.BLL;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.UI.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeBLL employeeBLL = new EmployeeBLL();
        // GET: Employee
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Employee employee)
        {
            Employee emp = employeeBLL.GetEmployee(employee);

            if (emp == null)
            {
                return RedirectToAction("LoginHata");
            }
            Session["Login"] = emp;
            return RedirectToAction("Index","Customer");
        }

        public ActionResult LoginHata()
        {
            return View();
        }
    }
}
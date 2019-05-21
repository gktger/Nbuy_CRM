using CRM.BLL;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRM.UI.Controllers
{
    public class CustomerController : Controller
    {
        CustomerBLL customerBLL = new CustomerBLL();
        EmployeeBLL employeeBLL = new EmployeeBLL();

        public ActionResult Index()
        {
            List<Customer> customers = customerBLL.GetCustomers();
            Employee employee = Session["Login"] as Employee;
            if (employeeBLL.CheckRole(employee, "Admin"))
            {
                ViewBag.Edit = "Visible";
                ViewBag.Delete = "Visible";
                ViewBag.Detail = "Visible";
            }
            else if (employeeBLL.CheckRole(employee, "Manager"))
            {
                ViewBag.Edit = "Visible";
                ViewBag.Delete = "Hidden";
                ViewBag.Detail = "Visible";
            }
            else
            {
                ViewBag.Edit = "Hidden";
                ViewBag.Delete = "Hidden";
                ViewBag.Detail = "Visible";
            }

            return View(customers);
        }

        public ActionResult Edit(int id)
        {
            Customer customer = customerBLL.GetCustomer(id);

            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            Customer cust = customerBLL.GetCustomer(customer.CustomerID);
            cust.CustomerID = customer.CustomerID;
            cust.BirthDate = customer.BirthDate;
            cust.City = customer.City;
            cust.Address1 = customer.Address1;
            cust.Email1 = customer.Email1;
            cust.Phone1 = customer.Phone1;
            cust.Company = customer.Company;
            cust.SurName = customer.SurName;
            cust.Name = customer.Name;

            customerBLL.Update(cust);

            return View();
        }
    }
}
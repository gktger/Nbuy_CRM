using CRM.DAL;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
    public class EmployeeBLL
    {
        DataContext db = new DataContext();

        public Employee GetEmployee(Employee employee)
        {
            return db.Employee.FirstOrDefault(x=>x.Email == employee.Email && x.Password == employee.Password);
        }

        public bool CheckRole(Employee employee,string role)
        {
            var query = (from e in db.Employee
                        join er in db.EmployeeRole on e.EmployeeID equals er.EmployeeID
                        join r in db.Role on er.RoleID equals r.RoleID where e.EmployeeID == employee.EmployeeID && r.Name == role select r).Any();

            return query;
        }
    }
}

using CRM.DAL;
using CRM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.BLL
{
    public class CustomerBLL
    {
        DataContext db = new DataContext();

        public List<Customer> GetCustomers()
        {
            return db.Customer.ToList();
        }

        public Customer GetCustomer(int id)
        {
            return db.Customer.FirstOrDefault(x=>x.CustomerID == id);
        }
        
        public void Update(Customer customer)
        {
            db.SaveChanges();
        }
    }
}

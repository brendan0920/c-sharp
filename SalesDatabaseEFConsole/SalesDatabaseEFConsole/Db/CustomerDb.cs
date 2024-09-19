using SalesDatabaseEFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDatabaseEFConsole.Db
{
    public class CustomerDb : DAO<Customer>
    {
        private salesdbContext DbContext = new salesdbContext();

        // CRUD Methods
        public List<Customer> GetCustomer()
        {
            return DbContext.Customers.ToList();
        }

        public Customer FindCustomer(int id)
        {
            return DbContext.Customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public void AddCustomer(Customer customer)
        {
            DbContext.Customers.Add(customer);
            DbContext.SaveChanges();
        }

        public void RemoveCustomer(Customer customer)
        {
            DbContext.Customers.Remove(customer);
            DbContext.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            DbContext.SaveChanges();
        }

    }
}

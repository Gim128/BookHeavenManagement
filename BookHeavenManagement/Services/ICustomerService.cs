using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHeavenManagement.Models;

namespace BookHeavenManagement.Services
{
    public interface ICustomerService
    {
        DataTable GetAllCustomers();
        Customer GetCustomerById(int customerId);
        int AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(int customerId);
    }
}

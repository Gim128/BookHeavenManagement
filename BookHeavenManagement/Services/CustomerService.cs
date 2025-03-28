using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;
using BookHeavenManagement.Models;
using System.Threading.Tasks;
using BookHeavenManagement.Utilities;

namespace BookHeavenManagement.Services
{
    public class CustomerService : ICustomerService
    {
        public int AddCustomer(Customer customer)
        {
            string query = @"INSERT INTO Customers (FirstName, LastName, Email, Phone, Address)
                           VALUES (@FirstName, @LastName, @Email, @Phone, @Address);
                           SELECT SCOPE_IDENTITY();";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@FirstName", customer.FirstName),
                new SqlParameter("@LastName", customer.LastName),
                new SqlParameter("@Email", customer.Email ?? (object)DBNull.Value),
                new SqlParameter("@Phone", customer.Phone ?? (object)DBNull.Value),
                new SqlParameter("@Address", customer.Address ?? (object)DBNull.Value)
            };

            return Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));
        }

        public bool DeleteCustomer(int customerId)
        {
            string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", customerId)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public DataTable GetAllCustomers()
        {
            string query = "SELECT * FROM Customers";
            return DatabaseHelper.ExecuteQuery(query);
        }

        public Customer GetCustomerById(int customerId)
        {
            string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", customerId)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return new Customer
                {
                    CustomerID = (int)result.Rows[0]["CustomerID"],
                    FirstName = result.Rows[0]["FirstName"].ToString(),
                    LastName = result.Rows[0]["LastName"].ToString(),
                    Email = result.Rows[0]["Email"].ToString(),
                    Phone = result.Rows[0]["Phone"].ToString(),
                    Address = result.Rows[0]["Address"].ToString(),
                    JoinDate = (DateTime)result.Rows[0]["JoinDate"]
                };
            }
            return null;
        }

        public bool UpdateCustomer(Customer customer)
        {
            string query = @"UPDATE Customers SET FirstName = @FirstName, LastName = @LastName,
                           Email = @Email, Phone = @Phone, Address = @Address
                           WHERE CustomerID = @CustomerID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CustomerID", customer.CustomerID),
                new SqlParameter("@FirstName", customer.FirstName),
                new SqlParameter("@LastName", customer.LastName),
                new SqlParameter("@Email", customer.Email ?? (object)DBNull.Value),
                new SqlParameter("@Phone", customer.Phone ?? (object)DBNull.Value),
                new SqlParameter("@Address", customer.Address ?? (object)DBNull.Value)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}

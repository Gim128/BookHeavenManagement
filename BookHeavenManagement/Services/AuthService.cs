using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookHeavenManagement.Models;
using BookHeavenManagement.Utilities;
using Microsoft.Data.SqlClient;
using System.Data;

using System.Threading.Tasks;

namespace BookHeavenManagement.Services
{
    public class AuthService : IAuthService
    {
        public User Authenticate(string username, string password)
        {
            string query = "SELECT UserID, Username, FullName, Role FROM Users WHERE Username = @Username AND Password = @Password AND IsActive = 1";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", SecurityHelper.HashPassword(password))
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return new User
                {
                    UserID = (int)result.Rows[0]["UserID"],
                    Username = result.Rows[0]["Username"].ToString(),
                    //FullName = result.Rows[0]["FullName"].ToString(),
                    Role = result.Rows[0]["Role"].ToString()
                };
            }
            return null;
        }

        public bool ChangePassword(int userId, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}

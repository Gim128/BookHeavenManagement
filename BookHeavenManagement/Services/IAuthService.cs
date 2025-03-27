using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHeavenManagement.Models;

namespace BookHeavenManagement.Services
{
    public interface IAuthService
    {
        User Authenticate(string username, string password);
        bool ChangePassword(int userId, string newPassword);
    }
}

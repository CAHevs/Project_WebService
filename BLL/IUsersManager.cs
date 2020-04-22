using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public interface IUsersManager
    {
        List<User> GetUsers();
        User GetUserByUsername(string username);
        User GetUserById(int id);
        float GetAmountForAStudent(int id);
        int UpdateAmountViaId(int id, double amount);
        int UpdateAmountViaUsername(string username, double amount);
        int UpdateAmount(User user);
    }
}

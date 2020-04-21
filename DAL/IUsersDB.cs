using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public interface IUsersDB
    {
        //IConfiguration Configuration { get; }
        List<User> GetUsers();
        float GetAmountForAStudent(int id);
        int UpdateAmountViaId(int id, double amount);
        int UpdateAmountViaUsername(string username, double amount);
        int UpdateAmount(User user);
    }
}

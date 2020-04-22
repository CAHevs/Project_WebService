using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using Microsoft.Extensions.Configuration;

namespace BLL
{
    public class UsersManager : IUsersManager
    {
        public IUsersDB UsersDB { get; }

        public UsersManager(IUsersDB usersDB)
        {
            UsersDB = usersDB;
        }

        public List<User> GetUsers()
        {
            return UsersDB.GetUsers();
        }

        public User GetUserByUsername(string username)
        {
            return UsersDB.GetUserByUsername(username);
        }

        public User GetUserById(int id)
        {
            return UsersDB.GetUserById(id);
        }

        public float GetAmountForAStudent(int id)
        {
            return UsersDB.GetAmountForAStudent(id);
        }

        public int UpdateAmountViaId(int id, double amount)
        {
            return UsersDB.UpdateAmountViaId(id, amount);
        }

        public int UpdateAmountViaUsername(string username, double amount)
        {
            return UsersDB.UpdateAmountViaUsername(username, amount);
        }

        public int UpdateAmount(User user)
        {
            return UsersDB.UpdateAmount(user);
        }
    }
}

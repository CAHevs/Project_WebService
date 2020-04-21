using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BLL;
using DAL;
using DTO;
using Microsoft.Extensions.Configuration;

//using Microsoft.Extensions.Configuration;

namespace WcfServiceAddAmountViaId
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UpdateAmountService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UpdateAmountService.svc or UpdateAmountService.svc.cs at the Solution Explorer and start debugging.
    public class UpdateAmountService : IUpdateAmountService
    {

        public void UpdateAmountViaUsername(string username, double amount)
        {
            IUsersDB usersDB = new UsersDB();
            IUsersManager usersManager = new UsersManager(usersDB);
            usersManager.UpdateAmountViaUsername(username, amount);
        }

        public void UpdateAmountViaId(int id, double amount)
        {
            IUsersDB usersDB = new UsersDB();
            IUsersManager usersManager = new UsersManager(usersDB);
            usersManager.UpdateAmountViaId(id, amount);
        }

        public List<User> GetAllUsers()
        {
            IUsersDB usersDB = new UsersDB();
            IUsersManager usersManager = new UsersManager(usersDB);
            List<User> listUsers = usersManager.GetUsers();
            return listUsers;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BLL;
using DTO;

namespace WcfServiceAddAmountViaId
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUpdateAmountService" in both code and config file together.
    [ServiceContract]
    public interface IUpdateAmountService
    {
        [OperationContract]
        void UpdateAmountViaUsername(string username, double amount);

        [OperationContract]
        void UpdateAmountViaId(int id, double amount);

        [OperationContract]
        List<User> GetAllUsers();

        [OperationContract]
        User ConnectWithUsername(string username);

        [OperationContract]
        User ConnectWithId(int id);
    }
}

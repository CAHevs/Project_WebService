using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public int IdUser { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return $"{IdUser}|{Firstname}|{Lastname}|{Username}|{Amount}";
        }
    }
}

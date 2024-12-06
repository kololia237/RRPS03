using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Proxy
{
    public class Client
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Client(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}

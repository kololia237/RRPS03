using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.StructuralPatterns.Proxy
{
    class SharedPathToDB : IToDB
    {
        private IToDB db;
        private Client client;
        public SharedPathToDB(Client emp)
        {
            client = emp;
        }
        public string PerformRWOperations()
        {
            if (client.Role.ToUpper() == "Постійний клієнт" || client.Role.ToUpper() == "Звичайний клієнт")
            {
                db = new ToDB();
                db.PerformRWOperations();
                return "Дозволено";
            }
            else
            {
                return "Заборонено";
            }
        }
    }
}

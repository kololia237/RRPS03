using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.AbstractFactory
{
    public class Client
    {
        INoCofein noCoffein;
        IWithCofein withCofein;

        public Client(ICoffee factory)
        {
            noCoffein = factory.GetNoCofein();
            withCofein = factory.GetWithCofein();
        }

        public string NoCofeinDetails()
        {
            return noCoffein.GetModelDetails();
        }

        public string WithCofeinDetails()
        {
            return withCofein.GetModelDetails();
        }
    }
}

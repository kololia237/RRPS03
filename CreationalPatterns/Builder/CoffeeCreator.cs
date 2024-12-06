using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCafe.CreationalPatterns.Builder
{
    public class CoffeeCreator
    {
        private CoffeeBuilder _builder;
        public CoffeeCreator(CoffeeBuilder builder)
        {
            _builder = builder;
        }
        public string CreateCoffee(int sugar, string syrup, bool ice)
        {
            //_builder.SetSugar(sugar);
            //_builder.SetSyrup(syrup);
            //_builder.SetIceCoffee(ice);

            return $"Цукру: {_builder.SetSugar(sugar)} - Сироп:{_builder.SetSyrup(syrup)} - {_builder.SetIceCoffee(ice)}";
        }
    }
}

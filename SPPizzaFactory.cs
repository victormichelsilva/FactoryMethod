using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class SPPizzaFactory : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M")) 
            {
                return new SPPizzaMussarela();
            }
            else if (tipo.Equals("C"))
            {
                return new SPPizzaCalabreza();
            }
            else 
            {
                return null;
            }
        }
    }
}

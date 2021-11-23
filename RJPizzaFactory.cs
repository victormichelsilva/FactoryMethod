using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class RJPizzaFactory : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new RJPizzaMussarela();
            }
            else if (tipo.Equals("C"))
            {
                return new RJPizzaCalabreza();
            }
            else
            {
                return null;
            }
        }
    }
}

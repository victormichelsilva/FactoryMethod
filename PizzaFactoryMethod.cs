﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontaPizza(string tipo) 
        {
            Pizza pizza;
            pizza = CriarPizza(tipo);

            return pizza;
        }

        protected abstract Pizza CriarPizza(string tipo);
    }
}

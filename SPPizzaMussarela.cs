using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class SPPizzaMussarela : Pizza
    {
        public SPPizzaMussarela() 
        {
            Nome = "Pizza de mussarela Paulista";
            massa = "Massa fina crocante paulista";
            molho = "Molho de tomate italiano paulista";
            ingredientes.Add("Queijo parmesão");
            ingredientes.Add("Azeitonas verdes");
        }
    }
}

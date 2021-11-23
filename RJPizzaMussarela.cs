using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class RJPizzaMussarela : Pizza
    {
        public RJPizzaMussarela()
        {
            Nome = "Pizza de mussarela Carioca";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Queijo parmesão ralado");
            ingredientes.Add("Azeitonas pretas");
        }
    }
}

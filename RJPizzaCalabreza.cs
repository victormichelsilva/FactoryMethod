using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class RJPizzaCalabreza : Pizza
    {
        public RJPizzaCalabreza()
        {
            Nome = "Pizza de calabreza Carioca com cebola";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Fatias de calabreza especial");
            ingredientes.Add("Queijo parmesão italiano tradicional");
        }
    }
}

using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Pizzaria ========\n");

            Console.WriteLine("Informe o local: (S)ão Paulo ou (R)io de Janeiro");
            var localEscolhido = Console.ReadLine().ToUpper();

            Console.WriteLine("Escolha a pizza: (M)ussarela ou (C)alabreza");
            var pizzaEscolhida = Console.ReadLine().ToUpper();

            try
            {
                PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);
                var pizza = pizzaria.MontaPizza(pizzaEscolhida);
                Console.WriteLine(pizza.Preparar());
                Console.WriteLine("\nPizza concluída com sucesso!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}

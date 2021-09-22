using System;
using System.Collections.Generic;
using Week1.Pizzeria.Core;
using Week1.Pizzeria.Core.InterfaceRepository;
using Week1.Pizzeria.Core.BusinessLayer;
using Week1.Pizzeria.RepositoryMock;

namespace Week1.Pizzeria
{
    class Program
    {

        private static readonly IBusinessLayer bl = new BusinessLayer(new RepositoryPizzeMock(), new RepositoryIngredientiMock(), new RepositoryIngredientiPizzeMock());
        static void Main(string[] args)
        {
            bool continua = true;

            do
            {
                Console.WriteLine("1. Scegli pizze dal menu generale");
                Console.WriteLine("2. Scegli pizze per ingredienti");
                Console.WriteLine("0. Exit");

                int scelta;
                Console.Write("Inserisci scelta: ");
                while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 2)
                {
                    Console.Write("\nScelta errata. Inserisci scelta corretta: ");
                }

                switch (scelta)
                {
                    case 0:
                        continua = false;
                        break;
                    case 1:
                        ScegliPizza();
                        break;
                    case 2:
                        ScegliPizzaByIngrediente();
                        break;

                }

            } while (continua);
        }

        private static void ScegliPizza()
        {
            List<Pizza> pizze = bl.FetchPizze();
            PrintPizze(pizze);
        }


        private static void ScegliPizzaByIngrediente()
        {
        }

        private static void PrintPizze(List<Pizza> pizze)
        {
            foreach (var pizza in pizze)
            {
                Console.WriteLine(pizza.Print());
            }
        }

        private static void PrintIngredienti(List<Ingrediente> ingredienti)
        {
            foreach (var ingrediente in ingredienti)
            {
                Console.WriteLine($"Premi {ingrediente.Id} per selezionare {ingrediente.Nome}");

            }
        }

    }
}
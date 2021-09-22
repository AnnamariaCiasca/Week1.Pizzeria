using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Pizzeria.Core.InterfaceRepository;

namespace Week1.Pizzeria.Core.BusinessLayer
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IPizzeRepository pizzeRepo;
        private readonly IIngredientiRepository ingredientiRepo;
        private readonly IIngredientePizzaRepository ingredientiPizzeRepo;


        public BusinessLayer(IPizzeRepository pizze, IIngredientiRepository ingredienti, IIngredientePizzaRepository ingredientiPizze)
        {
            pizzeRepo = pizze;
            ingredientiRepo = ingredienti;
            ingredientiPizzeRepo = ingredientiPizze;
        }

        public List<Ingrediente> FetchIngredienti()
        {
            return ingredientiRepo.Fetch();
        }


        public List<Pizza> FetchPizze()
        {
            #region MenuDaFile

            //const string path = @"C:\\Users\\annamaria.ciasca\\Desktop\\MenùPizzeria.txt";

            //string menu = string.Empty;

            //using (StreamReader sr = new StreamReader(path))
            //{
            //    menu = sr.ReadToEnd();
            //}

            //var righe = menu.Split("\r\n");

            //List<Pizza> pizze = new List<Pizza>();

            //foreach (var riga in righe)
            //{
            //    var pizzaArray = riga.Split("-");

            //    Pizza pizza = new Pizza();
            //    pizza.Nome = pizzaArray[0].Trim();
            //    pizza.Prezzo = Convert.ToDouble(pizzaArray[2].Trim());

            //    List<string> ingredienti = new List<string>();

            //    var ingredientiArray = pizzaArray[1].Split(",");

            //    foreach (var ingrediente in ingredientiArray)
            //    {
            //        ingredienti.Add(ingrediente.Trim());
            //    }

            //    pizza.Ingredienti = ingredienti;

            //    pizze.Add(pizza);
            //}

            //return pizze;
            #endregion
         
            var ingredienti = ingredientiRepo.Fetch();
            var ingredientiPizze = ingredientiPizzeRepo.Fetch();
            return pizzeRepo.Fetch(ingredienti, ingredientiPizze);
        }
    }
}

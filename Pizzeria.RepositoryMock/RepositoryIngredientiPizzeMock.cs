using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Pizzeria.Core.Entities;
using Week1.Pizzeria.Core.InterfaceRepository;

namespace Week1.Pizzeria.RepositoryMock
{
    public class RepositoryIngredientiPizzeMock : IIngredientePizzaRepository
    {
        public static List<IngredientePizza> ingredientiPizze = new List<IngredientePizza>()
        {
            new IngredientePizza(1, 1),
            new IngredientePizza(1, 2),
            new IngredientePizza(1, 3),
            new IngredientePizza(2, 1),
            new IngredientePizza(2, 4),
            new IngredientePizza(2, 7),
            new IngredientePizza(3, 1),
            new IngredientePizza(3, 2),
            new IngredientePizza(3, 5),
            new IngredientePizza(4, 1),
            new IngredientePizza(4, 2),
            new IngredientePizza(4, 6)
        };

        public List<IngredientePizza> Fetch()
        {
            return ingredientiPizze;
        }
    }
}
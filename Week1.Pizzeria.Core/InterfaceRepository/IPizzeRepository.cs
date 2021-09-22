using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Pizzeria.Core.Entities;

namespace Week1.Pizzeria.Core.InterfaceRepository
{
    public interface IPizzeRepository : IRepository<Pizza>
    {
        public List<Pizza> Fetch(List<Ingrediente> ingredienti, List<IngredientePizza> ingredientiPizza);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Pizzeria.Core.Entities
{
   public class IngredientePizza { 
   public int IdPizza { get; set; }
    public int IdIngrediente { get; set; }

    public IngredientePizza(int idPizza, int idIngrediente)
    {
        IdPizza = idPizza;
        IdIngrediente = idIngrediente;
    }
}
}

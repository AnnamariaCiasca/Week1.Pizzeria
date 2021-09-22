using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Pizzeria.Core;
using Week1.Pizzeria.Core.InterfaceRepository;

namespace Week1.Pizzeria.RepositoryMock
{
   public class RepositoryIngredientiMock : IIngredientiRepository
    {
        public static List<Ingrediente> ingredienti = new List<Ingrediente>() 
        {
            new Ingrediente(1, "Pomodoro"),
            new Ingrediente(2, "Mozzarella"),
            new Ingrediente(3, "Basilico"),
            new Ingrediente(4, "Aglio"),
            new Ingrediente(5, "Verdure"),
            new Ingrediente(6, "Salame Piccante"),
            new Ingrediente(7, "Origano"),


        };

        public List<Ingrediente> Fetch()
        {
            return ingredienti;
        }


        //public void Add(Ingrediente item)
        //{
        //    if(ingredienti.Count() == 0)
        //    {
        //        item.Id = 1;
        //    }
        //    else
        //    {
        //        var query = from ingrediente in ingredienti
        //                    orderby ingrediente.Id descending
        //                    select ingrediente.Id;

        //        var id = query.ToList();
        //        item.Id = id[0] + 1;

        //        ingredienti.Add(item);
        //    }
        //}
    }
}

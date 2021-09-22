using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.Pizzeria.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        List<Pizza> FetchPizze();
        List<Ingrediente> FetchIngredienti();
    }
}

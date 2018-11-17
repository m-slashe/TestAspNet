using System;
using System.Data.Entity;

namespace Teste.Models
{
    public class PizzaContext: DbContext
    {

        public DbSet<Pizza> Pizzas { get; set; }

        public PizzaContext()
        {
        }
    }
}

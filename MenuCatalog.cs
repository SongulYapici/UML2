using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace UML2
{
    public class MenuCatalog
    {
        List<Pizza> _pizzas;

        public MenuCatalog()
        {

            _pizzas = new List<Pizza>();
        }

        public void Create(Pizza p)
        {

            _pizzas.Add(p);
        }

        public void PrintMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("____________________________________________");
            foreach (var p in _pizzas)
            {
                Console.WriteLine(p);
            }
        }
        public Pizza Read(int number)

        {
            if (number >= 0 && number < _pizzas.Count)
            {
                return _pizzas[number - 1];
            }

            return null;

        }

        public Pizza SearchPizza(string criteria)
        {
            foreach (var p in _pizzas)
            {
                if (p.Name.ToLower() == criteria.ToLower()) return p;
            }
            return null;
        }

        public void Update(Pizza pizza)
        {
            foreach (var p in _pizzas)
            {
                if (p.Number == pizza.Number)
                {
                    p.Name = pizza.Name;
                    p.Price = pizza.Price;
                    return;
                }
            }




        }

        public void Delete(int pizzanummer)
        {
            _pizzas.RemoveAt(pizzanummer - 1);
        }
    }

        
       
}




using DotnetRESTAPIPizza.Models;

namespace DotnetRESTAPIPizza.Services
{


    public static class PizzaService
    {
        static List<Pizzaa> Pizzas { get; }

        static int nextId = 3;

        static PizzaService()
        {
            Pizzas = new List<Pizzaa>
        {
        new Pizzaa { Id = 1, Name = "Classic Italian", IsGlutenFree
        = false },
        new Pizzaa { Id = 2, Name = "Veggie", IsGlutenFree = true }
        };
        }


        public static List<Pizzaa> GetAll() => Pizzas;

        public static Pizzaa? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        public static void Add(Pizzaa pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        public static void Delete(int id)
        {
            var pizza = Get(id);

            if (pizza is null)
                return;

            Pizzas.Remove(pizza);
        }

        public static void Update(Pizzaa pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);

            if (index == -1)
                return;

            Pizzas[index] = pizza;
        }
    }
}
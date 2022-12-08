using DotnetRESTAPIPizza.Models;

namespace DotnetRESTAPIPizza.Services;

public static class DummyDataService
{
    // static List<Pizzaa> Pizzas { get; }

    // static int nextId = 3;

    // static bool MovieDemoDataInitilized = true;
    // static int MovieDemoDataNextId = 1;

    public static bool MovieDemoDataInitilized {get; set; } = false!;
    
    public static int MovieDemoDataNextId  {get; set; } = 1!;


    static DummyDataService()
    {
        // Pizzas = new List<Pizzaa>
        // {
        // new Pizzaa { Id = 1, Name = "Classic Italian", IsGlutenFree
        // = false },
        // new Pizzaa { Id = 2, Name = "Veggie", IsGlutenFree = true }
        // };
    }


}
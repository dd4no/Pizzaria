using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Models;

namespace Pizzaria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> PizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", BasePrice=12, TomatoSauce=true, Cheese=true, FinalPrice=14},
            new PizzasModel(){ImageTitle="Bolognese", BasePrice=12, TomatoSauce=true, Cheese=true, Beef=true, FinalPrice=15},
            new PizzasModel(){ImageTitle="Hawaiian", BasePrice=12, TomatoSauce=true, Cheese=true, Ham=true, Pinapple=true, FinalPrice=14},
            new PizzasModel(){ImageTitle="Carbonara", BasePrice=12, TomatoSauce=true, Cheese=true, Ham=true, Mushrooms=true, FinalPrice=14},
            new PizzasModel(){ImageTitle="MeatFeast", BasePrice=12, TomatoSauce=true, Cheese=true, Beef=true, Peperoni=true, Ham=true, Sausage=true, FinalPrice=16},
            new PizzasModel(){ImageTitle="Mushroom", BasePrice=12, TomatoSauce=true, Cheese=true, Mushrooms=true, FinalPrice=15},
            new PizzasModel(){ImageTitle="Pepperoni", BasePrice=12, TomatoSauce=true, Cheese=true, Peperoni=true, FinalPrice=15},
            new PizzasModel(){ImageTitle="Seafood", BasePrice=12, TomatoSauce=true, Cheese=true, Shrimp=true, FinalPrice=15},
            new PizzasModel(){ImageTitle="Vegetarian", BasePrice=12, TomatoSauce=true, Cheese=true, GreenPeppers=true, BlackOlives=true, Mushrooms=true, Onion=true, FinalPrice=18}
        
        
        };

        public void OnGet()
        {
        }
    }
}

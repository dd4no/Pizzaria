using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Models;

namespace Pizzaria.Pages
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 1;
            if (Pizza.Sausage) PizzaPrice += 1;
            if (Pizza.Beef) PizzaPrice += 1;
            if (Pizza.Ham) PizzaPrice += 1;
            if (Pizza.Shrimp) PizzaPrice += 1;
            if (Pizza.GreenPeppers) PizzaPrice += 1;
            if (Pizza.Mushrooms) PizzaPrice += 1;
            if (Pizza.BlackOlives) PizzaPrice += 1;
            if (Pizza.Onion) PizzaPrice += 1;
            if (Pizza.Pinapple) PizzaPrice += 1;

            return RedirectToPage("/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}

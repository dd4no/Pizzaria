namespace Pizzaria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 12;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Sausage { get; set; }
        public bool Beef { get; set; }
        public bool Ham { get; set; }
        public bool Shrimp { get; set; }
        public bool GreenPeppers { get; set; }
        public bool Onion { get; set; }
        public bool Mushrooms { get; set; }
        public bool BlackOlives { get; set; }
        public bool Pinapple { get; set; }
        public float FinalPrice { get; set; }
    }
}

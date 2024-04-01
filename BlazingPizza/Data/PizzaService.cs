namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<PizzaSpecial[]> GetPizzasAsync()
    {
        // Call your data access technology here
        PizzaSpecial[] pizzas =
        [
            new PizzaSpecial { Name = "The Baconatorizor", Vegetarian=false, Vegan = false, BasePrice =  11.99M, Description = "It has EVERY kind of bacon", ImageUrl="img/pizzas/bacon.jpg"},
            new PizzaSpecial { Name = "Buffalo chicken", Vegetarian=false, Vegan = false, BasePrice =  12.75M, Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", ImageUrl="img/pizzas/meaty.jpg"},
            new PizzaSpecial { Name = "Veggie Delight", Vegetarian=true, Vegan = true, BasePrice =  11.5M, Description = "It's like salad, but on a pizza", ImageUrl="img/pizzas/salad.jpg"},
        ];

        return Task.FromResult(pizzas);
    }
}
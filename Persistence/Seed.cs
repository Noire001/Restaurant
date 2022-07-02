using Domain;

namespace Persistence;

public class Seed
{
    public static async Task SeedData(DataContext context)
    {
        if (context.Items.Any()) return;
        var menuItems = new List<Item>
        {
            new()
            {
                Title = "Pizza Margherita",
                Category = "Pizza",
                Description = "San Marzano tomatoes, mozzarella cheese, fresh basil, salt, and extra-virgin olive oil",
                Price = 25f
            },
            new()
            {
                Title = "Pizza Capricciosa",
                Category = "Pizza",
                Description = "mozzarella cheese, Italian baked ham, mushroom, artichoke and tomato",
                Price = 30.50f
            },
            new()
            {
                Title = "Pizza Napoletana",
                Category = "Pizza",
                Description = "San Marzano tomatoes, mozzarella cheese, fresh basil, salt",
                Price = 30f
            },
            new()
            {
                Title = "Pizza Quattro Formaggi",
                Category = "Pizza",
                Description = "mozzarella cheese, parmeggiano, fontina",
                Price = 30f
            },
            new()
            {
                Title = "Pizza Vegetariana",
                Category = "Pizza",
                Description = "San Marzano tomatoes, mozzarella cheese, fresh basil, olives, green pepper",
                Price = 30f
            },
            new()
            {
                Title = "Pizza Margherita",
                Category = "Pizza",
                Description = "San Marzano tomatoes, mozzarella cheese, fresh basil, salt, and extra-virgin olive oil",
                Price = 25f
            },
            new()
            {
                Title = "Pizza Capricciosa",
                Category = "Pizza",
                Description = "mozzarella cheese, Italian baked ham, mushroom, artichoke and tomato",
                Price = 30.50f
            },
            new()
            {
                Title = "Salad",
                Category = "Salad",
                Description = "tomato asdfasfasdfad",
                Price = 12f
            },
            new()
            {
                Title = "Salad",
                Category = "Salad",
                Description = "tomato asdfasfasdfad",
                Price = 12f
            },
            new()
            {
                Title = "Salad",
                Category = "Salad",
                Description = "tomato asdfasfasdfad",
                Price = 12f
            },
            new()
            {
                Title = "Water",
                Category = "Drinks",
                Description = "bottled water",
                Price = 5f
            },
            new()
            {
                Title = "Wine",
                Category = "Drinks",
                Description = "the finest wine in the world",
                Price = 5000f
            },
            new()
            {
                Title = "Cola",
                Category = "Drinks",
                Description = "Coca-Cola or Pepsi",
                Price = 128f
            },
        };
        await context.Items.AddRangeAsync(menuItems);
        await context.SaveChangesAsync();
    }
}
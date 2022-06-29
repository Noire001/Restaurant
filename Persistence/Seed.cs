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
        };
        await context.Items.AddRangeAsync(menuItems);
        await context.SaveChangesAsync();
    }
}
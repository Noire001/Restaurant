using Domain;
using Microsoft.AspNetCore.Identity;

namespace Persistence;

public class Seed
{
    public static async Task SeedData(DataContext context, UserManager<User> userManager)
    {
        if (context.Items.Any() && userManager.Users.Any()) return;
        await userManager.CreateAsync(new()
        {
            UserName = "bob"
        }, "Pa$$w0rd");
        var categories = new List<Category>
        {
            new()
            {
                Name = "Salads",
                Priority = 0
            },
            new()
            {
                Name = "Drinks",
                Priority = 1
            },
            new()
            {
                Name = "Pizza",
                Priority = 2
            },
        };
        var menuItems = new List<Item>
        {
            new()
            {
                Title = "Pizza Margherita",
                Category = categories[2],
                Description = "San Marzano tomatoes, mozzarella cheese, fresh basil, salt, and extra-virgin olive oil",
                Price = 25f
            },
            new()
            {
                Title = "Pizza Capricciosa",
                Category = categories[2],
                Description = "mozzarella cheese, Italian baked ham, mushroom, artichoke and tomato",
                Price = 30.50f
            },
            new()
            {
                Title = "Pizza Napoletana",
                Category = categories[2],
                Description = "San Marzano tomatoes, mozzarella cheese, fresh basil, salt",
                Price = 30f
            },
            new()
            {
                Title = "Pizza Quattro Formaggi",
                Category = categories[2],
                Description = "mozzarella cheese, parmeggiano, fontina",
                Price = 30f
            },
            new()
            {
                Title = "Pizza Vegetariana",
                Category = categories[2],
                Description = "San Marzano tomatoes, mozzarella cheese, fresh basil, olives, green pepper",
                Price = 30f
            },
            new()
            {
                Title = "Pizza Margherita",
                Category = categories[2],
                Description = "San Marzano tomatoes, mozzarella cheese, fresh basil, salt, and extra-virgin olive oil",
                Price = 25f
            },
            new()
            {
                Title = "Pizza Capricciosa",
                Category = categories[2],
                Description = "mozzarella cheese, Italian baked ham, mushroom, artichoke and tomato",
                Price = 30.50f
            },
            new()
            {
                Title = "Salad",
                Category = categories[0],
                Description = "tomato asdfasfasdfad",
                Price = 12f
            },
            new()
            {
                Title = "Salad",
                Category = categories[0],
                Description = "tomato asdfasfasdfad",
                Price = 12f
            },
            new()
            {
                Title = "Salad",
                Category = categories[0],
                Description = "tomato asdfasfasdfad",
                Price = 12f
            },
            new()
            {
                Title = "Water",
                Category = categories[1],
                Description = "bottled water",
                Price = 5f
            },
            new()
            {
                Title = "Wine",
                Category = categories[1],
                Description = "the finest wine in the world",
                Price = 5000f
            },
            new()
            {
                Title = "Cola",
                Category = categories[1],
                Description = "Coca-Cola or Pepsi",
                Price = 128f
            },
        };
        await context.Items.AddRangeAsync(menuItems);
        await context.SaveChangesAsync();
    }
}
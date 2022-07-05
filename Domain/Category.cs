namespace Domain;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<Item> Items { get; set; } = null!;
    public int Priority { get; set; } = 0;
}
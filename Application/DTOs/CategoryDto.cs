namespace Application.DTOs;

public class CategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<ItemDto> Items { get; set; } = null!;
    public int Priority { get; set; }
}
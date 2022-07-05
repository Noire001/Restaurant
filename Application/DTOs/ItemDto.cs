namespace Application.DTOs;

public class ItemDto
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Category { get; set; } = null!;
    public float Price { get; set; }
    public string Description { get; set; } = null!;
}
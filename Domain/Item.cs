﻿namespace Domain;

public class Item
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string Category { get; set; } = null!;
    public float Price { get; set; }
    public string Description { get; set; } = null!;
}
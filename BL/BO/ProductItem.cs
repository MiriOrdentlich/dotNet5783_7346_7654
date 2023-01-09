﻿namespace BO;

public class ProductItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    public Category? Category { get; set; }
    public int Amount { get; set; } 
    public bool InStock { get; set; }
    public string? ImageRelativeName { get; set; }

    public override string ToString()
    {
        return this.ToStringProperty();
    }
}

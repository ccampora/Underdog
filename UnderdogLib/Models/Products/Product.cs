using System;
using Microsoft.EntityFrameworkCore;

namespace Underdog.Models.Products;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
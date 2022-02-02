﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unicorn.eShop.CartService.Entities;

namespace Unicorn.eShop.CartService;

[Table("Carts")]
[Index(nameof(UserId), IsUnique = true)]
[Index(nameof(Id), IsUnique = true)]
[Index(nameof(Id), nameof(UserId), IsUnique = true)]
public record Cart
{
    [Key]
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public IEnumerable<CartItem> Items { get; set; } = Enumerable.Empty<CartItem>();
    public decimal TotalPrice => Items.Sum(x => x.ItemPrice * x.Quantity);
}

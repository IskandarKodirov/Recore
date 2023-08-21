﻿using Recore.Domain.Commons;
using Recore.Domain.Entities.Products;

namespace Recore.Domain.Entities.Orders;

public class OrderItem : Auditable
{
    public double Quantity { get; set; }
    public decimal Price { get; set; }

    public long OrderId { get; set; }
    public Order Order { get; set; }

    public long ProductId { get; set; }
    public Product Product { get; set; }
}
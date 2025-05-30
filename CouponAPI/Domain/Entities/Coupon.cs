﻿namespace CouponAPI.Domain.Entities;

public class Coupon
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Percent { get; set; }
    public bool IsActive { get; set; }
    public DateTime Created { get; set; }
    public DateTime? LastUpdated { get; set; }
}

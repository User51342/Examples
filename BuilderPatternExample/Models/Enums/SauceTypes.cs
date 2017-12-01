using System;

namespace BuilderPatternExample.Models.Enums
{
    [Flags]
    public enum SauceTypes
    {
        Mustard = 1,
        Western = 2,
        Barbecue = 4,
        Mayonnaise = 8,
        Hot = 16
    }
}

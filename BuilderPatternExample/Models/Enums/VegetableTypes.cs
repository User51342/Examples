using System;

namespace BuilderPatternExample.Models.Enums
{
    [Flags]
    public enum VegetableTypes
    {
        Salad = 1,
        Onion = 2,
        Cucumber = 4,
        Tomato = 8
    }
}

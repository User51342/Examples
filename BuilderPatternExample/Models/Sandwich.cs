using BuilderPatternExample.Models.Enums;
using System;

namespace BuilderPatternExample.Models
{
    public class Sandwich
    {
        #region Properties
        public BreadType Bread { get; set; }
        public SauceTypes SauceTypes { get; set; }
        public VegetableTypes Vegetables { get; set; }
        public MeatType Meat { get; set; }
        #endregion

        #region Public methods
        public void Display()
        {
            Console.WriteLine($"Bread: {Bread.ToString()}");
            Console.WriteLine($"Meat: {Meat.ToString()}");
            Console.WriteLine($"Vegetables: {Vegetables.ToString()}");
            Console.WriteLine($"Sauces: {SauceTypes.ToString()}");
        }
        #endregion
    }
}

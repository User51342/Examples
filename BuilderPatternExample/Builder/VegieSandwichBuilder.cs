using BuilderPatternExample.Models.Enums;

namespace BuilderPatternExample.Builder
{
    public class VegieSandwichBuilder : SandwichBuilder
    {
        public override void ChooseBread()
        {
            sandwich.Bread = BreadType.Wholemeal;
        }

        public override void ChooseMeat()
        {
            sandwich.Meat = MeatType.None;
        }

        public override void ChooseSauces()
        {
            sandwich.SauceTypes = SauceTypes.Mustard | SauceTypes.Hot;
        }

        public override void ChooseVegetables()
        {
            sandwich.Vegetables = VegetableTypes.Cucumber | VegetableTypes.Onion | VegetableTypes.Salad | VegetableTypes.Tomato;
        }
    }
}

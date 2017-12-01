using BuilderPatternExample.Models.Enums;

namespace BuilderPatternExample.Builder
{
    public class ClubSandwichBuilder : SandwichBuilder
    {
        #region Public methods
        public override void ChooseBread()
        {
            sandwich.Bread = BreadType.White;
        }

        public override void ChooseMeat()
        {
            sandwich.Meat = MeatType.Chicken;
        }

        public override void ChooseSauces()
        {
            sandwich.SauceTypes = SauceTypes.Barbecue;
        }

        public override void ChooseVegetables()
        {
            sandwich.Vegetables = VegetableTypes.Tomato | VegetableTypes.Salad | VegetableTypes.Cucumber;
        }
        #endregion
    }
}

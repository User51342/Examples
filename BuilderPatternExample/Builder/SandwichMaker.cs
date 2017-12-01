using BuilderPatternExample.Models;

namespace BuilderPatternExample.Builder
{
    public class SandwichMaker
    {
        #region Fields
        private readonly SandwichBuilder sandwichBuilder;
        #endregion

        #region Construction / Initalization / Deconstruction
        public SandwichMaker(SandwichBuilder sandwichBuilder)
        {
            this.sandwichBuilder = sandwichBuilder;
        }
        #endregion

        #region Public Methods
        public void BuildSandwich()
        {
            sandwichBuilder.CreateNewSandwich();
            sandwichBuilder.ChooseBread();
            sandwichBuilder.ChooseMeat();
            sandwichBuilder.ChooseVegetables();
            sandwichBuilder.ChooseSauces();
        }

        public Sandwich GetSandwich()
        {
            return sandwichBuilder.GetSandwich();
        }
        #endregion
    }
}

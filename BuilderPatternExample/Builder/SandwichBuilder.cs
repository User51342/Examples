using BuilderPatternExample.Models;

namespace BuilderPatternExample.Builder
{
    public abstract class SandwichBuilder
    {
        #region Fields
        protected Sandwich sandwich;
        #endregion

        #region Construction / Initialization / Deconstruction
        public void CreateNewSandwich()
        {
            sandwich = new Sandwich();
        }
        #endregion

        #region Public methods
        public Sandwich GetSandwich()
        {
            return sandwich;
        }

        public abstract void ChooseBread();
        public abstract void ChooseMeat();
        public abstract void ChooseVegetables();
        public abstract void ChooseSauces();
        #endregion
    }
}

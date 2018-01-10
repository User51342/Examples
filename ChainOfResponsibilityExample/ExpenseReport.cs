namespace ChainOfResponsibilityExample
{
    public class ExpenseReport : IExpenseReport
    {
        #region Fields
        decimal _amount;
        #endregion

        #region Properties
        #endregion

        #region Construction / Initialization / Deconstruction
        public ExpenseReport(decimal amount)
        {
            _amount = amount;
        }

        public decimal GetAmount()
        {
            return _amount;
        }
        #endregion
    }
}

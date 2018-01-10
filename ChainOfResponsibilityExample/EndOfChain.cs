using System;

namespace ChainOfResponsibilityExample
{
    public class EndOfChainExpenseHandler : IExpenseHandler
    {
        #region Fields
        private static readonly EndOfChainExpenseHandler _instance = new EndOfChainExpenseHandler();
        #endregion

        #region Properties
        public static EndOfChainExpenseHandler Instance
        {
            get
            {
                return _instance;
            }
        }
        #endregion

        #region Construction / Initalization / Deconstruction
        private EndOfChainExpenseHandler()
        {
        }
        #endregion

        #region Public implementations
        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            return ApprovalResponse.Denied;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            throw new InvalidOperationException("End of chain handler must be the end of the chain!");
        }
        #endregion 
    }
}
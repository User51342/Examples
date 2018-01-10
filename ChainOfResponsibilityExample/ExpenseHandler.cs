namespace ChainOfResponsibilityExample
{
    public class ExpenseHandler : IExpenseHandler
    {
        #region Fields
        private IExpenseHandler _next;
        #endregion

        #region Properties
        public IExpenseApprover ExpenseApprover { get; }
        #endregion

        #region Construction / Initalization / Deconstruction
        public ExpenseHandler(IExpenseApprover expenseApprover)
        {
            ExpenseApprover = expenseApprover;
            _next = EndOfChainExpenseHandler.Instance;
        }
        #endregion

        #region Public implementations
        public ApprovalResponse Approve(IExpenseReport expenseReport)
        {
            var response = ExpenseApprover.ApproveExpanse(expenseReport);
            if(response == ApprovalResponse.BeyondApprovalLimit)
            {
                return _next.Approve(expenseReport);
            }
            return response;
        }

        public void RegisterNext(IExpenseHandler next)
        {
            _next = next;
        }
        #endregion
    }
}

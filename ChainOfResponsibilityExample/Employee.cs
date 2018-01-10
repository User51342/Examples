namespace ChainOfResponsibilityExample
{
    public class Employee : IExpenseApprover
    {
        #region Fields
        private readonly string _name;
        private readonly decimal _approvalAmount;
        #endregion

        #region Properties
        #endregion

        #region Construction / Initilization / Deconstruction
        public Employee(string name, decimal ApprovalAmount)
        {
            _name = name;
            _approvalAmount = ApprovalAmount;
        }
        #endregion

        #region  Public implementations
        public ApprovalResponse ApproveExpanse(IExpenseReport expenseReport)
        {
            if (expenseReport.GetAmount() > _approvalAmount)
            {
                return ApprovalResponse.BeyondApprovalLimit;
            }
            return ApprovalResponse.Approved;
        }
        #endregion
    }
}

namespace ChainOfResponsibilityExample
{
    public interface IExpenseApprover
    {
        ApprovalResponse ApproveExpanse(IExpenseReport expenseReport);
    }
}

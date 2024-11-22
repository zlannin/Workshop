namespace DPL.DeepThoughtBank.Accessors.Account.Contracts.Requests;

public class WithdrawRequest
{
    public int DepositAccountId { get; set; }
    public int WithdrawAccountId { get; set; }
    public decimal Amount { get; set; }
}
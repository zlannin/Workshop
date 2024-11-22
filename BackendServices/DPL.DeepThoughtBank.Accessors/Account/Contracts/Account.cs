namespace DPL.DeepThoughtBank.Accessors.Account.Contracts;

public class Account
{
    public int AccountId { get; set; }
    public required string AccountName { get; set; }
    public decimal Balance { get; set; }
}
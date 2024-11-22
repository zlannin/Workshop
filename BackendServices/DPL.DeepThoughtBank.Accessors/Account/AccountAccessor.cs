using DPL.DeepThoughtBank.Accessors.Account.Contracts.Requests;
using DPL.DeepThoughtBank.Accessors.Account.Contracts.Responses;

namespace DPL.DeepThoughtBank.Accessors.Account;

public class AccountAccessor : IAccountAccessor
{
    // TODO: Wire up to a database.
    private static readonly Contracts.Account[] Accounts =
    [
        new()
        {
            AccountId = 1,
            AccountName = "Broke Bob",
            Balance = 10
        },
        new()
        {
            AccountId = 2,
            AccountName = "Richy Rich",
            Balance = 1000000M
        }
    ];

    public WithdrawResponse Withdraw(WithdrawRequest request)
    {
        ArgumentNullException.ThrowIfNull(request);

        if (request.Amount <= 0)
        {
            throw new InvalidOperationException("Amount must be greater than zero.");
        }
        
        var withdrawAccount = Array.Find(Accounts, x => x.AccountId == request.WithdrawAccountId);
        if (withdrawAccount == null)
        {
            throw new KeyNotFoundException("Account you are withdrawing from was not found.");
        }
        
        var depositAccount = Array.Find(Accounts, x => x.AccountId == request.DepositAccountId);
        if (depositAccount == null)
        {
            throw new KeyNotFoundException("Account you are depositing to was not found.");
        }
        
        if (withdrawAccount.Balance < request.Amount)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        
        withdrawAccount.Balance -= request.Amount;
        depositAccount.Balance += request.Amount;

        return new WithdrawResponse
        {
            UpdatedBalance = withdrawAccount.Balance
        };
    }
}
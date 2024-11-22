using DPL.DeepThoughtBank.Accessors.Account.Contracts.Requests;
using DPL.DeepThoughtBank.Accessors.Account.Contracts.Responses;

namespace DPL.DeepThoughtBank.Accessors.Account;

public interface IAccountAccessor
{
    WithdrawResponse Withdraw(WithdrawRequest request);
}
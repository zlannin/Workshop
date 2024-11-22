using Bogus;
using DPL.DeepThoughtBank.Accessors.Account.Contracts;

namespace DPL.DeepThoughtBank.Tests.AccessorTests.Fakers;

public sealed class AccountFaker : Faker<Account>
{
    public AccountFaker()
    {
        RuleFor(r => r.AccountId, f => f.Random.Number(1, 1000));
        RuleFor(r => r.Balance, f => f.Random.Decimal(0, 2));
        RuleFor(r => r.AccountName, f => f.Name.FullName());
    }

    public override string ToString()
    {
        return $"{nameof(AccountFaker)}, Seed {localSeed}";
    }
}
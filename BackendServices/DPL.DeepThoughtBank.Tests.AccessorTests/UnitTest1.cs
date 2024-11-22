using Bogus;
using DPL.DeepThoughtBank.Accessors.Account;
using DPL.DeepThoughtBank.Accessors.Account.Contracts.Requests;
using DPL.DeepThoughtBank.Tests.AccessorTests.Fakers;

namespace DPL.DeepThoughtBank.Tests.AccessorTests;

[TestClass]
public class UnitTest1
{
    [TestInitialize]
    public void Initialize()
    {
        int seed = Environment.TickCount; // or any method to generate a seed
        Console.WriteLine("Seed: " + seed);
        Randomizer.Seed = new Random(seed);
    }
    // Red, Green, Refactor
    [TestMethod]
    public void FakerTest()
    {
        var faker = new AccountFaker();
        Console.WriteLine(faker.ToString());
        var account = faker.Generate();
        var account2 = faker.Generate();
        Assert.IsTrue(account.Balance >= 1, account.ToString());
    }
}
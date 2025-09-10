using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;

namespace Banking.Tests.MakingDeposits;
public class DepositsIncreaseBalance
{
    //[Fact]
    [Theory]
    [InlineData(110.10)]
    [InlineData(0.25)]
    [Trait("Category", "Unit")]
    public void MakingADeposit(decimal amountToDeposit)
    {
        // Given 
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        //var amountToDeposit = 100.10M;

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}

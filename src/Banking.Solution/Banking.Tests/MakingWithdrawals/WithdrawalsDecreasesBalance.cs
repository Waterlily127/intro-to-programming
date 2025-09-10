using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;

namespace Banking.Tests.MakingWithdrawals;
public class WithdrawalsDecreasesBalance
{
    //[Fact]
    [Theory]
    [InlineData(110.10)]
    [Trait("Category", "Unit")]
    public void MakingAWithdrawal(decimal amountToWithdraw)
    {
        // Given 
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        //var amountToWithdraw = 100.10M;

        account.Withdraw(amountToWithdraw);

        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }
}

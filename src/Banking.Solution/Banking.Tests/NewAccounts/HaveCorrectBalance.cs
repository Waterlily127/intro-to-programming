using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;

namespace Banking.Tests.NewAccounts;
public class HaveCorrectBalance
{

    [Fact]
    public void CorrectBalanceForNewAccounts()
    {
        // given I have a bank account
        var account = new BankAccount();
        // when I ask that account for the balance
        decimal balance = account.GetBalance();

        // then it should be...
        Assert.Equal(5000M, balance);


    }
}

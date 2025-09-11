using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Tests.TestDoubles;
public class StubbedBonusCalculator : ICalculateBonusesForBankAccount
{

    public decimal GetBonusForDepositOn(decimal balance, TransactionAmount amountToDeposit)
    {

        return balance == 5000M && amountToDeposit == 523.25M ? 420.69M : 0;
    }
}

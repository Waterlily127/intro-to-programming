using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Tests.TestDoubles;
public class DummyBonusCalculator : ICalculateBonusesForBankAccount
{
    public decimal GetBonusForDepositOn(decimal balance, TransactionAmount amountToDeposit)
    {

        return 0;
    }
}

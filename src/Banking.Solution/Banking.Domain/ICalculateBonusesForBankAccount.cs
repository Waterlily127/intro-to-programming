using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain;

public interface ICalculateBonusesForBankAccount
{
    decimal GetBonusForDepositOn(decimal balance, TransactionAmount amountToDeposit);
}

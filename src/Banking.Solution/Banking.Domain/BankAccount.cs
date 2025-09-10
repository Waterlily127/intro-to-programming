

namespace Banking.Domain;

// an object owns some data and the transformations associated with that data 
// sounds like a service? yup.
public class BankAccount
{
    private decimal balance = 5000M; // fields
    public void Deposit(decimal amountToDeposit)
    {
        balance = balance + amountToDeposit;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        balance -= amountToWithdraw;
    }

    public decimal GetBalance()
    {

        return balance; // just hard code it for now
    }
}
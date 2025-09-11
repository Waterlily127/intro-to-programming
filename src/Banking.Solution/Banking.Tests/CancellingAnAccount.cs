using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Tests;
[Trait("Category", "UnitIntegration")]
public class CancellingAnAccount
{
    [Fact]
    public async Task CancellingAnAccountNotifies()
    {
        // in this test we will  cancel an account and it should send 
        // an SMS notification to the customer AND, if the account is a VIP
        // account, it should notify the bank president, blah blah blah.
        await Task.Delay(300); // fake delay

    }
}

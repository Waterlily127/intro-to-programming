﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking.Domain;
using Banking.Domain.DomainExceptions;

namespace Banking.Tests;
public class TransactionAmountTests
{
    [Theory]
    [InlineData(120.23)]
    [InlineData(0.01)]
    public void ValidTransactionAmounts(decimal amount)
    {
        new TransactionAmount(amount);

    }

    [Theory]
    [InlineData(0)]
    [InlineData(-0.01)]
    public void InvalidTransactionAmounts(decimal amount)
    {
        Assert.Throws<InvalidTransactionAmountException>(() => new TransactionAmount(amount));
    }

    [Fact]
    public void TransactionsAboveLimitThrow()
    {
        Assert.Throws<TransactionAmountAboveLimitException>(() => new TransactionAmount(10_000.01M));
    }
}

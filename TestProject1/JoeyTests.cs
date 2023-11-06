using System;
using NUnit.Framework;

namespace TestProject1;

public class Period
{
    public Period(DateTime start, DateTime end)
    {
        Start = start;
        End = end;
    }

    public DateTime Start { get; private set; }
    public DateTime End { get; private set; }

    public int IntervalDays()
    {
        var intervalDays = (End - Start).Days + 1;
        return intervalDays;
    }
}

public class ValidationResult
{
    public ValidationResult(string errorMessage, bool isValid)
    {
        ErrorMessage = errorMessage;
        IsValid = isValid;
    }

    public string ErrorMessage { get; private set; }
    public bool IsValid { get; private set; }

    public void DumpLog()
    {
        if (!IsValid)
        {
            Console.WriteLine($"isValid:{IsValid}, errorMessage:{ErrorMessage}");
        }
    }
}

[TestFixture]
public class JoeyTests
{
    [Test]
    public void interval_days()
    {
        var start = new DateTime(2000, 10, 30);
        var end = new DateTime(2000, 11, 2);
        var intervalDays = (end - start).Days + 1;
        Assert.AreEqual(4, intervalDays);
    }

    [Test]
    public void out_refactor_sample()
    {
        var product = new Product() { Price = -1 };
        var validationResult = product.Validate();


        validationResult.DumpLog();
    }

}

public class Product
{
    public int Price { get; set; }

    public ValidationResult Validate()
    {
        var isValid = true;
        var errorMessage = "";
        if (Price < 0)
        {
            isValid = false;
            errorMessage = "price should > 0";
        }

        return new ValidationResult(errorMessage, isValid);
    }
}
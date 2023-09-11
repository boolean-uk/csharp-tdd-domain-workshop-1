using calculator.console;
using NUnit.Framework;

namespace calculator.tests;

[TestFixture]
public class CalculatorTests
{
   

  
    [Test]
    public void Add2Numbers()
    {
        //arrange
        int a = 3;
        int b = 2;
        int expected = 5;
        Calculator calc = new Calculator();
        //act

        int result = calc.Add(a, b);
        
        //assert

        Assert.IsTrue(result == expected);
        
    }

    [TestCase(3,3,6)]
    [TestCase(3, 4, 7)]
    [TestCase(1, 3, 4)]
    [TestCase(2, 5, 7)]
    public void AddAFewNumbers(int a, int b, int expected)
    {
        //arrange
        Calculator calc = new Calculator();

        //act
        int result = calc.Add(a, b);
        //assert
        Assert.IsTrue(result == expected);
    }



    [Test]
    public void MultiplyTwoNumbers()
    {
        //arrange
        Calculator calc = new Calculator();
        int a = 5;
        int b = 6;
        int expected = 30;

        //act
        int result = calc.Multiply(a, b);
        
        //assert        
        Assert.IsTrue(result == expected);

    }

    [Test]
    public void CheckTransactionHistory()
    {
        //arrange
        Calculator calc = new Calculator();
        int a = 2;
        int b = 3;
        int expected = 5;
        int transactionCount = 1;

        //act
        int result = calc.Add(a, b);

        //assert
        Assert.IsTrue(1 == calc.TransactionHistory.Count);
    }

    [Test]
    public void CheckAnAddTransaction()
    {
        //arrange
        Calculator calc = new Calculator();
        int a = 2;
        int b = 3;
        int expected = 5;
        int transactionCount = 1;

        //act
        int result = calc.Add(a, b);

        //assert
        Assert.IsTrue("2+3=5"  == calc.TransactionHistory[0]);
    }
    [Test]
    public void CheckAMultiplyTransaction()
    {
        //arrange
        Calculator calc = new Calculator();
        int a = 2;
        int b = 3;
        int expected = 6;
        int transactionCount = 1;

        //act
        int result = calc.Multiply(a, b);

        //assert
        Assert.IsTrue("2*3=6" == calc.TransactionHistory[0]);
    }

    //install-package nunit
    //install-package nunit3testadapter
    //install-package microsoft.net.test.sdk

}

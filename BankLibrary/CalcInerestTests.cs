using System;
//using Xunit;
using NUnit.Framework;
using BankingLibrary;
namespace BankLibraryTests
{
    [TestFixture]
    public class CalcInterestTest
    {
        [Test]
        public void Calculate_AcceptsPNR_ReturnsSI()
        {
            int ExpectedResult = 1000;
            ICalcInterest calc = new CalcInterest();
            int ActualResult = calc.Calculate(10000, 1, 10);
            Assert.AreEqual(ExpectedResult, ActualResult);

        }
    }
}

using System;

namespace BankingLibrary
{
    public class CalcInterest:ICalcInterest
    {
        public int Calculate(int principle, int RateOfInt, int years)
        {
            int SimpInt = (principle * years * RateOfInt) / 100;
            return SimpInt;
        }
    }
}

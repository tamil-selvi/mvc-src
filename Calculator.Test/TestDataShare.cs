using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Test
{
    public static class TestDataShare
    {
        public static IEnumerable<object[]> IsOddOrEvenData
        {
            get
            {
                yield return new object[] { 5, true };
                yield return new object[] { 6, false };
            }
        }

    }
}

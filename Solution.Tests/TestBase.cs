using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solution.Tests
{
    public class TestBase
    {
        public static void СheckExpectedActual(int[] expected, int[] actual)
        {
            for (int i = 0; i < 2; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}

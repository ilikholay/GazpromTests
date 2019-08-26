using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solution.Tests
{
    [TestClass]
    public class NegativeSolutionTests : TestBase
    {
        [TestMethod]
        public void Nums_2_7_11_15_Target_10()
        {
            //arrange
            int[] nums = new int[4] { 2, 7, 11, 15 };
            int[] expected = new int[2] { -1, -1 };
            int target = 10;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_2_7_11_15_Target_4()
        {
            //arrange
            int[] nums = new int[4] { 2, 7, 11, 15 };
            int[] expected = new int[2] { -1, -1 };
            int target = 4;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_2_7_11_15_17_19_Target_9()
        {
            //arrange
            int[] nums = new int[6] { 2, 7, 11, 15, 17, 19};
            int[] expected = new int[2] { -1, -1 };
            int target = 9;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_2_7_11_Target_9()
        {
            //arrange
            int[] nums = new int[3] { 2, 7, 11};
            int[] expected = new int[2] { -1, -1 };
            int target = 9;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_2_Target_4()
        {
            //arrange
            int[] nums = new int[1] { 2 };
            int[] expected = new int[2] { -1, -1 };
            int target = 4;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_zero_Target_9()
        {
            //arrange
            int[] nums = new int[0] {};
            int[] expected = new int[2] { -1, -1 };
            int target = 9;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Nums_null_Target_9()
        {
            //arrange
            int[] nums = null;
            int[] expected = new int[2] { -1, -1 };
            int target = 9;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }
    }
}

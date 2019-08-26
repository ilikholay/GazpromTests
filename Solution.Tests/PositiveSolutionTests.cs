using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solution.Tests
{
    [TestClass]
    public class PositiveSolutionTests : TestBase
    {
        [TestMethod]
        public void Nums_2_7_11_15_Target_9()
        {
            //arrange
            int[] nums = new int[4] { 2, 7, 11, 15 };
            int[] expected = new int[2] { 0, 1 };
            int target = 9;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_6_12_14_15_Target_20()
        {
            //arrange
            int[] nums = new int[4] { 6, 12, 14, 15 };
            int[] expected = new int[2] { 0, 2 };
            int target = 20;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_2_16_18_22_Target_25()
        {
            //arrange
            int[] nums = new int[4] { 3, 16, 18, 22 };
            int[] expected = new int[2] { 0, 3 };
            int target = 25;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_4_8_13_16_Target_29()
        {
            //arrange
            int[] nums = new int[4] { 4, 8, 13, 16 };
            int[] expected = new int[2] { 2, 3 };
            int target = 29;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_1_6_14_18_Target_20()
        {
            //arrange
            int[] nums = new int[4] { 1, 6, 14, 18 };
            int[] expected = new int[2] { 1, 2 };
            int target = 20;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_1_minus6_minus14_18_Target_minus20()
        {
            //arrange
            int[] nums = new int[4] { 1, -6, -14, 18 };
            int[] expected = new int[2] { 1, 2 };
            int target = -20;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_1_6_18_minus14_Target_minus8()
        {
            //arrange
            int[] nums = new int[4] { 1, 6, 18, -14 };
            int[] expected = new int[2] { 1, 3 };
            int target = -8;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_1_6_18_minus12_Target_6()
        {
            //arrange
            int[] nums = new int[4] { 1, 6, 18, -12 };
            int[] expected = new int[2] { 2, 3 };
            int target = 6;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_4_4_2_2_Target_4()
        {
            //arrange
            int[] nums = new int[4] { 4, 4, 2, 2 };
            int[] expected = new int[2] { 2, 3 };
            int target = 4;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }

        [TestMethod]
        public void Nums_2_2_2_2_Target_4()
        {
            //arrange
            int[] nums = new int[4] { 2, 2, 2, 2 };
            int[] expected = new int[2] { 0, 1 };
            int target = 4;

            //act
            GazpromTest.Solution s = new GazpromTest.Solution();
            int[] actual = s.TwoSum(nums, target);

            //assert
            СheckExpectedActual(expected, actual);
        }


    }
}

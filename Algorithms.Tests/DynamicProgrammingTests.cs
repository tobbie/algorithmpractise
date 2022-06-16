﻿using System;
using Xunit;
using Algorithims.DynamicProgramming.Medium;
using Algorithims.DynamicProgramming.Hard;

namespace Algorithms.Tests
{
   public class DynamicProgrammingTests
    {
        [Fact]
        public void ShouldReturnValidResult() {

            //arrange

            string str1 = "ZXVVYZW";
            string str2 = "XKYKZPW";
            //act

            var actual = LongestCommonSubsequence.LCM(str1, str2);

            //assert
            Assert.Equal("XYZW", actual);
        }

        [Fact]
        public void MinimumJumpsTest() {
            //arrange
              int[] array = new int[] { 3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3 };

            //int[] array = new int[] { 3, 2, 1, 0, 4 };

           // int[] array = new int[] { 2, 3, 1, 1, 4};
            int expected = 4;

            //act

            var actual = MinimumNumberOfJumps.MinumumJumps(array);

            //assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] {0, 8, 0, 0, 5, 0, 0, 10, 0, 0, 1, 1, 0, 3 }, 48)]
        [InlineData(new int[] { 0, 1, 0, 2, 1, 0, 1,3,2,1,2,1  }, 6)]
        public void ShouldReturnTrappedWater(int[] heights, int expected)
        {
            var actual = WaterArea.ComputeTrappedWater(heights);
            Assert.Equal(expected, actual);
        }

    }
}

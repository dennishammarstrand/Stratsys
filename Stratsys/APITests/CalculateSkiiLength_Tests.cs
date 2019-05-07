using API.Models;
using API.Processes;
using System;
using Xunit;

namespace APITests
{
    public class CalculateSkiiLength_Tests
    {
        [Theory]
        [InlineData(5, false)]
        [InlineData(4, true)]
        [InlineData(3, true)]
        [InlineData(2, true)]
        [InlineData(1, true)]
        [InlineData(0, true)]
        public void ChildFourOrYounger_Test(int value, bool expected)
        {
            var result = CalculateSkiLength.ChildFourOrYounger(value);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(100, "100")]
        public void LengthForFourOrYounger_Test(int value, string expected)
        {
            var result = CalculateSkiLength.LengthForFourOrYounger(value);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, true)]
        [InlineData(8, true)]
        [InlineData(9, false)]
        public void ChildBetweenFiveAndEight_Test(int value, bool expected)
        {
            var result = CalculateSkiLength.ChildBetweenFiveAndEight(value);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(150, "160 - 170")]
        public void LengthForFiveToEight_Test(int value, string expected)
        {
            var result = CalculateSkiLength.LengthForFiveToEight(value);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(185, "205")]
        [InlineData(210, "207")]
        public void CalculateClassic_Test(int value, string expected)
        {
            var result = CalculateSkiLength.CalculateClassic(value);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(185, "195 - 200")]
        public void CalculateFreestyle_Test(int value, string expected)
        {
            var result = CalculateSkiLength.CalculateFreestyle(value);

            Assert.Equal(expected, result);
        }
    }
}

using LeylandExercise.App;
using System;
using Xunit;

namespace LeylandExercise.Tests
{
    public class PerfectSquareTests
    {
        IPerfectSquareCalculator calculator = new PerfectSquareCalculator();

        private void TestNumber(int number, bool expected)
        {
            var actual = calculator.IsPerfectSquare(number);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_NegativeOne_Expect_False()
            => TestNumber(-1, false);

        [Fact]
        public void When_Zero_Expect_True()
            => TestNumber(0, true);

        [Fact]
        public void When_Three_Expect_False()
            => TestNumber(3, false);

        [Fact]
        public void When_Four_Expect_True()
            => TestNumber(4, true);

        [Fact]
        public void When_TwentyFive_Expect_True()
            => TestNumber(25, true);

        [Fact]
        public void When_TwentySix_Expect_False()
            => TestNumber(26, false);

        [Fact]
        public void When_NegativeNumber_Expect_False()
            => TestNumber(-13, false);

    }
}
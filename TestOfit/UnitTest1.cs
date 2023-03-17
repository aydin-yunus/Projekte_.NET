using System;
using Xunit;
using UnitTest___03___Winkel_zwischen_Uhrzeigern_16._03;
namespace TestOfit
{
    public class ClockTest
    {
        [Fact]
        public void TestMidDay()
        {
            const string time = "12:00";
            const int expectedAngle = 0;

            Assert.Equal(expectedAngle, Clock.GetAngle(time));
        }

        [Theory]
        [InlineData("15:00", 90)]
        [InlineData("3:00", 90)]
        [InlineData("18:00", 180)]
        [InlineData("6:00", 180)]
        [InlineData("21:00", 90)]
        [InlineData("9:00", 90)]
        public void TestFullTimes(string time, int expectedAngle)
        {
            Assert.Equal(expectedAngle, Clock.GetAngle(time));
        }


        [Theory]
        [InlineData("24:00")]
        [InlineData("12:64")]
        public void TestGiveFalseTimefail(string time)
        {
            Assert.Throws<ArgumentException>(() => Clock.GetAngle(time));
        }

        [Theory]
        [InlineData("12:01", 6)]
        [InlineData("15:15", 8)]
        [InlineData("18:30", 15)]
        public void TestMinutes(string time, int expectedAngle)
        {
            Assert.Equal(expectedAngle, Clock.GetAngle(time));
        }
    }
}
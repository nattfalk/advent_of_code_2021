using AOC2021.Days;

using Xunit;

namespace AOC2021.Test
{
    public class DayTests
    {
        [Fact]
        public void Day1_part1_ReturnsExpected()
        {
            var day = new Day1();

            var input = new int[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
            var result = day.ProcessPart1(input);

            Assert.Equal(7, result);
        }

        [Fact]
        public void Day1_part2_ReturnsExpected()
        {
            var day = new Day1();

            var input = new int[] { 199, 200, 208, 210, 200, 207, 240, 269, 260, 263 };
            var result = day.ProcessPart2(input);

            Assert.Equal(5, result);
        }

        [Fact]
        public void Day2_part1_ReturnsExpected()
        {
            var day = new Day2();

            var input = new string[] {
                "forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2"
            };
            var result = day.ProcessPart1(input);

            Assert.Equal(150, result);
        }

        [Fact]
        public void Day2_part2_ReturnsExpected()
        {
            var day = new Day2();

            var input = new string[] {
                "forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2"
            };
            var result = day.ProcessPart2(input);

            Assert.Equal(900, result);
        }

        [Fact]
        public void Day3_part1_ReturnsExpected()
        {
            var day = new Day3();

            var input = new string[] {
                "00100","11110","10110","10111",
                "10101","01111","00111","11100",
                "10000","11001","00010","01010"
            };
            var result = day.ProcessPart1(input);

            Assert.Equal(198, result);
        }

        [Fact]
        public void Day3_part2_ReturnsExpected()
        {
            var day = new Day3();

            var input = new string[] {
                "00100","11110","10110","10111",
                "10101","01111","00111","11100",
                "10000","11001","00010","01010"
            };
            var result = day.ProcessPart2(input);

            Assert.Equal(230, result);
        }
    }
}
using NUnit.Framework;
using Should.Fluent;

namespace FizzBuzzTristessa
{
    public class FizzBuzzerTests
    {
        #region Consts
        private const string UP_TO_100 = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz, 31, 32, Fizz, 34, Buzz, Fizz, 37, 38, Fizz, Buzz, 41, Fizz, 43, 44, FizzBuzz, 46, 47, Fizz, 49, Buzz, Fizz, 52, 53, Fizz, Buzz, 56, Fizz, 58, 59, FizzBuzz, 61, 62, Fizz, 64, Buzz, Fizz, 67, 68, Fizz, Buzz, 71, Fizz, 73, 74, FizzBuzz, 76, 77, Fizz, 79, Buzz, Fizz, 82, 83, Fizz, Buzz, 86, Fizz, 88, 89, FizzBuzz, 91, 92, Fizz, 94, Buzz, Fizz, 97, 98, Fizz, Buzz";
        private const string UP_TO_15 = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz";
        private const string UP_TO_5 = "1, 2, Fizz, 4, Buzz";
        #endregion 

        [TestFixture]
        public class FizzzBuzzTests
        {

            private string GetResult(int number)
            {
                var fizzBuzzer = new FizzBuzzer();

                var result = fizzBuzzer.FizzBuzzIt(number);

                return result;
            }

            [Test]
            public void FizzBuzz_1_should_return_1()
            {
                var result = GetResult(1);
                result.Should().Equal("1");
            }

            [Test]
            public void FizzBuzz_2_should_return_2()
            {
                var result = GetResult(2);
                result.Should().Equal("2");
            }

            [Test]
            public void FizzBuzz_3_should_return_Fizz()
            {
                var result = GetResult(3);
                result.Should().Equal("Fizz");
            }

            [Test]
            public void FizzBuzz_6_should_return_Fizz()
            {
                var result = GetResult(6);
                result.Should().Equal("Fizz");
            }

            [Test]
            public void FizzBuzz_5_should_return_Buzz()
            {
                var result = GetResult(5);
                result.Should().Equal("Buzz");
            }

            [Test]
            public void FizzBuzz_10_should_return_Buzz()
            {
                var result = GetResult(10);
                result.Should().Equal("Buzz");
            }

            [Test]
            public void FizzBuzz_15_should_return_FizzBuzz()
            {
                var result = GetResult(15);
                result.Should().Equal("FizzBuzz");
            }

            [Test]
            public void FizzBuzz_negative_1_should_return_minus_1()
            {
                var result = GetResult(-1);
                result.Should().Equal("-1");
            }

            [Test]
            public void FizzBuzz_negative_3_should_return_Fizz()
            {
                var result = GetResult(-3);
                result.Should().Equal("Fizz");
            }

            [Test]
            public void FizzBuzz_negative_5_should_return_Buzz()
            {
                var result = GetResult(-5);
                result.Should().Equal("Buzz");
            }

            [Test]
            public void FizzBuzz_negative_15_should_return_FizzBuzz()
            {
                var result = GetResult(-15);
                result.Should().Equal("FizzBuzz");
            }

            [Test]
            public void FizzBuzz_UpTo_5_should_return_1_2_Fizz_4_Buzz()
            {
                var fizzBuzzer = new FizzBuzzer();

                string result = fizzBuzzer.UpTo(5);

                result.Should().Equal("1, 2, Fizz, 4, Buzz");
            }

            [Test]
            public void FizzBuzz_UpTo_6_should_return_1_2_Fizz_4_Buzz_Fizz()
            {
                var fizzBuzzer = new FizzBuzzer();

                string result = fizzBuzzer.UpTo(6);

                result.Should().Equal("1, 2, Fizz, 4, Buzz, Fizz");
            }

            [Test]
            public void FizzBuzz_UpTo_15_should_return_correct_string()
            {
                var fizzBuzzer = new FizzBuzzer();

                string result = fizzBuzzer.UpTo(15);

                result.Should().Equal(UP_TO_15);
            }

            [Test]
            public void FizzBuzz_UpTo_100_should_return_correct_string()
            {
                var fizzBuzzer = new FizzBuzzer();

                string result = fizzBuzzer.UpTo(100);

                result.Should().Equal("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz, 31, 32, Fizz, 34, Buzz, Fizz, 37, 38, Fizz, Buzz, 41, Fizz, 43, 44, FizzBuzz, 46, 47, Fizz, 49, Buzz, Fizz, 52, 53, Fizz, Buzz, 56, Fizz, 58, 59, FizzBuzz, 61, 62, Fizz, 64, Buzz, Fizz, 67, 68, Fizz, Buzz, 71, Fizz, 73, 74, FizzBuzz, 76, 77, Fizz, 79, Buzz, Fizz, 82, 83, Fizz, Buzz, 86, Fizz, 88, 89, FizzBuzz, 91, 92, Fizz, 94, Buzz, Fizz, 97, 98, Fizz, Buzz");
            }

            [Test]
            public void FizzBuzz_UpTo_100000_should_return_correct_string()
            {
                var fizzBuzzer = new FizzBuzzer();

                string result = fizzBuzzer.UpTo(100000);

                result.Should().Equal("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz, 31, 32, Fizz, 34, Buzz, Fizz, 37, 38, Fizz, Buzz, 41, Fizz, 43, 44, FizzBuzz, 46, 47, Fizz, 49, Buzz, Fizz, 52, 53, Fizz, Buzz, 56, Fizz, 58, 59, FizzBuzz, 61, 62, Fizz, 64, Buzz, Fizz, 67, 68, Fizz, Buzz, 71, Fizz, 73, 74, FizzBuzz, 76, 77, Fizz, 79, Buzz, Fizz, 82, 83, Fizz, Buzz, 86, Fizz, 88, 89, FizzBuzz, 91, 92, Fizz, 94, Buzz, Fizz, 97, 98, Fizz, Buzz");
            }
        }
    }
}

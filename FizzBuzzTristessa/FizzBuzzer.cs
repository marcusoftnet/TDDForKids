using System;

namespace FizzBuzzTristessa
{
    public class FizzBuzzer
    {
        public string FizzBuzzIt(int number)
        {
            if (number % 3 == 0 &&
                number % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            return number.ToString();
        }

        public string UpTo(int number)
        {
            var result = "";
            for (int i = 1; i <= number; i++)
            {
                result = result + FizzBuzzIt(i) + ", ";
            }

            result = result.Substring(0, result.Length - 2);

            Console.WriteLine(result);

            return result;
        }
    }
}

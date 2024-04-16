using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    public static class FizzBuzzGame
    {
        public static string Play(int number)
        {
            if (number.IsDivisibleBy(3) && number.IsDivisibleBy(5))
                return "FizzBuzz";

            if (number.IsDivisibleBy(3))
                return "Fizz";

            if (number.IsDivisibleBy(5)) 
                return "Buzz";

            return number.ToString();
        }

        private static bool IsDivisibleBy(
            this int i, int divisibleBy) 
            => i % divisibleBy == 0;
    }
}

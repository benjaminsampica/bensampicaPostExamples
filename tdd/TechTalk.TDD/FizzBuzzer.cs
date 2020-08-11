using System;

namespace TechTalk.TDDTests
{
    public class FizzBuzzer
    {
        public static string GetValue(int value)
        {
            var result = string.Empty;
            if (value % 3 == 0)
                result += "Fizz";
            if (value % 5 == 0)
                result += "Buzz";
            if (result == string.Empty)
                result = value.ToString();
            return result;
        }
    }
}
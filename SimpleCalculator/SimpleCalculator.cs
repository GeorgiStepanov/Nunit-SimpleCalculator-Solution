namespace SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public static class SimpleCalculator
    {
        public static decimal Sum(decimal[] array)
        {

            decimal sum = 0m;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static decimal Average(decimal[] array)
        {
            decimal sum = 0m;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            decimal averageValue = 0m;

            return averageValue = sum / array.Length;
        }

        public static decimal Multiplication(decimal[] array)
        {
            decimal result = 1m;

            for (int i = 0; i < array.Length; i++)
            {
                result *= array[i];
            }

            return result;
        }

        public static decimal DevisionTwoNumbers(decimal dividend, decimal divisor)
        {
            decimal result = 0;

            result = dividend / divisor;

            return result;
        }

        public static decimal Subtraction(decimal[] numbers)
        {
            decimal result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result -= numbers[i];
            }

            return result;
        }
    }
}

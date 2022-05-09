using NUnit.Framework;

namespace SimpleCalculator.Tests
{
    public class SimpleCalculatorTests
    {
        [Test]
        public void Test_Sum_TwoPositiveIntegerNumbers()
        {
            decimal[] integerValues = new decimal[] { 5, 7 };

            decimal actualValue = SimpleCalculator.Sum(integerValues);
            decimal expectedValue = 12;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Sum_OnePositiveIntegerNumber()
        {
            decimal[] integerValue = new decimal[] { 4 };
            decimal actualValue = SimpleCalculator.Sum(integerValue);
            decimal expectedValue = 4;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            decimal result = SimpleCalculator.Sum(new decimal[] { });

            Assert.That(result == 0);
        }

        [Test]
        public void Test_Sum_TwoNegativeIntegerNumbers()
        {
            decimal[] integerValues = new decimal[] { -8, -11 };
            decimal actualValue = SimpleCalculator.Sum(integerValues);
            decimal expectedValue = -19;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Sum_TwoPositiveDecimalNumbers()
        {
            decimal[] decimalValues = new decimal[] { 13.53m, 22.8m };

            decimal actualValue = SimpleCalculator.Sum(decimalValues);
            decimal expectedValue = 36.33m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Sum_TwoNegativeDecimalNumbers()
        {
            decimal[] decimalValues = new decimal[] { -10.5m, -20.2m };

            decimal actualValue = SimpleCalculator.Sum(decimalValues);
            decimal expectedValue = -30.7m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Sum_OneNegativeDecimalNumber()
        {
            decimal[] decimalValue = new decimal[] { -3.5m };

            decimal actualValue = SimpleCalculator.Sum(decimalValue);
            decimal expectedValue = -3.5m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Sum_OnePositiveDecimalNumber()
        {
            decimal[] decimalValue = new decimal[] { 2.6m };

            decimal actualValue = SimpleCalculator.Sum(decimalValue);
            decimal expectedValue = 2.6m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Sum_TwoLargeIntegerNumbers()
        {
            decimal[] decimalValues = new decimal[] { 1000000000, 999999999 };

            decimal actualValue = SimpleCalculator.Sum(decimalValues);
            decimal expectedValue = 1999999999;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Average_TwoPositiveIntegerNumbers()
        {
            decimal[] integerValues = new decimal[] { 8m, 7m };

            decimal actualValue = SimpleCalculator.Average(integerValues);
            decimal expectedValue = 7.5m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Average_OnePositiveIntegerNumber()
        {
            decimal[] integerValue = new decimal[] { 7m };

            decimal actualValue = SimpleCalculator.Average(integerValue);
            decimal expectedValue = 7m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Average_TwoPositiveDecimalNumbers()
        {
            decimal[] decimalNumbers = new decimal[] { 4.5m, 10.5m };

            decimal actualValue = SimpleCalculator.Average(decimalNumbers);
            decimal expectedValue = 7.5m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Average_TwoNegativeDecimalNumbers()
        {
            decimal[] decimalNumbers = new decimal[] { -11.5m, -10.5m };

            decimal actualValue = SimpleCalculator.Average(decimalNumbers);
            decimal expectedValue = -11m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Multiplication_TwoPositiveIntegerNumbers()
        {
            decimal[] integerNumbers = new decimal[] { 2, 9 };

            decimal actualValue = SimpleCalculator.Multiplication(integerNumbers);
            decimal expectedValue = 18;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Multiplication_TwoNegativeIntegerNumbers()
        {
            decimal[] integerNumbers = new decimal[] { -11, -10 };

            decimal actualValue = SimpleCalculator.Multiplication(integerNumbers);
            decimal expectedValue = 110;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Multiplication_TwoPositiveDecimalNumbers()
        {
            decimal[] decimalNumbers = new decimal[] { 5.2m, 2.3m };

            decimal actualValue = SimpleCalculator.Multiplication(decimalNumbers);
            decimal expectedValue = 11.96m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Multiplication_TwoNegativeDecimalNumbers()
        {
            decimal[] decimalNumbers = new decimal[] { -3.3m, -2.2m };

            decimal actualValue = SimpleCalculator.Multiplication(decimalNumbers);
            decimal expectedValue = 7.26m;

            Assert.That(actualValue == expectedValue);
        }

        public void Test_Multiplication_PositiveAndNegativeIntegerNumbers()
        {
            decimal[] numbers = new decimal[] { -10m, 13m };

            decimal actualValue = SimpleCalculator.Multiplication(numbers);
            decimal expectedValue = -130m;

            Assert.That(actualValue == expectedValue);
        }

        public void Test_Multiplication_PositiveAndNegativeDecimalNumbers()
        {
            decimal[] numbers = new decimal[] { -10.5m, 2.2m };

            decimal actualValue = SimpleCalculator.Multiplication(numbers);
            decimal expectedValue = -23.1m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_DivisionTwoNumbers_PositiveIntegerNumbers()
        {
            decimal devidend = 7m;
            decimal divisor = 2m;

            decimal actualValue = SimpleCalculator.DevisionTwoNumbers(devidend, divisor);
            decimal expectedValue = 3.5m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_DivisionTwoNumbers_PositiveDecimalNumbers()
        {
            decimal devidend = 10.5m;
            decimal divisor = 2.2m;

            decimal actualValue = SimpleCalculator.DevisionTwoNumbers(devidend, divisor);
            decimal expectedValueFrom = 4.77m;
            decimal expectedValueTo = 4.773m;

            Assert.That(actualValue, Is.InRange(expectedValueFrom, expectedValueTo));
        }

        [Test]
        public void Test_DivisionTwoNumbers_NegativeIntegerNumbers()
        {
            decimal devidend = -22m;
            decimal divisor = -11m;

            decimal actualValue = SimpleCalculator.DevisionTwoNumbers(devidend, divisor);
            decimal expectedValue = 2m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_DivisionTwoNumbers_PositiveAndNegativeIntegerNumbers()
        {
            decimal devidend = 30m;
            decimal divisor = -15m;

            decimal actualValue = SimpleCalculator.DevisionTwoNumbers(devidend, divisor);
            decimal expectedValue = -2m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_DivisionTwoNumbers_PositiveAndNegativeDecimalNumbers()
        {
            decimal devidend = 100.5m;
            decimal divisor = -2.5m;

            decimal actualValue = SimpleCalculator.DevisionTwoNumbers(devidend, divisor);
            decimal expectedValue = -40.2m;

            Assert.That(actualValue == expectedValue);
        }

        [Test]
        public void Test_Subtraction_TwoPositiveIntegerNumbers()
        {
            decimal[] numbers = new decimal[] { 4, 6 };
            decimal actualValue = SimpleCalculator.Subtraction(numbers);

            decimal expectedValue = -2;

            Assert.AreEqual(actualValue, expectedValue);
        }

        [Test]
        public void Test_Subtraction_TwoPositiveDecimalNumbers()
        {
            decimal[] numbers = new decimal[] { 11.9m, 6.8m };
            decimal actualValue = SimpleCalculator.Subtraction(numbers);

            decimal expectedValue = 5.1m;

            Assert.AreEqual(actualValue, expectedValue);
        }

        [Test]
        public void Test_Subtraction_MoreThanTwoPositiveDecimalNumbers()
        {
            decimal[] numbers = new decimal[] { 11.9m, 6.8m, 5.1m, 5.2m };
            decimal actualValue = SimpleCalculator.Subtraction(numbers);

            decimal expectedValue = -5.2m;

            Assert.AreEqual(actualValue, expectedValue);
        }
    }
}
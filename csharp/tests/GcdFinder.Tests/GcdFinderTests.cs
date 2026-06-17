using System;
using GCDFinder;
using Xunit;

namespace GCDFinder.Tests
{
    public class GcdFinderTests
    {
        // --- Success cases: typical positive inputs ---

        [Theory]
        [InlineData(48, 18, 6)]
        [InlineData(100, 10, 10)]
        [InlineData(54, 24, 6)]
        [InlineData(17, 5, 1)]   // coprime numbers => 1
        [InlineData(13, 13, 13)] // equal primes
        public void FindGCD_WithPositiveNumbers_ReturnsGreatestCommonDivisor(int a, int b, int expected)
        {
            // Act
            int result = GcdFinder.FindGCD(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        // --- Failure / edge cases: negatives and zeros ---

        [Theory]
        [InlineData(-48, 18, 6)]
        [InlineData(48, -18, 6)]
        [InlineData(-48, -18, 6)]
        public void FindGCD_WithNegativeNumbers_NormalizesToAbsoluteValue(int a, int b, int expected)
        {
            // Act
            int result = GcdFinder.FindGCD(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, 9, 9)]
        [InlineData(9, 0, 9)]
        public void FindGCD_WithOneZeroOperand_ReturnsOtherOperand(int a, int b, int expected)
        {
            // Act
            int result = GcdFinder.FindGCD(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindGCD_WithBothZero_ReturnsZero()
        {
            // Act
            int result = GcdFinder.FindGCD(0, 0);

            // Assert
            Assert.Equal(0, result);
        }

        // --- Boundary cases: ones, equal values, and large numbers ---

        [Theory]
        [InlineData(1, 9999, 1)]
        [InlineData(9999, 1, 1)]
        [InlineData(7, 7, 7)]
        public void FindGCD_WithBoundaryValues_ReturnsExpected(int a, int b, int expected)
        {
            // Act
            int result = GcdFinder.FindGCD(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindGCD_WithIntMaxValueAndOne_ReturnsOne()
        {
            // Act
            int result = GcdFinder.FindGCD(int.MaxValue, 1);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void FindGCD_WithIntMaxValueAndItself_ReturnsItself()
        {
            // Act
            int result = GcdFinder.FindGCD(int.MaxValue, int.MaxValue);

            // Assert
            Assert.Equal(int.MaxValue, result);
        }

        // --- Edge cases: int.MinValue ---
        // Math.Abs(int.MinValue) overflows because its absolute value (2147483648)
        // exceeds int.MaxValue (2147483647), so FindGCD throws OverflowException
        // whenever int.MinValue is supplied as an operand.

        [Theory]
        [InlineData(int.MinValue, 18)]
        [InlineData(int.MinValue, 1)]
        [InlineData(int.MinValue, 0)]
        public void FindGCD_WithIntMinValueAsFirstOperand_ThrowsOverflowException(int a, int b)
        {
            // Act & Assert
            Assert.Throws<OverflowException>(() => GcdFinder.FindGCD(a, b));
        }

        [Theory]
        [InlineData(18, int.MinValue)]
        [InlineData(1, int.MinValue)]
        public void FindGCD_WithIntMinValueAsSecondOperand_ThrowsOverflowException(int a, int b)
        {
            // Act & Assert
            Assert.Throws<OverflowException>(() => GcdFinder.FindGCD(a, b));
        }

        [Fact]
        public void FindGCD_WithBothOperandsIntMinValue_ThrowsOverflowException()
        {
            // Act & Assert
            Assert.Throws<OverflowException>(() => GcdFinder.FindGCD(int.MinValue, int.MinValue));
        }

        [Fact]
        public void FindGCD_WithIntMinValuePlusOne_ReturnsExpected()
        {
            // Arrange: int.MinValue + 1 == -2147483647, which is safely negatable.
            // GCD(2147483647, 1) == 1 since int.MaxValue is prime.

            // Act
            int result = GcdFinder.FindGCD(int.MinValue + 1, 1);

            // Assert
            Assert.Equal(1, result);
        }
    }
}

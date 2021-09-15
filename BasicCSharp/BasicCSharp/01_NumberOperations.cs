using System;
using Xunit;

namespace BasicCSharp
{
    public class NumberOperations
    {
        [Fact]
        public void should_get_minimum_value_of_a_number_type()
        {
            // change "default(sbyte)" to correct value. You should not explicitly write -128.
            //sbyte minimum = default(sbyte);
            sbyte minimum = sbyte.MinValue;

            Assert.Equal(-128, minimum);
        }

        [Fact]
        public void should_get_maximum_value_of_a_number_type()
        {
            // change "default(int)" to correct value. You should not explicitly write 2147483647.
            int maximum = int.MaxValue;

            Assert.Equal(2147483647, maximum);
        }

        [Fact]
        public void should_get_correct_type_for_floating_point_number_without_literal()
        {
            // change "typeof(string)" to correct type.
            Type guessTheType = typeof(double);

            Assert.Equal(guessTheType, 1.0.GetType());
            Assert.Equal(guessTheType, 1E3.GetType());
        }

        [Fact]
        public void should_get_correct_type_for_integer_without_literal()
        {
            // change "typeof(string)" to correct type.
            Type guessTheType = typeof(int);

            Assert.Equal(guessTheType, 1.GetType());
            Assert.Equal(guessTheType, 0x123.GetType());
        }

        [Fact]
        public void should_get_correct_type_for_M_literal()
        {
            // change "typeof(string)" to correct type.
            Type guessTheType = typeof(decimal);

            Assert.Equal(guessTheType, 1M.GetType());
        }

        [Fact]
        public void should_get_correct_type_for_L_literal()
        {
            // change "typeof(string)" to correct type.
            Type guessTheType = typeof(long);

            Assert.Equal(guessTheType, 5L.GetType());
        }

        [Fact]
        public void should_get_correct_type_for_F_literal()
        {
            // change "typeof(string)" to correct type.
            Type guessTheType = typeof(float);

            Assert.Equal(guessTheType, 5F.GetType());
        }

        [Fact]
        public void should_cast_between_numeric_types()
        {
            int originNumber = 12345;
            long longNumber = originNumber;

            // change "default(long)" to correct value.
            const long expectedResult = 12345L;

            Assert.Equal(expectedResult, longNumber);
        }

        [Fact]
        public void should_cast_between_numeric_types_safely()
        {
            int originNumber = 12345;
            var shortNumber = (short)originNumber;

            // change "default(short)" to correct value.
            const short expectedResult = 12345;

            Assert.Equal(expectedResult, shortNumber);
        }

        [Fact]
        public void should_truncate_value_when_cast_overflow()
        {
            int originNumber = 0x1234;
            var byteNumber = (byte)originNumber;

            // change "default(byte)" to correct value.
            const byte expectedResult = 52;

            Assert.Equal(expectedResult, byteNumber);
        }

        [Fact]
        public void should_never_count_on_integer_floating_number_casting()
        {
            int originalNumber = 100000001;
            float floatingPointNumber = originalNumber;
            var castedBackNumber = (int)floatingPointNumber;

            // change "default(int)" to correct value.
            const int expectedResult = 100000000; // Why?

            Assert.Equal(expectedResult, castedBackNumber);
        }

        [Fact]
        public void should_use_fix_point_number_to_do_safe_casting_in_valid_range()
        {
            int originalNumber = 100000001;
            decimal decimalNumber = originalNumber;
            var castedBackNumber = (int)decimalNumber;

            // change "default(int)" to correct value.
            const int expectedResult = 100000001;

            Assert.Equal(expectedResult, castedBackNumber);
        }

        [Fact]
        public void should_return_original_value_using_suffix_incremental()
        {
            int numberToIncrement = 1;
            int suffixIncrementalReturnValue = numberToIncrement++;

            // change "default(int)" to correct value.
            const int expectedResult = 1;

            Assert.Equal(expectedResult, suffixIncrementalReturnValue);
        }

        [Fact]
        public void should_return_incremented_value_using_prefix_incremental()
        {
            int numberToIncrement = 1;
            int prefixIncrementalReturnValue = ++numberToIncrement;

            // change "default(int)" to correct value.
            const int expectedResult = 2;

            Assert.Equal(expectedResult, prefixIncrementalReturnValue);
        }

        [Fact]
        public void should_throw_exception_if_integer_divided_by_zero()
        {
            int numerator = 1;
            int denominator = 0;

            // change "typeof(ArgumentException)" to correct exception type.
            Type desiredExceptionType = typeof(DivideByZeroException);

            Assert.NotEqual(typeof(ArithmeticException), desiredExceptionType);
            Assert.NotEqual(typeof(SystemException), desiredExceptionType);
            Assert.NotEqual(typeof(Exception), desiredExceptionType);
            Assert.Throws(desiredExceptionType, () => numerator / denominator);
        }

        [Fact]
        public void should_overflow_sciently_for_integer_operation()
        {
            int minimumValue = int.MinValue;
            --minimumValue;

            // change "default(int)" to correct value.
            const int expectedResult = int.MaxValue;

            Assert.Equal(expectedResult, minimumValue);
        }

        [Fact]
        public void should_throw_on_checked_overflow()
        {
            int minimumValue = int.MinValue;

            // change "typeof(ArgumentException)" to correct exception type.
            Type desiredExceptionType = typeof(OverflowException);

            Assert.NotEqual(typeof(ArithmeticException), desiredExceptionType);
            Assert.NotEqual(typeof(SystemException), desiredExceptionType);
            Assert.NotEqual(typeof(Exception), desiredExceptionType);

            Assert.Throws(desiredExceptionType, () => { checked { --minimumValue; } });
        }

        [Fact]
        public void should_do_complement_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = -0x10;

            // https://www.cnblogs.com/buildnewhomeland/p/12129834.html
            // ~0xf = ~(0x_00_00_00_0f)
            //      = ~(0b_00000000_00000000_00000000_00001111)
            //      =   0b_11111111_11111111_11111111_11110000【补码】最高位为负号，从补码转换成原码，先减1得到反码，然后取反(除符号位)得到原码
            //      =   0b_11111111_11111111_11111111_11101111【反码】
            //      =   0b_10000000_00000000_00000000_00010000【原码】
            //      =  -0x_10
            Assert.Equal(expectedResult, ~0xf);
        }

        [Fact]
        public void should_do_and_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = 0x30;

            // 11110000 & 00110011 = 00110000 = 0x30
            Assert.Equal(expectedResult, (0xf0 & 0x33));
        }

        [Fact]
        public void should_do_or_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = 0xf3;

            // 11110000 | 00110011 = 11110011 = f3
            Assert.Equal(expectedResult, (0xf0 | 0x33));
        }

        [Fact]
        public void should_do_exclusive_or_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = 0xf0f0;

            // 1111_1111_0000_0000 ^ 0000_1111_1111_0000 = 1111_0000_1111_0000 = f0f0
            Assert.Equal(expectedResult, (0xff00 ^ 0x0ff0));
        }

        [Fact]
        public void should_do_shift_left_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = 0x80;

            // 0010_0000 << 2 = 1000_0000 = 80
            Assert.Equal(expectedResult, (0x20 << 2));
        }

        [Fact]
        public void should_do_shift_right_operation()
        {
            // change "default(int)" to correct value. You should use Hex representation.
            const int expectedResult = 0x10;

            // 0010_0000 >> 1 = 0001_0000 = 10
            Assert.Equal(expectedResult, (0x20 >> 1));
        }

        [Fact]
        public void should_change_type_for_8_and_16_bit_number_arithmetic_operators()
        {
            const short shortNumber = 1;
            const short anotherShortNumber = 1;
            // 会把byte、short等类型的数据进行四则运算后的结果设置为int类型，为的就是提醒用户这些数运算结果可能会溢出，所以要求用户进行一次强制类型转换
            Type arithmeticOperatorResultType = (shortNumber + anotherShortNumber).GetType();

            // change "typeof(short)" to correct type.
            Type expectedResult = typeof(int);

            Assert.Equal(expectedResult, arithmeticOperatorResultType);
        }

        [Fact]
        public void should_get_infinite_value_when_divide_by_zero_for_floating_point_number()
        {
            const double numerator = 1.0;
            const double denominator = 0.0;

            // change "default(double)" to correct value.
            const double expectedResult = Double.PositiveInfinity;

            Assert.Equal(expectedResult, (numerator / denominator));
        }

        [Fact]
        public void should_get_nan_when_doing_certain_operation_for_floating_point_number()
        {
            const double numerator = 0;
            const double denominator = 0;

            const double expectedResult = Double.NaN;

            Assert.Equal(expectedResult, (numerator / denominator));
        }
    }
}

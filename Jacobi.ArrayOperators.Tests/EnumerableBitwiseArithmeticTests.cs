using Jacobi.ArrayOperators;

namespace Jacobi.ArrayOperators.Tests;

public class EnumerableBitwiseArithmeticTests
{
    [Fact]
    public void ShiftLeft()
    {
        IEnumerable<int> arr = [1, 2, 4];
        var result = arr << 1;

        Assert.Equal([2, 4, 8], result);
    }
    [Fact]
    public void ShiftRight()
    {
        IEnumerable<int> arr = [2, 4, 8];
        var result = arr >> 1;

        Assert.Equal([1, 2, 4], result);
    }

    [Fact]
    public void BitwiseAnd()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [4, 6, 8];
        var result = arr1 & arr2;

        Assert.Equal([0, 2, 0], result);
    }
    [Fact]
    public void BitwiseOr()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [4, 6, 8];
        var result = arr1 | arr2;

        Assert.Equal([5, 6, 0xB], result);
    }
    [Fact]
    public void BitwiseXor()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [4, 6, 8];
        var result = arr1 ^ arr2;

        Assert.Equal([5, 4, 0xB], result);
    }
    [Fact]
    public void BitwiseNegate()
    {
        IEnumerable<byte> arr = [1, 22, 63];
        var result = ~arr;

        Assert.Equal([254, 233, 192], result);
    }
}

using System.Collections;
using Jacobi.ArrayOperators;

namespace Jacobi.ArrayOperators.Tests;

public class EnumerableBitArrayArithmeticTests
{
    [Fact]
    public void OpLogicAnd()
    {
        BitArray arr1 = new([true, false, false]);
        BitArray arr2 = new([true, false, true]);
        var result = arr1 & arr2;

        Assert.Equal([true, false, false], result.ToArray());
    }
    [Fact]
    public void OpLogicOr()
    {
        BitArray arr1 = new([true, false, false]);
        BitArray arr2 = new([true, false, true]);
        var result = arr1 | arr2;

        Assert.Equal([true, false, true], result.ToArray());
    }

    [Fact]
    public void OpLogicNegation()
    {
        BitArray arr = new([true, false, false]);
        var result = !arr;

        Assert.Equal([false, true, true], result.ToArray());
    }

    [Fact]
    public void OpLogicTrue()
    {
        BitArray arr = new([true, false, false]);
        var result = arr ? true : false;

        Assert.False(result);
    }
    [Fact]
    public void OpLogicFalse()
    {
        BitArray arr1 = new([true, false, false]);
        BitArray arr2 = new([true, false, true]);
        // && uses 'false' for short-circuiting
        if (arr1 && arr2)
            Assert.Fail();

        Assert.True(true);
    }
}

internal static class BitArrayExtensions
{
    public static bool[] ToArray(this BitArray bitArray)
    {
        bool[] array = new bool[bitArray.Length];
        bitArray.CopyTo(array, 0);
        return array;
    }
}

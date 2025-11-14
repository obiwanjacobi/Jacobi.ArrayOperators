using System.Collections.Specialized;

namespace Jacobi.ArrayOperators.Tests;

public class BitVector32ArithmeticTests
{
    [Fact]
    public void OpLogicAnd()
    {
        BitVector32 arr1 = new(0b100);
        BitVector32 arr2 = new(0b101);
        var result = arr1 & arr2;

        Assert.Equal(0b100, result.Data);
    }
    [Fact]
    public void OpLogicOr()
    {
        BitVector32 arr1 = new(0b100);
        BitVector32 arr2 = new(0b101);
        var result = arr1 | arr2;

        Assert.Equal(0b101, result.Data);
    }

    [Fact]
    public void OpLogicNegation()
    {
        BitVector32 arr = new(0b100);
        var result = !arr;

        Assert.Equal(-5, result.Data);
    }

    [Fact]
    public void OpLogicTrue()
    {
        BitVector32 arr = new(0b100);
        var result = arr ? true : false;

        Assert.False(result);
    }
    [Fact]
    public void OpLogicFalse()
    {
        BitVector32 arr1 = new(0b100);
        BitVector32 arr2 = new(0b101);
        // && uses 'false' for short-circuiting
        if (arr1 && arr2)
            Assert.Fail();

        Assert.True(true);
    }
}

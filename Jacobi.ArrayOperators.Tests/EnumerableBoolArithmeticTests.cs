using Jacobi.ArrayOperators;

namespace Jacobi.ArrayOperators.Tests;

public class EnumerableBoolArithmeticTests
{
    [Fact]
    public void OpLogicAnd()
    {
        IEnumerable<bool> arr1 = [true, false, false];
        IEnumerable<bool> arr2 = [true, false, true];

        var result = arr1 & arr2;

        Assert.Equal([true, false, false], result);
    }
    [Fact]
    public void OpLogicOr()
    {
        IEnumerable<bool> arr1 = [true, false, false];
        IEnumerable<bool> arr2 = [true, false, true];

        var result = arr1 | arr2;

        Assert.Equal([true, false, true], result);
    }

    [Fact]
    public void OpLogicNegation()
    {
        IEnumerable<bool> arr = [true, false, false];
        var result = !arr;

        Assert.Equal([false, true, true], result);
    }

    [Fact]
    public void OpLogicTrue()
    {
        IEnumerable<bool> arr = [true, false, false];
        var result = arr ? true : false;

        Assert.False(result);
    }
    [Fact]
    public void OpLogicFalse()
    {
        IEnumerable<bool> arr = [true, false, false];
        var result = !arr ? true : false;

        Assert.False(result);
    }
}

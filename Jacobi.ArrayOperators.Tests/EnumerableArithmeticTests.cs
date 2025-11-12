using Jacobi.ArrayOperators;

namespace Jacobi.ArrayOperators.Tests;

public class EnumerableArithmeticTests
{
    [Fact]
    public void OpPlus()
    {
        IEnumerable<int>  arr1 = [1, 2, 3];
        var arr2 = arr1 + 5;

        Assert.Equal([6, 7, 8], arr2);
    }
    [Fact]
    public void OpMinus()
    {
        IEnumerable<int>  arr1 = [1, 2, 3];
        var arr2 = arr1 - 5;

        Assert.Equal([-4, -3, -2], arr2);
    }
    [Fact]
    public void OpMultiply()
    {
        IEnumerable<int>  arr1 = [1, 2, 3];
        var arr2 = arr1 * 5;

        Assert.Equal([5, 10, 15], arr2);
    }
    [Fact]
    public void OpDivide()
    {
        IEnumerable<int>  arr1 = [10, 20, 30];
        var arr2 = arr1 / 5;

        Assert.Equal([2, 4, 6], arr2);
    }
    [Fact]
    public void OpModulus()
    {
        IEnumerable<int>  arr1 = [11, 12, 13];
        var arr2 = arr1 % 5;

        Assert.Equal([1, 2, 3], arr2);
    }
}

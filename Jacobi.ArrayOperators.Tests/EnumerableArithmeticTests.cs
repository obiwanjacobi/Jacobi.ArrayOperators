using Jacobi.ArrayOperators;

namespace Jacobi.ArrayOperators.Tests;

public class EnumerableArithmeticTests
{
    [Fact]
    public void ScalarPlus()
    {
        IEnumerable<int>  arr1 = [1, 2, 3];
        var arr2 = arr1 + 5;

        Assert.Equal([6, 7, 8], arr2);
    }
    [Fact]
    public void ScalarMinus()
    {
        IEnumerable<int>  arr1 = [1, 2, 3];
        var arr2 = arr1 - 5;

        Assert.Equal([-4, -3, -2], arr2);
    }
    [Fact]
    public void ScalarMultiply()
    {
        IEnumerable<int>  arr1 = [1, 2, 3];
        var arr2 = arr1 * 5;

        Assert.Equal([5, 10, 15], arr2);
    }
    [Fact]
    public void ScalarDivide()
    {
        IEnumerable<int>  arr1 = [10, 20, 30];
        var arr2 = arr1 / 5;

        Assert.Equal([2, 4, 6], arr2);
    }
    [Fact]
    public void ScalarModulus()
    {
        IEnumerable<int>  arr1 = [11, 12, 13];
        var arr2 = arr1 % 5;

        Assert.Equal([1, 2, 3], arr2);
    }

    [Fact]
    public void OpPlus()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [4, 5, 6];
        var result = arr1 + arr2;

        Assert.Equal([5, 7, 9], result);
    }
    [Fact]
    public void OpMinus()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [4, 5, 6];
        var result = arr1 - arr2;

        Assert.Equal([-3, -3, -3], result);
    }
    [Fact]
    public void OpMultiply()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [4, 5, 6];
        var result = arr1 * arr2;

        Assert.Equal([4, 10, 18], result);
    }
    [Fact]
    public void OpDivide()
    {
        IEnumerable<int> arr1 = [10, 20, 30];
        IEnumerable<int> arr2 = [4, 5, 6];
        var result = arr1 / arr2;

        Assert.Equal([2, 4, 5], result);
    }
    [Fact]
    public void OpModulo()
    {
        IEnumerable<int> arr1 = [10, 20, 30];
        IEnumerable<int> arr2 = [4, 5, 6];
        var result = arr1 % arr2;

        Assert.Equal([2, 0, 0], result);
    }

    [Fact]
    public void OpLengthMismatch()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [4, 5, 6, 7];
        var result = arr1 + arr2;

        Assert.Equal([5, 7, 9], result);
    }

    [Fact]
    public void OpUnaryMinus()
    {
        IEnumerable<int> arr = [1, 2, 3];
        var result = -arr;

        Assert.Equal([-1, -2, -3], result);
    }
}

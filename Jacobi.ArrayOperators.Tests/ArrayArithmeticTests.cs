using Jacobi.ArrayOperators;

namespace Jacobi.ArrayOperators.Tests;

public class ArrayArithmeticTests
{
    [Fact]
    public void MutPlus()
    {
        int[] arr = [1, 2, 3];
        arr += 5;

        Assert.Equal([6, 7, 8], arr);
    }
    [Fact]
    public void MutMinus()
    {
        int[] arr = [1, 2, 3];
        arr -= 5;

        Assert.Equal([-4, -3, -2], arr);
    }
    [Fact]
    public void MutMultiply()
    {
        int[] arr = [1, 2, 3];
        arr *= 5;

        Assert.Equal([5, 10, 15], arr);
    }
    [Fact]
    public void MutDivide()
    {
        int[] arr = [10, 20, 30];
        arr /= 5;

        Assert.Equal([2, 4, 6], arr);
    }
    [Fact]
    public void MutModulus()
    {
        int[] arr = [11, 12, 13];
        arr %= 5;

        Assert.Equal([1, 2, 3], arr);
    }

    [Fact]
    public void Increment()
    {
        int[] arr = [1, 2, 3];
        arr++;

        Assert.Equal([2, 3, 4], arr);
    }
    [Fact]
    public void Decrement()
    {
        int[] arr = [1, 2, 3];
        arr--;

        Assert.Equal([0, 1, 2], arr);
    }
}

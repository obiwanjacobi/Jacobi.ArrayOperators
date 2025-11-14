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

    [Fact]
    public void OpPlus()
    {
        int[] arr1 = [1, 2, 3];
        int[] arr2 = [4, 5, 6];
        var result = arr1 + arr2;

        Assert.Equal([5, 7, 9], result);
    }
    [Fact]
    public void OpMinus()
    {
        int[] arr1 = [1, 2, 3];
        int[] arr2 = [4, 5, 6];
        var result = arr1 - arr2;

        Assert.Equal([-3, -3, -3], result);
    }
    [Fact]
    public void OpMultiply()
    {
        int[] arr1 = [1, 2, 3];
        int[] arr2 = [4, 5, 6];
        var result = arr1 * arr2;

        Assert.Equal([4, 10, 18], result);
    }
    [Fact]
    public void OpDivide()
    {
        int[] arr1 = [10, 20, 30];
        int[] arr2 = [4, 5, 6];
        var result = arr1 / arr2;

        Assert.Equal([2, 4, 5], result);
    }
    [Fact]
    public void OpModulo()
    {
        int[] arr1 = [10, 20, 30];
        int[] arr2 = [4, 5, 6];
        var result = arr1 % arr2;

        Assert.Equal([2, 0, 0], result);
    }

    [Fact]
    public void ScalarPlus()
    {
        int[] arr1 = [1, 2, 3];
        var arr2 = arr1 + 5;

        Assert.Equal([6, 7, 8], arr2);
    }
    [Fact]
    public void ScalarMinus()
    {
        int[] arr1 = [1, 2, 3];
        var arr2 = arr1 - 5;

        Assert.Equal([-4, -3, -2], arr2);
    }
    [Fact]
    public void ScalarMultiply()
    {
        int[] arr1 = [1, 2, 3];
        var arr2 = arr1 * 5;

        Assert.Equal([5, 10, 15], arr2);
    }
    [Fact]
    public void ScalarDivide()
    {
        int[] arr1 = [10, 20, 30];
        var arr2 = arr1 / 5;

        Assert.Equal([2, 4, 6], arr2);
    }
    [Fact]
    public void ScalarModulus()
    {
        int[] arr1 = [11, 12, 13];
        var arr2 = arr1 % 5;

        Assert.Equal([1, 2, 3], arr2);
    }

    [Fact]
    public void ShiftLeft()
    {
        int[] arr = [1, 2, 4];
        var result = arr << 1;

        Assert.Equal([2, 4, 8], result);
    }
    [Fact]
    public void ShiftRight()
    {
        int[] arr = [2, 4, 8];
        var result = arr >> 1;

        Assert.Equal([1, 2, 4], result);
    }

    [Fact]
    public void BitwiseAnd()
    {
        int[] arr1 = [1, 2, 3];
        int[] arr2 = [4, 6, 8];
        var result = arr1 & arr2;

        Assert.Equal([0, 2, 0], result);
    }
    [Fact]
    public void BitwiseOr()
    {
        int[] arr1 = [1, 2, 3];
        int[] arr2 = [4, 6, 8];
        var result = arr1 | arr2;

        Assert.Equal([5, 6, 0xB], result);
    }
    [Fact]
    public void BitwiseXor()
    {
        int[] arr1 = [1, 2, 3];
        int[] arr2 = [4, 6, 8];
        var result = arr1 ^ arr2;

        Assert.Equal([5, 4, 0xB], result);
    }
    [Fact]
    public void BitwiseNegate()
    {
        byte[] arr = [1, 22, 63];
        var result = ~arr;

        Assert.Equal([254, 233, 192], result);
    }

    [Fact]
    public void FloatingPointAbs()
    {
        float[] arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Abs();

        Assert.Equal([1.4f, 2.2f, 3.14f], result);
    }
    [Fact]
    public void FloatingPointFloor()
    {
        float[] arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Floor();

        Assert.Equal([1f, -3f, 3f], result);
    }
    [Fact]
    public void FloatingPointCeiling()
    {
        float[] arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Ceiling();

        Assert.Equal([2f, -2f, 4f], result);
    }
    [Fact]
    public void FloatingPointRound()
    {
        float[] arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Round();

        Assert.Equal([1f, -2f, 3f], result);
    }
}

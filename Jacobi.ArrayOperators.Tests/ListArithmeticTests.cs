using Jacobi.ArrayOperators;

namespace Jacobi.listayOperators.Tests;

public class ListArithmeticTests
{
    [Fact]
    public void MutPlus()
    {
        IList<int> list = [1, 2, 3];
        list += 5;

        Assert.Equal([6, 7, 8], list);
    }
    [Fact]
    public void MutMinus()
    {
        IList<int> list = [1, 2, 3];
        list -= 5;

        Assert.Equal([-4, -3, -2], list);
    }
    [Fact]
    public void MutMultiply()
    {
        IList<int> list = [1, 2, 3];
        list *= 5;

        Assert.Equal([5, 10, 15], list);
    }
    [Fact]
    public void MutDivide()
    {
        IList<int> list = [10, 20, 30];
        list /= 5;

        Assert.Equal([2, 4, 6], list);
    }
    [Fact]
    public void MutModulus()
    {
        IList<int> list = [11, 12, 13];
        list %= 5;

        Assert.Equal([1, 2, 3], list);
    }

    [Fact]
    public void Increment()
    {
        IList<int> list = [1, 2, 3];
        list++;

        Assert.Equal([2, 3, 4], list);
    }
    [Fact]
    public void Decrement()
    {
        IList<int> list = [1, 2, 3];
        list--;

        Assert.Equal([0, 1, 2], list);
    }

    [Fact]
    public void OpPlus()
    {
        IList<int> list1 = [1, 2, 3];
        IList<int> list2 = [4, 5, 6];
        var result = list1 + list2;

        Assert.Equal([5, 7, 9], result);
    }
    [Fact]
    public void OpMinus()
    {
        IList<int> list1 = [1, 2, 3];
        IList<int> list2 = [4, 5, 6];
        var result = list1 - list2;

        Assert.Equal([-3, -3, -3], result);
    }
    [Fact]
    public void OpMultiply()
    {
        IList<int> list1 = [1, 2, 3];
        IList<int> list2 = [4, 5, 6];
        var result = list1 * list2;

        Assert.Equal([4, 10, 18], result);
    }
    [Fact]
    public void OpDivide()
    {
        IList<int> list1 = [10, 20, 30];
        IList<int> list2 = [4, 5, 6];
        var result = list1 / list2;

        Assert.Equal([2, 4, 5], result);
    }
    [Fact]
    public void OpModulo()
    {
        IList<int> list1 = [10, 20, 30];
        IList<int> list2 = [4, 5, 6];
        var result = list1 % list2;

        Assert.Equal([2, 0, 0], result);
    }

    [Fact]
    public void ScalarPlus()
    {
        IList<int> arr1 = [1, 2, 3];
        var arr2 = arr1 + 5;

        Assert.Equal([6, 7, 8], arr2);
    }
    [Fact]
    public void ScalarMinus()
    {
        IList<int> arr1 = [1, 2, 3];
        var arr2 = arr1 - 5;

        Assert.Equal([-4, -3, -2], arr2);
    }
    [Fact]
    public void ScalarMultiply()
    {
        IList<int> arr1 = [1, 2, 3];
        var arr2 = arr1 * 5;

        Assert.Equal([5, 10, 15], arr2);
    }
    [Fact]
    public void ScalarDivide()
    {
        IList<int> arr1 = [10, 20, 30];
        var arr2 = arr1 / 5;

        Assert.Equal([2, 4, 6], arr2);
    }
    [Fact]
    public void ScalarModulus()
    {
        IList<int> arr1 = [11, 12, 13];
        var arr2 = arr1 % 5;

        Assert.Equal([1, 2, 3], arr2);
    }

    [Fact]
    public void ShiftLeft()
    {
        IList<int> arr = [1, 2, 4];
        var result = arr << 1;

        Assert.Equal([2, 4, 8], result);
    }
    [Fact]
    public void ShiftRight()
    {
        IList<int> arr = [2, 4, 8];
        var result = arr >> 1;

        Assert.Equal([1, 2, 4], result);
    }

    [Fact]
    public void BitwiseAnd()
    {
        IList<int> arr1 = [1, 2, 3];
        IList<int> arr2 = [4, 6, 8];
        var result = arr1 & arr2;

        Assert.Equal([0, 2, 0], result);
    }
    [Fact]
    public void BitwiseOr()
    {
        IList<int> arr1 = [1, 2, 3];
        IList<int> arr2 = [4, 6, 8];
        var result = arr1 | arr2;

        Assert.Equal([5, 6, 0xB], result);
    }
    [Fact]
    public void BitwiseXor()
    {
        IList<int> arr1 = [1, 2, 3];
        IList<int> arr2 = [4, 6, 8];
        var result = arr1 ^ arr2;

        Assert.Equal([5, 4, 0xB], result);
    }
    [Fact]
    public void BitwiseNegate()
    {
        IList<byte> arr = [1, 22, 63];
        var result = ~arr;

        Assert.Equal([254, 233, 192], result);
    }

    [Fact]
    public void FloatingPointAbs()
    {
        IList<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Abs();

        Assert.Equal([1.4f, 2.2f, 3.14f], result);
    }
    [Fact]
    public void FloatingPointFloor()
    {
        IList<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Floor();

        Assert.Equal([1f, -3f, 3f], result);
    }
    [Fact]
    public void FloatingPointCeiling()
    {
        IList<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Ceiling();

        Assert.Equal([2f, -2f, 4f], result);
    }
    [Fact]
    public void FloatingPointRound()
    {
        IList<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Round();

        Assert.Equal([1f, -2f, 3f], result);
    }
}
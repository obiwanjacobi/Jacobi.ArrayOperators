using Jacobi.ArrayOperators;

namespace Jacobi.ArrayOperators.Tests;

public class ListArithmeticTests
{
    [Fact]
    public void MutPlus()
    {
        IList<int> collection = [1, 2, 3];
        collection += 5;

        Assert.Equal([6, 7, 8], collection);
    }
    [Fact]
    public void MutMinus()
    {
        IList<int> collection = [1, 2, 3];
        collection -= 5;

        Assert.Equal([-4, -3, -2], collection);
    }
    [Fact]
    public void MutMultiply()
    {
        IList<int> collection = [1, 2, 3];
        collection *= 5;

        Assert.Equal([5, 10, 15], collection);
    }
    [Fact]
    public void MutDivide()
    {
        IList<int> collection = [10, 20, 30];
        collection /= 5;

        Assert.Equal([2, 4, 6], collection);
    }
    [Fact]
    public void MutModulus()
    {
        IList<int> collection = [11, 12, 13];
        collection %= 5;

        Assert.Equal([1, 2, 3], collection);
    }

    [Fact]
    public void Increment()
    {
        IList<int> collection = [1, 2, 3];
        collection++;

        Assert.Equal([2, 3, 4], collection);
    }
    [Fact]
    public void Decrement()
    {
        IList<int> collection = [1, 2, 3];
        collection--;

        Assert.Equal([0, 1, 2], collection);
    }
}
using Jacobi.ArrayOperators;

namespace Jacobi.ArrayOperators.Tests;

public class CollectionArithmeticTests
{
    [Fact]
    public void MutPlus()
    {
        ICollection<int> collection = [1, 2, 3];
        collection += 5;

        Assert.Equal([6, 7, 8], collection);
    }
    [Fact]
    public void MutMinus()
    {
        ICollection<int> collection = [1, 2, 3];
        collection -= 5;

        Assert.Equal([-4, -3, -2], collection);
    }
    [Fact]
    public void MutMultiply()
    {
        ICollection<int> collection = [1, 2, 3];
        collection *= 5;

        Assert.Equal([5, 10, 15], collection);
    }
    [Fact]
    public void MutDivide()
    {
        ICollection<int> collection = [10, 20, 30];
        collection /= 5;

        Assert.Equal([2, 4, 6], collection);
    }
    [Fact]
    public void MutModulus()
    {
        ICollection<int> collection = [11, 12, 13];
        collection %= 5;

        Assert.Equal([1, 2, 3], collection);
    }

    [Fact]
    public void Increment()
    {
        ICollection<int> collection = [1, 2, 3];
        collection++;

        Assert.Equal([2, 3, 4], collection);
    }
    [Fact]
    public void Decrement()
    {
        ICollection<int> collection = [1, 2, 3];
        collection--;

        Assert.Equal([0, 1, 2], collection);
    }

    [Fact]
    public void MutPlus_WithHashSet()
    {
        ICollection<int> collection = new HashSet<int> { 1, 2, 3 };
        collection += 5;

        Assert.Equal([6, 7, 8], collection);
    }

    [Fact]
    public void Increment_WithHashSet()
    {
        ICollection<int> collection = new HashSet<int> { 1, 2, 3 };
        collection++;

        Assert.Equal([2, 3, 4], collection);
    }
}
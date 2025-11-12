using Jacobi.ArrayOperators;

namespace Jacobi.ArrayOperators.Tests;

public class EnumerableInterfacesTests
{
    [Fact]
    public void Equatable()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [1, 2, 5];

        Assert.False(arr1 == arr2);
        Assert.True(arr1 != arr2);
    }
    [Fact]
    public void Comparable()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [1, 2, 5];

        Assert.False(arr1 > arr2);
        Assert.True(arr1 < arr2);
        Assert.False(arr1 >= arr2);
        Assert.True(arr1 <= arr2);
    }

    [Fact]
    public void Equatable_Length()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [1, 2, 3, 5];

        Assert.False(arr1 == arr2);
        Assert.True(arr1 != arr2);
    }
    [Fact]
    public void Comparable_Length()
    {
        IEnumerable<int> arr1 = [1, 2, 3];
        IEnumerable<int> arr2 = [1, 2, 3, 5];

        Assert.False(arr1 > arr2);
        Assert.True(arr1 < arr2);
        Assert.False(arr1 >= arr2);
        Assert.True(arr1 <= arr2);
    }

    [Fact]
    public void FloatingPointAbs()
    {
        IEnumerable<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Abs();

        Assert.Equal([1.4f, 2.2f, 3.14f], result);
    }
    [Fact]
    public void FloatingPointFloor()
    {
        IEnumerable<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Floor();

        Assert.Equal([1f, -3f, 3f], result);
    }
    [Fact]
    public void FloatingPointCeiling()
    {
        IEnumerable<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Ceiling();

        Assert.Equal([2f, -2f, 4f], result);
    }
    [Fact]
    public void FloatingPointRound()
    {
        IEnumerable<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Round();

        Assert.Equal([1f, -2f, 3f], result);
    }

    [Fact]
    public void NumberSum()
    {
        IEnumerable<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Sum();

        Assert.Equal(2.34f, result, 0.001);
    }
    [Fact]
    public void NumberProduct()
    {
        IEnumerable<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Product();

        Assert.Equal(-9.6712f, result, 0.0001);
    }
    [Fact]
    public void NumberAvarage()
    {
        IEnumerable<float> arr = [1.4f, -2.2f, 3.14f];
        var result = arr.Average();

        Assert.Equal(0.78f, result, 0.001);
    }
}

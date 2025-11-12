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
}

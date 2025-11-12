# Array Operators

This library provides a set of operator extension in `Array` and `IEnumerable<T>`.

This will allow you to do array arithmetic in a more natural way.

## Usage

Add the `Jacobi.ArrayOperators` nuget package to your project.

```csharp
using Jacobi.ArrayOperators;
```
An some examples of array (`IEnumerable<T>`) arithmetic:

```csharp
int[] arr = [1, 2, 3];
// this works for any IEnumerable<T>
var result = arr * 5;
// result is [5, 10, 15]
```
```csharp
int[] arr1 = [1, 2, 3];
int[] arr2 = [6, 8, 3];
var result = arr + arr2;
// result is [7, 10, 6]
```

Array specific operations:

```csharp
int[] arr = [1, 2, 3];
arr += 5;
// arr is now [6, 7, 8]
```

Compare two arrays (`IEnumerable<T>`):

```csharp
int[] arr1 = [1, 2, 3];
int[] arr2 = [1, 2, 3];
if (arr1 == arr2)
{
    // this block will be executed
}
```

```csharp
int[] arr1 = [1, 2, 3]
int[] arr2 = [6, 8, 3]
if (arr1 > arr2)
{
    // this block will not be executed
}
```

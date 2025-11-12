# Array Operators

This library provides a set of operator extension for `Array`, `IEnumerable<T>` and `ICollection<T>` types.

This will allow you to do 'array arithmetic' in a more natural way.

## Key Advantages

1. **Readability**: Mathematical operations look like actual math notation
2. **Performance**: Batch operations instead of loops
3. **Maintainability**: Less boilerplate code
4. **Safety**: Type-safe generic constraints ensure valid operations
5. **Expressiveness**: Natural syntax for array/vector mathematics

## Usage

Add the `Jacobi.ArrayOperators` nuget package to your project.

```csharp
using Jacobi.ArrayOperators;
```
Here are some examples of array (`IEnumerable<T>`) arithmetic:

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

When Arrays are of different lengths, only the calculated items are returned (shortest array length):

```csharp
IEnumerable<int> arr1 = [1, 2, 3];
IEnumerable<int> arr2 = [4, 5, 6, 7];
var result = arr1 + arr2;
// result is [5, 7, 9]
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

---

## Operator Extensions Reference

### IEnumerable\<T> Arithmetic Operators (Element-wise)

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
| `+` | Element-wise addition of two sequences | `[1, 2, 3] + [4, 5, 6]` | `[5, 7, 9]` |
| `-` | Element-wise subtraction of two sequences | `[10, 20, 30] - [1, 2, 3]` | `[9, 18, 27]` |
| `*` | Element-wise multiplication of two sequences | `[1, 2, 3] * [4, 5, 6]` | `[4, 10, 18]` |
| `/` | Element-wise division of two sequences | `[10, 20, 30] / [2, 4, 5]` | `[5, 5, 6]` |
| `%` | Element-wise modulus of two sequences | `[10, 20, 30] % [3, 6, 7]` | `[1, 2, 2]` |
| `-` (unary) | Negates each element | `-[1, -2, 3]` | `[-1, 2, -3]` |
| `+` (unary) | Unary plus on each element | `+[1, 2, 3]` | `[1, 2, 3]` |

### IEnumerable\<T> Scalar Arithmetic Operators

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
| `+` | Adds scalar to each element | `[1, 2, 3] + 5` | `[6, 7, 8]` |
| `-` | Subtracts scalar from each element | `[10, 20, 30] - 5` | `[5, 15, 25]` |
| `*` | Multiplies each element by scalar | `[1, 2, 3] * 5` | `[5, 10, 15]` |
| `/` | Divides each element by scalar | `[10, 20, 30] / 5` | `[2, 4, 6]` |
| `%` | Modulus of each element by scalar | `[11, 12, 13] % 5` | `[1, 2, 3]` |

### IEnumerable\<bool> Logical Operators

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
| `&` | Element-wise logical AND | `[true, false, true] & [true, true, false]` | `[true, false, false]` |
| `\|` | Element-wise logical OR | `[true, false, false] \| [false, false, true]` | `[true, false, true]` |
| `^` | Element-wise logical XOR | `[true, false, true] ^ [true, true, false]` | `[false, true, true]` |
| `!` | Negates each boolean element | `![true, false, true]` | `[false, true, false]` |
| `true` | Returns true if all elements are true | `if ([true, true, true])` | `true` |
| `false` | Returns true if all elements are false | `if (![false, false, false])` | `true` |

### IEnumerable\<T> Bitwise Operators

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
| `&` | Element-wise bitwise AND | `[0b1100, 0b1010] & [0b1010, 0b1100]` | `[0b1000, 0b1000]` |
| `\|` | Element-wise bitwise OR | `[0b1100, 0b1010] \| [0b0011, 0b0101]` | `[0b1111, 0b1111]` |
| `^` | Element-wise bitwise XOR | `[0b1100, 0b1010] ^ [0b1010, 0b1100]` | `[0b0110, 0b0110]` |
| `~` | Bitwise complement of each element | `~[0b1100, 0b0011]` | `[~0b1100, ~0b0011]` |
| `<<` | Left shift each element by amount | `[1, 2, 3] << 2` | `[4, 8, 12]` |
| `>>` | Right shift each element by amount | `[16, 32, 64] >> 2` | `[4, 8, 16]` |
| `>>>` | Unsigned right shift each element | `[8, 16, 32] >>> 1` | `[4, 8, 16]` |

### IEnumerable\<T> Comparison Operators

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
| `==` | Compares sequences for equality | `[1, 2, 3] == [1, 2, 3]` | `true` |
| `!=` | Compares sequences for inequality | `[1, 2, 3] != [1, 2, 4]` | `true` |
| `<` | Lexicographic less than comparison | `[1, 2, 3] < [1, 2, 4]` | `true` |
| `>` | Lexicographic greater than comparison | `[1, 3] > [1, 2, 3]` | `true` |
| `<=` | Lexicographic less than or equal | `[1, 2] <= [1, 2, 3]` | `true` |
| `>=` | Lexicographic greater than or equal | `[1, 2, 3] >= [1, 2]` | `true` |

### T[] Array Arithmetic Operators (In-place)

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
| `++` | Increments each element in-place | `arr++` where `arr = [1, 2, 3]` | `[2, 3, 4]` |
| `--` | Decrements each element in-place | `arr--` where `arr = [1, 2, 3]` | `[0, 1, 2]` |
| `+=` | Adds scalar to each element in-place | `arr += 5` where `arr = [1, 2, 3]` | `[6, 7, 8]` |
| `-=` | Subtracts scalar from each element | `arr -= 5` where `arr = [10, 20]` | `[5, 15]` |
| `*=` | Multiplies each element by scalar | `arr *= 5` where `arr = [1, 2, 3]` | `[5, 10, 15]` |
| `/=` | Divides each element by scalar | `arr /= 2` where `arr = [10, 20]` | `[5, 10]` |
| `%=` | Modulus each element by scalar | `arr %= 5` where `arr = [11, 12]` | `[1, 2]` |

### IList\<T> Arithmetic Operators (In-place)

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
| `++` | Increments each element in-place | `list++` where `list = [1, 2, 3]` | `[2, 3, 4]` |
| `--` | Decrements each element in-place | `list--` where `list = [1, 2, 3]` | `[0, 1, 2]` |
| `+=` | Adds scalar to each element in-place | `list += 5` where `list = [1, 2]` | `[6, 7]` |
| `-=` | Subtracts scalar from each element | `list -= 3` where `list = [10, 20]` | `[7, 17]` |
| `*=` | Multiplies each element by scalar | `list *= 2` where `list = [5, 10]` | `[10, 20]` |
| `/=` | Divides each element by scalar | `list /= 2` where `list = [10, 20]` | `[5, 10]` |
| `%=` | Modulus each element by scalar | `list %= 5` where `list = [11, 12]` | `[1, 2]` |

### ICollection\<T> Arithmetic Operators (In-place)

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
| `++` | Increments each element in-place | `col++` where `col = [1, 2, 3]` | `[2, 3, 4]` |
| `--` | Decrements each element in-place | `col--` where `col = [1, 2, 3]` | `[0, 1, 2]` |
| `+=` | Adds scalar to each element in-place | `col += 5` where `col = [1, 2]` | `[6, 7]` |
| `-=` | Subtracts scalar from each element | `col -= 3` where `col = [10, 20]` | `[7, 17]` |
| `*=` | Multiplies each element by scalar | `col *= 2` where `col = [5, 10]` | `[10, 20]` |
| `/=` | Divides each element by scalar | `col /= 2` where `col = [10, 20]` | `[5, 10]` |
| `%=` | Modulus each element by scalar | `col %= 5` where `col = [11, 12]` | `[1, 2]` |

### BitArray Operators

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
| `&` | Bitwise AND of two BitArrays | `bitArr1 & bitArr2` | Element-wise AND |
| `\|` | Bitwise OR of two BitArrays | `bitArr1 \| bitArr2` | Element-wise OR |
| `^` | Bitwise XOR of two BitArrays | `bitArr1 ^ bitArr2` | Element-wise XOR |
| `!` | Bitwise NOT (inverts all bits) | `!bitArr` | Inverted bits |
| `true` | Returns true if all bits are set | `if (bitArr)` | `true` if all 1s |
| `false` | Returns true if all bits are clear | `if (!bitArr)` | `true` if all 0s |

### BitVector32 Operators

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
| `&` | Bitwise AND | `vec1 & vec2` | Bitwise AND result |
| `\|` | Bitwise OR | `vec1 \| vec2` | Bitwise OR result |
| `^` | Bitwise XOR | `vec1 ^ vec2` | Bitwise XOR result |
| `!` | Bitwise NOT (complement) | `!vec` | Bitwise complement |
| `true` | Returns true if all bits are set | `if (vec)` | `true` if Data == int.MaxValue |
| `false` | Returns true if no bits are set | `if (!vec)` | `true` if Data == 0 |

**Notes:**
- Element-wise operations stop at the length of the shorter sequence
- In-place operators modify the original array/collection/list
- `IList<T>` operators use optimized indexed access
- `ICollection<T>` operators work with non-indexed collections (e.g., `HashSet<T>`)
- Requires types implementing appropriate `System.Numerics` interfaces
- `BitArray` operations maintain minimum length between operands
- `BitVector32` works with 32-bit integer data

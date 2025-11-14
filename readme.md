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

> `IEnumerbale<T>` and `Ilist<T>` return types are implemented by `List<T>`.

### Arithmetic Operators

| Operator | Types | Description | Example | Result |
|----------|-------|-------------|---------|--------|
| `+` | `T[]`, `IList<T>`, `IEnumerable<T>` | Element-wise addition of two sequences | `[1, 2, 3] + [4, 5, 6]` | `[5, 7, 9]` |
| `-` | `T[]`, `IList<T>`, `IEnumerable<T>` | Element-wise subtraction of two sequences | `[10, 20, 30] - [1, 2, 3]` | `[9, 18, 27]` |
| `*` | `T[]`, `IList<T>`, `IEnumerable<T>` | Element-wise multiplication of two sequences | `[1, 2, 3] * [4, 5, 6]` | `[4, 10, 18]` |
| `/` | `T[]`, `IList<T>`, `IEnumerable<T>` | Element-wise division of two sequences | `[10, 20, 30] / [2, 4, 5]` | `[5, 5, 6]` |
| `%` | `T[]`, `IList<T>`, `IEnumerable<T>` | Element-wise modulus of two sequences | `[10, 20, 30] % [3, 6, 7]` | `[1, 2, 2]` |
| `-` (unary) | `T[]`, `IList<T>`, `IEnumerable<T>` | Negates each element | `-[1, -2, 3]` | `[-1, 2, -3]` |
| `+` (unary) | `T[]`, `IList<T>`, `IEnumerable<T>` | Unary plus on each element | `+[1, 2, 3]` | `[1, 2, 3]` |

### Scalar Arithmetic Operators

| Operator | Types | Description | Example | Result |
|----------|-------|-------------|---------|--------|
| `+` | `T[]`, `IList<T>`, `IEnumerable<T>` | Adds scalar to each element | `[1, 2, 3] + 5` | `[6, 7, 8]` |
| `-` | `T[]`, `IList<T>`, `IEnumerable<T>` | Subtracts scalar from each element | `[10, 20, 30] - 5` | `[5, 15, 25]` |
| `*` | `T[]`, `IList<T>`, `IEnumerable<T>` | Multiplies each element by scalar | `[1, 2, 3] * 5` | `[5, 10, 15]` |
| `/` | `T[]`, `IList<T>`, `IEnumerable<T>` | Divides each element by scalar | `[10, 20, 30] / 5` | `[2, 4, 6]` |
| `%` | `T[]`, `IList<T>`, `IEnumerable<T>` | Modulus of each element by scalar | `[11, 12, 13] % 5` | `[1, 2, 3]` |

### Mutating Arithmetic Operators (In-place)

| Operator | Types | Description | Example | Result |
|----------|-------|-------------|---------|--------|
| `++` | `T[]`, `IList<T>`, `ICollection<T>` | Increments each element in-place | `arr++` where `arr = [1, 2, 3]` | `[2, 3, 4]` |
| `--` | `T[]`, `IList<T>`, `ICollection<T>` | Decrements each element in-place | `arr--` where `arr = [1, 2, 3]` | `[0, 1, 2]` |
| `+=` | `T[]`, `IList<T>`, `ICollection<T>` | Adds scalar to each element in-place | `arr += 5` where `arr = [1, 2, 3]` | `[6, 7, 8]` |
| `-=` | `T[]`, `IList<T>`, `ICollection<T>` | Subtracts scalar from each element | `arr -= 5` where `arr = [10, 20]` | `[5, 15]` |
| `*=` | `T[]`, `IList<T>`, `ICollection<T>` | Multiplies each element by scalar | `arr *= 5` where `arr = [1, 2, 3]` | `[5, 10, 15]` |
| `/=` | `T[]`, `IList<T>`, `ICollection<T>` | Divides each element by scalar | `arr /= 2` where `arr = [10, 20]` | `[5, 10]` |
| `%=` | `T[]`, `IList<T>`, `ICollection<T>` | Modulus each element by scalar | `arr %= 5` where `arr = [11, 12]` | `[1, 2]` |

### Logical Operators

> Note that the `&&` and `||` operators cannot be overloaded.

| Operator | Types | Description | Example | Result |
|----------|-------|-------------|---------|--------|
| `&` | `IEnumerable<bool>`, `BitArray`, `BitVector32` | Element-wise logical AND | `[true, false, true] & [true, true, false]` | `[true, false, false]` |
| `\|` | `IEnumerable<bool>`, `BitArray`, `BitVector32` | Element-wise logical OR | `[true, false, false] \| [false, false, true]` | `[true, false, true]` |
| `^` | `IEnumerable<bool>`, `BitArray`, `BitVector32` | Element-wise logical XOR | `[true, false, true] ^ [true, true, false]` | `[false, true, true]` |
| `!` | `IEnumerable<bool>`, `BitArray`, `BitVector32` | Negates each boolean element | `![true, false, true]` | `[false, true, false]` |
| `true` | `IEnumerable<bool>`, `BitArray`, `BitVector32` | Returns true if all elements are true | `if ([true, true, true])` | `true` |
| `false` | `IEnumerable<bool>`, `BitArray`, `BitVector32` | Returns true if all elements are false | `if (![false, false, false])` | `true` |

### Bitwise Operators

| Operator | Types | Description | Example | Result |
|----------|-------|-------------|---------|--------|
| `&` | `T[]`, `IList<T>`, `IEnumerable<T>` | Element-wise bitwise AND | `[0b1100, 0b1010] & [0b1010, 0b1100]` | `[0b1000, 0b1000]` |
| `\|` | `T[]`, `IList<T>`, `IEnumerable<T>` | Element-wise bitwise OR | `[0b1100, 0b1010] \| [0b0011, 0b0101]` | `[0b1111, 0b1111]` |
| `^` | `T[]`, `IList<T>`, `IEnumerable<T>` | Element-wise bitwise XOR | `[0b1100, 0b1010] ^ [0b1010, 0b1100]` | `[0b0110, 0b0110]` |
| `~` | `T[]`, `IList<T>`, `IEnumerable<T>` | Bitwise complement of each element | `~[0b1100, 0b0011]` | `[~0b1100, ~0b0011]` |
| `<<` | `T[]`, `IList<T>`, `IEnumerable<T>` | Left shift each element by amount | `[1, 2, 3] << 2` | `[4, 8, 12]` |
| `>>` | `T[]`, `IList<T>`, `IEnumerable<T>` | Right shift each element by amount | `[16, 32, 64] >> 2` | `[4, 8, 16]` |
| `>>>` | `T[]`, `IList<T>`, `IEnumerable<T>` | Unsigned right shift each element | `[8, 16, 32] >>> 1` | `[4, 8, 16]` |

### Comparison Operators

| Operator | Types | Description | Example | Result |
|----------|-------|-------------|---------|--------|
| `==` | `IEnumerable<T>` | Compares sequences for equality | `[1, 2, 3] == [1, 2, 3]` | `true` |
| `!=` | `IEnumerable<T>` | Compares sequences for inequality | `[1, 2, 3] != [1, 2, 4]` | `true` |
| `<` | `IEnumerable<T>` | Lexicographic less than comparison | `[1, 2, 3] < [1, 2, 4]` | `true` |
| `>` | `IEnumerable<T>` | Lexicographic greater than comparison | `[1, 3] > [1, 2, 3]` | `true` |
| `<=` | `IEnumerable<T>` | Lexicographic less than or equal | `[1, 2] <= [1, 2, 3]` | `true` |
| `>=` | `IEnumerable<T>` | Lexicographic greater than or equal | `[1, 2, 3] >= [1, 2]` | `true` |

**Notes:**
- Element-wise operations stop at the length of the shorter sequence
- In-place operators modify the original array/collection/list
- `IList<T>` operators use optimized indexed access
- `ICollection<T>` operators work with non-indexed collections (e.g., `HashSet<T>`)
- Requires types implementing appropriate `System.Numerics` interfaces
- `BitArray` operations maintain minimum length between operands
- `BitVector32` works with 32-bit integer data

---

## Method Extensions Reference

### T is IFloatingPoint\<T>

| Method | Types | Description | Example | Result |
|----------|-------|-------------|---------|--------|
| `Abs()` | `T[]`, `IList<T>`, `IEnumerable<T>` | Returns absolute value of each element | `[-1.5, 2.3, -3.7].Abs()` | `[1.5, 2.3, 3.7]` |
| `Floor()` | `T[]`, `IList<T>`, `IEnumerable<T>` | Rounds each element down to nearest integer | `[1.7, 2.3, 3.9].Floor()` | `[1.0, 2.0, 3.0]` |
| `Ceiling()` | `T[]`, `IList<T>`, `IEnumerable<T>` | Rounds each element up to nearest integer | `[1.1, 2.5, 3.2].Ceiling()` | `[2.0, 3.0, 4.0]` |
| `Round()` | `T[]`, `IList<T>`, `IEnumerable<T>` | Rounds each element to nearest integer | `[1.4, 2.5, 3.6].Round()` | `[1.0, 2.0, 4.0]` |

### T is INumber\<T>

| Method | Types | Description | Example | Result |
|----------|-------|-------------|---------|--------|
| `Sum()` | `IEnumerable<T>` | Calculates sum of all elements | `[1, 2, 3, 4].Sum()` | `10` |
| `Product()` | `IEnumerable<T>` | Calculates product of all elements | `[2, 3, 4].Product()` | `24` |
| `Average()` | `IEnumerable<T>` | Calculates average of all elements | `[10, 20, 30].Average()` | `20` |
| `Abs()` | `T[]`, `IList<T>`, `IEnumerable<T>` | Returns absolute value of each element | `[-1, 2, -3].Abs()` | `[1, 2, 3]` |

---

## Potential Use Cases

The `Jacobi.ArrayOperators` library enables powerful array-based computations across various domains. Here are practical use cases:

### 1. **Scientific Computing & Data Analysis**

#### Statistical Calculations
```csharp
// Normalize data (z-score normalization)
double[] data = [10.5, 12.3, 9.8, 11.2, 13.1];
double mean = data.Average();
double stdDev = CalculateStdDev(data);
var normalized = (data - mean) / stdDev;
```

#### Vector Operations
```csharp
// Calculate dot product using element-wise multiplication
double[] vector1 = [1.0, 2.0, 3.0];
double[] vector2 = [4.0, 5.0, 6.0];
var dotProduct = (vector1 * vector2).Sum(); // 32.0
```

### 2. **Image Processing**

#### Brightness Adjustment
```csharp
// Increase brightness by 20 units across all pixels
byte[] pixels = GetImagePixels();
pixels += 20;
```

#### Image Blending
```csharp
// Blend two images with 50% opacity each
byte[] image1 = GetImage1Pixels();
byte[] image2 = GetImage2Pixels();
var blended = (image1 + image2) / 2;
```

#### Apply Masks
```csharp
// Apply binary mask to filter pixels
bool[] mask = GetMask();
byte[] pixels = GetPixels();
var filtered = mask ? pixels : default; // Using true operator
```

### 3. **Signal Processing**

#### Apply Gain/Attenuation
```csharp
// Amplify audio signal by 2x
float[] audioSamples = LoadAudioData();
audioSamples *= 2.0f;
```

#### Signal Mixing
```csharp
// Mix two audio channels
float[] leftChannel = GetLeftChannel();
float[] rightChannel = GetRightChannel();
var mixedMono = (leftChannel + rightChannel) / 2.0f;
```

### 4. **Financial Calculations**

#### Portfolio Analysis
```csharp
// Calculate daily returns
decimal[] prices = [100m, 102m, 101m, 105m];
decimal[] previousPrices = [99m, 100m, 102m, 101m];
var returns = (prices - previousPrices) / previousPrices * 100;
```

#### Risk-Weighted Assets
```csharp
// Apply risk weights to asset values
decimal[] assetValues = [1000m, 2000m, 1500m];
decimal[] riskWeights = [0.5m, 0.75m, 1.0m];
var riskWeightedAssets = assetValues * riskWeights;
```

### 5. **Game Development**

#### Bulk Transform Operations
```csharp
// Scale all enemy positions
float[] enemyPositions = [10.0f, 20.0f, 30.0f];
enemyPositions *= scaleFactor;
```

#### Damage Calculations
```csharp
// Apply armor reduction to damage values
int[] damageValues = [50, 75, 100];
float[] armorReduction = [0.8f, 0.8f, 0.8f];
var finalDamage = damageValues * armorReduction;
```

#### Batch Health Updates
```csharp
// Apply healing to multiple entities
int[] healthValues = [50, 75, 30];
healthValues += healingAmount;
```

### 6. **Machine Learning & AI**

#### Feature Scaling
```csharp
// Min-max normalization
double[] features = [100, 200, 150, 300];
double min = features.Min();
double max = features.Max();
var scaled = (features - min) / (max - min);
```

#### Activation Functions
```csharp
// Apply ReLU activation (using comparison)
double[] values = [-1.0, 2.0, -3.0, 4.0];
var activated = values > 0 ? values : 0; // Simplified concept
```

#### Gradient Descent Updates
```csharp
// Update weights
double[] weights = [0.5, 0.3, 0.8];
double learningRate = 0.01;
double[] gradients = [0.1, -0.2, 0.15];
weights -= gradients * learningRate;
```

### 7. **Physics Simulations**

#### Force Calculations
```csharp
// F = m * a
double[] masses = [10.0, 15.0, 20.0];
double[] accelerations = [2.0, 1.5, 3.0];
var forces = masses * accelerations;
```

#### Velocity Updates
```csharp
// Update velocities with acceleration
double[] velocities = [5.0, 10.0, 15.0];
double deltaTime = 0.016; // ~60 FPS
velocities += accelerations * deltaTime;
```

### 8. **Bitwise Operations for Flags/Permissions**

#### Combine Permission Sets
```csharp
// Merge permission flags
int[] userPermissions = [0b0001, 0b0010, 0b0100];
int[] rolePermissions = [0b0010, 0b0100, 0b1000];
var combinedPermissions = userPermissions | rolePermissions;
```

#### Apply Masks
```csharp
// Extract specific bits
int[] values = [0b11111111, 0b10101010, 0b11110000];
int mask = 0b00001111;
var masked = values & mask;
```

### 9. **Data Validation & Filtering**

#### Boolean Mask Operations
```csharp
// Check if all values meet criteria
bool[] validations = CheckDataValidity();
if (validations) // Uses true operator
{
    Console.WriteLine("All data is valid!");
}
```

#### Logical Combinations
```csharp
// Combine multiple validation results
bool[] check1 = [true, false, true];
bool[] check2 = [true, true, false];
var allPassed = check1 & check2; // [true, false, false]
```

### 10. **Time Series Analysis**

#### Moving Averages
```csharp
// Simple moving average calculation
double[] window1 = GetWindow(data, 0, 5);
double[] window2 = GetWindow(data, 1, 5);
var difference = window2 - window1;
```

#### Percentage Changes
```csharp
// Calculate period-over-period changes
decimal[] currentPeriod = [100m, 110m, 105m];
decimal[] previousPeriod = [95m, 105m, 100m];
var percentChange = ((currentPeriod - previousPeriod) / previousPeriod) * 100;
```

---

## Future Enhancements

- Create the return type based on the (first) parameter type.
- Implement other Math functions.

Implement support for types:

- `Span<T>`
- `ReadOnlySpan<T>`
- `IReadOnlyList<T>`
- `ArraySegment<T>`
- `ImmutableArray<T>`
- `ImmutableList<T>`


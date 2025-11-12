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
| `|` | Element-wise logical OR | `[true, false, false] | [false, false, true]` | `[true, false, true]` |
| `!` | Negates each boolean element | `![true, false, true]` | `[false, true, false]` |
| `true` | Returns true if all elements are true | `if ([true, true, true])` | `true` |
| `false` | Returns true if all elements are false | `if (![false, false, false])` | `true` |

### IEnumerable\<T> Bitwise Operators

| Operator | Description | Example | Result |
|----------|-------------|---------|--------|
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

**Notes:**
- Element-wise operations stop at the length of the shorter sequence
- In-place operators modify the original array/collection
- Requires types implementing appropriate `System.Numerics` interfaces

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

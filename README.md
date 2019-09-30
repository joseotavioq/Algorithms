# Algorithms

My study about algorithms.

## Benchmark Results

### Reverse String - [File](src/Algorithms/ArraysAndStrings/ReverseString.cs)

|          Method |      myEntireString |      Mean |      Error |     StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------- |-------------------- |----------:|-----------:|-----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|        FirstTry | Learning Algorithms |  69.60 ns |  1.4121 ns |  1.3209 ns |  70.38 ns |  1.00 |    0.00 | 0.0418 |     - |     - |     176 B |
|   InJustOneLine | Learning Algorithms | 498.49 ns |  2.9417 ns |  2.2967 ns | 498.74 ns |  7.19 |    0.15 | 0.2012 |     - |     - |     848 B |
|  InJustOneLine2 | Learning Algorithms | 460.00 ns | 12.9832 ns | 35.5412 ns | 443.08 ns |  7.20 |    0.54 | 0.1020 |     - |     - |     432 B |
|            Fast | Learning Algorithms |  40.32 ns |  1.8770 ns |  5.3856 ns |  38.60 ns |  0.55 |    0.05 | 0.0305 |     - |     - |     128 B |
| Vafzamora_Fast1 | Learning Algorithms |  45.50 ns |  0.5212 ns |  0.4875 ns |  45.55 ns |  0.65 |    0.01 | 0.0305 |     - |     - |     128 B |
| Vafzamora_Fast2 | Learning Algorithms |  41.28 ns |  1.3377 ns |  3.8382 ns |  39.22 ns |  0.64 |    0.07 | 0.0305 |     - |     - |     128 B |

### Merge Sorted Array - [File](src/Algorithms/ArraysAndStrings/MergeSortedArray.cs)

|        Method | firstArray | secondArray |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------- |----------- |------------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|      FirstTry |   Array[4] |    Array[8] | 24.96 ns | 0.5753 ns | 0.5381 ns |  1.00 |    0.00 | 0.0171 |     - |     - |      72 B |
|     SecondTry |   Array[4] |    Array[8] | 25.11 ns | 0.9701 ns | 2.7202 ns |  0.96 |    0.07 | 0.0171 |     - |     - |      72 B |
| MyTry_VZamora |   Array[4] |    Array[8] | 35.78 ns | 0.8161 ns | 1.0612 ns |  1.45 |    0.06 | 0.0171 |     - |     - |      72 B |

### Two Sum - [File](src/Algorithms/ArraysAndStrings/TwoSum.cs)

|    Method |     nums | target |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |------- |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|  FirstTry | Array[6] |      9 |  12.86 ns | 0.3357 ns | 0.7155 ns |  1.00 |    0.00 | 0.0076 |     - |     - |      32 B |
| SecondTry | Array[6] |      9 |  13.79 ns | 0.3454 ns | 0.3392 ns |  1.03 |    0.05 | 0.0076 |     - |     - |      32 B |
|  ThirdTry | Array[6] |      9 | 111.18 ns | 2.2023 ns | 1.9523 ns |  8.34 |    0.41 | 0.0533 |     - |     - |     224 B |

### Is Unique - [File](src/Algorithms/ArraysAndStrings/IsUnique.cs)

|    Method |    value |      Mean |     Error |     StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |----------:|----------:|-----------:|------:|-------:|------:|------:|----------:|
|  FirstTry | abcdefgh | 335.90 ns | 6.7666 ns | 13.0370 ns |  1.00 | 0.1578 |     - |     - |     664 B |
| SecondTry | abcdefgh |  17.65 ns | 0.3643 ns |  0.3408 ns |  0.05 | 0.0362 |     - |     - |     152 B |

### Check Permutation - [File](src/Algorithms/ArraysAndStrings/CheckPermutation.cs)

|   Method |    first |   second |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |--------- |--------- |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
| FirstTry | abcdefgh | fdceagbh | 48.38 ns | 0.9950 ns | 0.9307 ns |  1.00 | 0.1277 |     - |     - |     536 B |

### URLify - [File](src/Algorithms/ArraysAndStrings/URLify.cs)

|   Method |             value |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |------------------ |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
| FirstTry | Mr John Smith     | 39.30 ns | 0.8481 ns | 0.8710 ns |  1.00 | 0.0305 |     - |     - |     128 B |
# Benchmark Results For Arrays And Strings

## Reverse String - [File](src/Algorithms/ArraysAndStrings/ReverseString.cs)

|            Method |      myEntireString |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------ |-------------------- |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|          FirstTry | Learning Algorithms |   197.34 ns |  5.404 ns | 14.974 ns |  1.00 |    0.00 | 0.0420 |     - |     - |     176 B |
|     InJustOneLine | Learning Algorithms |   453.47 ns |  9.021 ns | 16.944 ns |  2.35 |    0.37 | 0.1659 |     - |     - |     696 B |
|    InJustOneLine2 | Learning Algorithms | 1,042.65 ns | 20.867 ns | 44.468 ns |  5.37 |    0.86 | 0.1030 |     - |     - |     432 B |
|              Fast | Learning Algorithms |    30.54 ns |  0.517 ns |  0.741 ns |  0.16 |    0.03 | 0.0306 |     - |     - |     128 B |
|   Vafzamora_Fast1 | Learning Algorithms |    32.13 ns |  0.699 ns |  0.718 ns |  0.18 |    0.04 | 0.0306 |     - |     - |     128 B |
|   Vafzamora_Fast2 | Learning Algorithms |    35.05 ns |  0.764 ns |  0.909 ns |  0.19 |    0.04 | 0.0306 |     - |     - |     128 B |
| Vafzamora_Obvious | Learning Algorithms |    33.12 ns |  0.697 ns |  0.745 ns |  0.18 |    0.04 | 0.0306 |     - |     - |     128 B |

## Reverse String Preserving Spaces - [File](src/Algorithms/ArraysAndStrings/ReverseStringPreservingSpaces.cs)

|    Method |                input |      Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|  FirstTry | A BB (...)FFFFF [26] | 598.69 ns | 11.477 ns | 13.662 ns |  1.00 | 0.1287 |     - |     - |     544 B |
| SecondTry | A BB (...)FFFFF [26] | 146.45 ns |  2.743 ns |  2.432 ns |  0.24 | 0.0494 |     - |     - |     208 B |
|  ThirdTry | A BB (...)FFFFF [26] |  53.12 ns |  1.160 ns |  2.178 ns |  0.09 | 0.0380 |     - |     - |     160 B |

## Merge Sorted Array - [File](src/Algorithms/ArraysAndStrings/MergeSortedArray.cs)

|        Method | firstArray | secondArray |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------- |----------- |------------ |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|      FirstTry |   Array[4] |    Array[8] | 24.96 ns | 0.5753 ns | 0.5381 ns |  1.00 |    0.00 | 0.0171 |     - |     - |      72 B |
|     SecondTry |   Array[4] |    Array[8] | 25.11 ns | 0.9701 ns | 2.7202 ns |  0.96 |    0.07 | 0.0171 |     - |     - |      72 B |
| MyTry_VZamora |   Array[4] |    Array[8] | 35.78 ns | 0.8161 ns | 1.0612 ns |  1.45 |    0.06 | 0.0171 |     - |     - |      72 B |

## Two Sum - [File](src/Algorithms/ArraysAndStrings/TwoSum.cs)

|    Method |     nums | target |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |------- |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|  FirstTry | Array[6] |      9 |  12.86 ns | 0.3357 ns | 0.7155 ns |  1.00 |    0.00 | 0.0076 |     - |     - |      32 B |
| SecondTry | Array[6] |      9 |  13.79 ns | 0.3454 ns | 0.3392 ns |  1.03 |    0.05 | 0.0076 |     - |     - |      32 B |
|  ThirdTry | Array[6] |      9 | 111.18 ns | 2.2023 ns | 1.9523 ns |  8.34 |    0.41 | 0.0533 |     - |     - |     224 B |

## Is Unique - [File](src/Algorithms/ArraysAndStrings/IsUnique.cs)

|         Method |    value |      Mean |     Error |     StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |--------- |----------:|----------:|-----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|       FirstTry | abcdefgh | 429.64 ns | 80.473 ns | 237.275 ns | 277.11 ns |  1.00 |    0.00 | 0.1583 |     - |     - |     664 B |
|      SecondTry | abcdefgh |  43.51 ns |  0.910 ns |   1.012 ns |  43.65 ns |  0.06 |    0.00 | 0.0363 |     - |     - |     152 B |
| MyTry_Vafzmora | abcdefgh |  77.70 ns |  4.254 ns |  12.136 ns |  81.77 ns |  0.24 |    0.10 | 0.0172 |     - |     - |      72 B |

## Check Permutation - [File](src/Algorithms/ArraysAndStrings/CheckPermutation.cs)

|             Method |    first |   second |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |--------- |--------- |---------:|----------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|           FirstTry | abcdefgh | fdceagbh | 72.50 ns | 14.088 ns | 41.540 ns | 39.85 ns |  1.00 |    0.00 | 0.1280 |     - |     - |     536 B |
| SbyteTry_Vafzamora | abcdefgh | fdceagbh | 65.83 ns |  1.384 ns |  3.342 ns | 66.08 ns |  1.14 |    0.62 | 0.0362 |     - |     - |     152 B |

## URLify - [File](src/Algorithms/ArraysAndStrings/URLify.cs)

|   Method |             value |     Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |------------------ |---------:|----------:|----------:|------:|-------:|------:|------:|----------:|
| FirstTry | Mr John Smith     | 39.30 ns | 0.8481 ns | 0.8710 ns |  1.00 | 0.0305 |     - |     - |     128 B |

## One Away - [File](src/Algorithms/ArraysAndStrings/OneAway.cs)

|   Method | first | second |       Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |------ |------- |-----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
| FirstTry |  pale |    bae | 151.289 ns | 3.0154 ns | 2.9615 ns |  1.00 | 0.1276 |     - |     - |     536 B |
|     Fast |  pale |    bae |   3.833 ns | 0.0825 ns | 0.0732 ns |  0.03 |      - |     - |     - |         - |

## String Compression - [File](src/Algorithms/ArraysAndStrings/StringCompression.cs)

|    Method |       value |     Mean |     Error |   StdDev |   Median | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------------ |---------:|----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|  FirstTry | aabcccccaaa | 616.8 ns | 11.585 ns | 9.674 ns | 616.2 ns |  1.00 | 0.1402 |     - |     - |     592 B |
| SecondTry | aabcccccaaa | 155.0 ns |  3.044 ns | 3.738 ns | 156.4 ns |  0.25 | 0.0341 |     - |     - |     144 B |
|  ThirdTry | aabcccccaaa | 162.9 ns |  3.297 ns | 6.954 ns | 160.1 ns |  0.28 | 0.0341 |     - |     - |     144 B |
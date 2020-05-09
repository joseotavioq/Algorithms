# Benchmark Results For Sorting

## Bubble Sort - [File](src/Algorithms/Sorting/BubbleSort.cs)

|    Method | listOfNumbers |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |-------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
|  FirstTry |      Int32[8] | 74.639 ns | 1.1143 ns | 1.2385 ns |  1.00 |     - |     - |     - |         - |
| SecondTry |      Int32[8] | 28.996 ns | 0.5980 ns | 0.9656 ns |  0.39 |     - |     - |     - |         - |
|  ThirdTry |      Int32[8] |  5.237 ns | 0.1086 ns | 0.0963 ns |  0.07 |     - |     - |     - |         - |

## Selection Sort - [File](src/Algorithms/Sorting/SelectionSort.cs)

|   Method | listOfNumbers |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |-------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
| FirstTry |      Int32[8] | 31.69 ns | 0.786 ns | 0.905 ns |  1.00 |     - |     - |     - |         - |

## Insertion Sort - [File](src/Algorithms/Sorting/InsertionSort.cs)
|    Method | listOfNumbers |     Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |-------------- |---------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|  FirstTry |      Int32[8] | 5.115 ns | 0.0954 ns | 0.0797 ns |  1.00 |    0.00 |     - |     - |     - |         - |
| SecondTry |      Int32[8] | 5.623 ns | 0.1761 ns | 0.1648 ns |  1.10 |    0.04 |     - |     - |     - |         - |
|  ThirdTry |      Int32[8] | 6.395 ns | 0.0709 ns | 0.0592 ns |  1.25 |    0.02 |     - |     - |     - |         - |

## Merge Sort - [File](src/Algorithms/Sorting/MergeSort.cs)

|    Method | listOfNumbers |      Mean |     Error |     StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |-------------- |----------:|----------:|-----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|  FirstTry |      Int32[8] | 353.23 ns | 58.534 ns | 172.588 ns | 268.54 ns |  1.00 |    0.00 | 0.1740 |     - |     - |     728 B |
| SecondTry |      Int32[8] |  93.57 ns |  1.864 ns |   1.831 ns |  93.43 ns |  0.42 |    0.07 | 0.0134 |     - |     - |      56 B |

## Quick Sort - [File](src/Algorithms/Sorting/QuickSort.cs)

|   Method | listOfNumbers |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |-------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
| FirstTry |      Int32[8] | 162.6 ns | 26.91 ns | 79.36 ns |  1.00 |     - |     - |     - |         - |
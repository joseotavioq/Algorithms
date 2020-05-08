# Benchmark Results For Sorting

## Bubble Sort - [File](src/Algorithms/Sorting/BubbleSort.cs)

|    Method | listOfNumbers |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |-------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|  FirstTry |      Array[5] | 27.773 ns | 0.6516 ns | 1.2862 ns |  1.00 |    0.00 |     - |     - |     - |         - |
| SecondTry |      Array[5] | 14.832 ns | 0.3841 ns | 0.4573 ns |  0.52 |    0.03 |     - |     - |     - |         - |
|  ThirdTry |      Array[5] |  4.935 ns | 0.1981 ns | 0.3955 ns |  0.18 |    0.02 |     - |     - |     - |         - |

## Selection Sort - [File](src/Algorithms/Sorting/SelectionSort.cs)

|   Method | listOfNumbers |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |-------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
| FirstTry |      Array[5] | 19.11 ns | 0.651 ns | 0.609 ns |  1.00 |     - |     - |     - |         - |

## Insertion Sort - [File](src/Algorithms/Sorting/InsertionSort.cs)

|    Method | listOfNumbers |     Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |-------------- |---------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|  FirstTry |      Int32[8] | 5.361 ns | 0.1252 ns | 0.1537 ns |  1.00 |    0.00 |     - |     - |     - |         - |
| SecondTry |      Int32[8] | 5.655 ns | 0.1264 ns | 0.1121 ns |  1.05 |    0.04 |     - |     - |     - |         - |
|  ThirdTry |      Int32[8] | 5.895 ns | 0.1750 ns | 0.1719 ns |  1.10 |    0.05 |     - |     - |     - |         - |

## Merge Sort - [File](src/Algorithms/Sorting/MergeSort.cs)

|    Method | listOfNumbers |      Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |-------------- |----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|  FirstTry |      Int32[5] | 106.97 ns | 2.199 ns | 4.341 ns |  1.00 | 0.0994 |     - |     - |     416 B |
| SecondTry |      Int32[5] |  50.67 ns | 0.534 ns | 0.417 ns |  0.46 | 0.0114 |     - |     - |      48 B |
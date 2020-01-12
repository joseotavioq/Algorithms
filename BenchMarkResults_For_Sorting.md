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
|  FirstTry |      Array[5] | 6.053 ns | 0.2237 ns | 0.3136 ns |  1.00 |    0.00 |     - |     - |     - |         - |
| SecondTry |      Array[5] | 6.286 ns | 0.2091 ns | 0.2324 ns |  1.02 |    0.06 |     - |     - |     - |         - |

## Merge Sort - [File](src/Algorithms/Sorting/MergeSort.cs)

|   Method | listOfNumbers |     Mean |   Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |-------------- |---------:|--------:|---------:|------:|-------:|------:|------:|----------:|
| FirstTry |      Array[5] | 194.5 ns | 4.94 ns | 14.01 ns |  1.00 | 0.0989 |     - |     - |     416 B |
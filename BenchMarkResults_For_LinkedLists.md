# Benchmark Results For LinkedLists

## Remove Duplicates - [File](src/Algorithms/LinkedLists/RemoveDups.cs)

|    Method |                 head |       Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|  FirstTry | Algor(...)nt32] [43] | 176.959 ns | 3.6214 ns | 3.5567 ns |  1.00 | 0.0801 |     - |     - |     336 B |
| SecondTry | Algor(...)nt32] [43] |   7.789 ns | 0.2100 ns | 0.1964 ns |  0.04 |      - |     - |     - |         - |

## Reverse - [File](src/Algorithms/LinkedLists/Reverse.cs)

|    Method |         myLinkedList |       Mean |      Error |     StdDev |  Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |-----------:|-----------:|-----------:|-------:|--------:|------:|------:|------:|----------:|
|  FirstTry | Algor(...)nt32] [51] |   2.138 us |  0.0265 us |  0.0235 us |   1.00 |    0.00 |     - |     - |     - |         - |
| SecondTry | Algor(...)nt32] [51] | 597.664 us | 11.7067 us | 23.1079 us | 275.25 |    7.75 |     - |     - |     - |         - |

## Sum Lists - [File](src/Algorithms/LinkedLists/SumLists.cs)

|   Method |                first |               second |     Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |--------------------- |--------------------- |---------:|--------:|--------:|------:|-------:|------:|------:|----------:|
| FirstTry | Algor(...)nt32] [51] | Algor(...)nt32] [51] | 442.5 ns | 7.94 ns | 7.43 ns |  1.00 | 0.0305 |     - |     - |     128 B |

## Return Kth to Last - [File](src/Algorithms/LinkedLists/ReturnKthToLast.cs)

|    Method |                 head | k |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |-- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
|  FirstTry | Algor(...)nt32] [43] | 3 |  4.674 ns | 0.1621 ns | 0.2219 ns |  1.00 |    0.00 |     - |     - |     - |         - |
| SecondTry | Algor(...)nt32] [43] | 3 | 16.453 ns | 0.3955 ns | 1.0556 ns |  3.53 |    0.27 |     - |     - |     - |         - |
|  ThirdTry | Algor(...)nt32] [43] | 3 |  2.784 ns | 0.1266 ns | 0.1856 ns |  0.60 |    0.03 |     - |     - |     - |         - |
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

|    Method |                 head | k |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------------------- |-- |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|  FirstTry | Algor(...)nt32] [43] | 3 |  4.445 ns | 0.1361 ns | 0.1273 ns |  1.00 |    0.00 |      - |     - |     - |         - |
| SecondTry | Algor(...)nt32] [43] | 3 | 61.505 ns | 1.2938 ns | 1.4381 ns | 13.86 |    0.51 | 0.0421 |     - |     - |     176 B |
|  ThirdTry | Algor(...)nt32] [43] | 3 | 14.031 ns | 0.1111 ns | 0.0985 ns |  3.16 |    0.10 |      - |     - |     - |         - |
| FourthTry | Algor(...)nt32] [43] | 3 |  2.750 ns | 0.1190 ns | 0.1055 ns |  0.62 |    0.03 |      - |     - |     - |         - |
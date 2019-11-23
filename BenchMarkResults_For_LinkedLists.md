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
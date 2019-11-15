# Benchmark Results For HashTables

## Reverse String - [File](src/Algorithms/HashTables/RecurringNumber.cs)

|    Method |   numbers |       Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |---------- |-----------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|  FirstTry | Array[26] | 179.892 ns |  3.7775 ns |  5.0428 ns |  1.00 |    0.00 |      - |     - |     - |         - |
| SecondTry | Array[26] | 592.372 ns | 12.0455 ns | 33.5780 ns |  3.40 |    0.23 | 0.1392 |     - |     - |     584 B |
|  FirstTry |  Array[7] |   3.534 ns |  0.1096 ns |  0.2311 ns |  0.02 |    0.00 |      - |     - |     - |         - |
| SecondTry |  Array[7] | 145.096 ns |  3.0072 ns |  6.4086 ns |  0.80 |    0.04 | 0.0551 |     - |     - |     232 B |
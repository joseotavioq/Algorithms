# Benchmark Results For HashTables

## Reverse String - [File](src/Algorithms/HashTables/RecurringNumber.cs)

|    Method |  numbers |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--------- |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|  FirstTry | Array[7] |   3.914 ns | 0.1145 ns | 0.1071 ns |  1.00 |    0.00 |      - |     - |     - |         - |
| SecondTry | Array[7] | 215.972 ns | 2.7670 ns | 2.1603 ns | 54.97 |    1.50 | 0.0801 |     - |     - |     336 B |
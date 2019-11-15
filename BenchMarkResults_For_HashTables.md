# Benchmark Results For HashTables

## Reverse String - [File](src/Algorithms/HashTables/RecurringNumber.cs)

|    Method |      numbers |              Mean |           Error |            StdDev | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|---------- |------------- |------------------:|----------------:|------------------:|------:|--------:|--------:|--------:|----------:|
|  FirstTry | Array[10000] | 31,755,989.638 ns | 652,708.0799 ns | 1,872,741.8355 ns | 1.000 |       - |       - |       - |         - |
| SecondTry | Array[10000] |    352,742.325 ns |   6,608.0421 ns |     6,489.9809 ns | 0.010 | 38.0859 | 38.0859 | 38.0859 |  161768 B |
|  FirstTry |    Array[26] |        175.465 ns |       4.4734 ns |         6.1233 ns | 0.000 |       - |       - |       - |         - |
| SecondTry |    Array[26] |        550.495 ns |       8.9029 ns |         8.3277 ns | 0.000 |  0.1392 |       - |       - |     584 B |
|  FirstTry |     Array[7] |          3.233 ns |       0.0640 ns |         0.0599 ns | 0.000 |       - |       - |       - |         - |
| SecondTry |     Array[7] |        128.089 ns |       2.1868 ns |         2.0455 ns | 0.000 |  0.0551 |       - |       - |     232 B |
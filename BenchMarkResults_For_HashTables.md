# Benchmark Results For HashTables

## Reverse String - [File](src/Algorithms/HashTables/RecurringNumber.cs)

|    Method |      numbers |              Mean |             Error |            StdDev |            Median | Ratio |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|---------- |------------- |------------------:|------------------:|------------------:|------------------:|------:|--------:|--------:|--------:|----------:|
|  FirstTry | Array[10000] | 47,069,875.000 ns | 1,509,135.7611 ns | 1,737,922.9867 ns | 46,368,690.909 ns | 1.000 |       - |       - |       - |         - |
| SecondTry | Array[10000] |    393,621.497 ns |     6,850.2401 ns |     5,348.2169 ns |    393,096.606 ns | 0.008 | 38.0859 | 38.0859 | 38.0859 |  161768 B |
|  FirstTry |    Array[26] |         22.952 ns |         0.4586 ns |         0.8613 ns |         22.791 ns | 0.000 |       - |       - |       - |         - |
| SecondTry |    Array[26] |        602.944 ns |        12.0506 ns |        11.2722 ns |        605.062 ns | 0.000 |  0.1392 |       - |       - |     584 B |
|  FirstTry |     Array[7] |          4.574 ns |         0.2679 ns |         0.7288 ns |          4.583 ns | 0.000 |       - |       - |       - |         - |
| SecondTry |     Array[7] |        162.927 ns |         3.3164 ns |         9.1896 ns |        159.547 ns | 0.000 |  0.0551 |       - |       - |     232 B |
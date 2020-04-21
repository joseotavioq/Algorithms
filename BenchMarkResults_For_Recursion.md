# Benchmark Results For Recursion

## Factorial - [File](src/Algorithms/Recursion/Factorial.cs)

|    Method |  n |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--- |----------:|----------:|----------:|------:|------:|------:|----------:|
| Recursive | 10 | 20.351 ns | 0.2962 ns | 0.2473 ns |     - |     - |     - |         - |
| Iterative | 10 |  2.965 ns | 0.0747 ns | 0.0662 ns |     - |     - |     - |         - |

## Fibonacci - [File](src/Algorithms/Recursion/Fibonacci.cs)

|                           Method | index |             Mean |           Error |          StdDev |           Median | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------------------- |------ |-----------------:|----------------:|----------------:|-----------------:|------:|-------:|------:|------:|----------:|
|                        Recursive |    30 | 4,431,004.420 ns | 144,289.3807 ns | 248,892.0924 ns | 4,318,930.078 ns | 1.000 |      - |     - |     - |         - |
|                        Iterative |    30 |       162.181 ns |       3.1078 ns |       3.5789 ns |       159.864 ns | 0.000 | 0.0880 |     - |     - |     368 B |
| IterativeWithoutMemoryAllocation |    30 |         9.168 ns |       0.1949 ns |       0.1823 ns |         9.131 ns | 0.000 |      - |     - |     - |         - |
# Benchmark Results For Recursion

## Factorial - [File](src/Algorithms/Recursion/Factorial.cs)

|    Method |  n |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--- |----------:|----------:|----------:|------:|------:|------:|----------:|
| Recursive | 10 | 20.351 ns | 0.2962 ns | 0.2473 ns |     - |     - |     - |         - |
| Iterative | 10 |  2.965 ns | 0.0747 ns | 0.0662 ns |     - |     - |     - |         - |

## Fibonacci - [File](src/Algorithms/Recursion/Fibonacci.cs)

|                           Method | index |             Mean |          Error |         StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------------------- |------ |-----------------:|---------------:|---------------:|------:|-------:|------:|------:|----------:|
|                        Recursive |    30 | 4,699,240.599 ns | 43,060.4798 ns | 40,278.7995 ns | 1.000 |      - |     - |     - |      11 B |
|         RecursiveWithMemoization |    30 |       248.752 ns |      4.6236 ns |      4.0987 ns | 0.000 | 0.0362 |     - |     - |     152 B |
|                        Iterative |    30 |       155.511 ns |      2.5202 ns |      2.1045 ns | 0.000 | 0.0880 |     - |     - |     368 B |
| IterativeWithoutMemoryAllocation |    30 |         9.065 ns |      0.1850 ns |      0.1640 ns | 0.000 |      - |     - |     - |         - |
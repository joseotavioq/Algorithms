# Benchmark Results For Recursion

## Factorial - [File](src/Algorithms/Recursion/Factorial.cs)

|    Method |  n |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |--- |----------:|----------:|----------:|------:|------:|------:|----------:|
| Recursive | 10 | 20.351 ns | 0.2962 ns | 0.2473 ns |     - |     - |     - |         - |
| Iterative | 10 |  2.965 ns | 0.0747 ns | 0.0662 ns |     - |     - |     - |         - |

## Fibonacci - [File](src/Algorithms/Recursion/Fibonacci.cs)

|    Method | index |           Mean |         Error |        StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------ |---------------:|--------------:|--------------:|-------:|------:|------:|----------:|
| Recursive |    30 | 6,840,479.6 ns | 134,914.24 ns | 335,983.26 ns |      - |     - |     - |         - |
| Iterative |    30 |       266.5 ns |       6.19 ns |      10.68 ns | 0.0892 |     - |     - |     376 B |
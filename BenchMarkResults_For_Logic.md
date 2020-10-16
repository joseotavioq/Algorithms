# Benchmark Results For Logic

## Number Swapper - [File](src/Algorithms/Logic/NumberSwapper.cs)

|    Method |     x |    y |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |------ |----- |---------:|----------:|----------:|---------:|------:|--------:|------:|------:|------:|----------:|
|  FirstTry | 15000 | 8250 | 5.251 ns | 0.2641 ns | 0.7663 ns | 5.135 ns |  1.00 |    0.00 |     - |     - |     - |         - |
| SecondTry | 15000 | 8250 | 5.406 ns | 0.1845 ns | 0.5233 ns | 5.165 ns |  1.05 |    0.19 |     - |     - |     - |         - |
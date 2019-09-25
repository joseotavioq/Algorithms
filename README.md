# Algorithms

My study about algorithms.

## Benchmark Results

|                       Method |      myEntireString |      Mean |      Error |     StdDev |    Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |-------------------- |----------:|-----------:|-----------:|----------:|-------:|------:|------:|----------:|
|                ReverseString | Learning Algorithms |  83.17 ns |  2.0771 ns |  5.9930 ns |  81.76 ns | 0.0418 |     - |     - |     176 B |
|        ReverseString_OneLine | Learning Algorithms | 620.28 ns | 17.2921 ns | 50.4418 ns | 602.57 ns | 0.2012 |     - |     - |     848 B |
|       ReverseString_OneLine1 | Learning Algorithms | 505.86 ns |  9.8447 ns |  8.7271 ns | 504.58 ns | 0.1020 |     - |     - |     432 B |
|           ReverseString_Fast | Learning Algorithms |  38.10 ns |  0.6418 ns |  0.5690 ns |  38.00 ns | 0.0305 |     - |     - |     128 B |
| ReverseString_FastVafzamora1 | Learning Algorithms |  40.01 ns |  0.5109 ns |  0.4529 ns |  40.03 ns | 0.0305 |     - |     - |     128 B |
| ReverseString_FastVafzamora2 | Learning Algorithms |  34.47 ns |  0.7807 ns |  1.7300 ns |  33.92 ns | 0.0305 |     - |     - |     128 B |
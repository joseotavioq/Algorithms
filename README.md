# Algorithms

My study about algorithms.

## Benchmark Results

#Reverse String

|          Method |      myEntireString |      Mean |      Error |     StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------- |-------------------- |----------:|-----------:|-----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|        FirstTry | Learning Algorithms |  69.60 ns |  1.4121 ns |  1.3209 ns |  70.38 ns |  1.00 |    0.00 | 0.0418 |     - |     - |     176 B |
|   InJustOneLine | Learning Algorithms | 498.49 ns |  2.9417 ns |  2.2967 ns | 498.74 ns |  7.19 |    0.15 | 0.2012 |     - |     - |     848 B |
|  InJustOneLine2 | Learning Algorithms | 460.00 ns | 12.9832 ns | 35.5412 ns | 443.08 ns |  7.20 |    0.54 | 0.1020 |     - |     - |     432 B |
|            Fast | Learning Algorithms |  40.32 ns |  1.8770 ns |  5.3856 ns |  38.60 ns |  0.55 |    0.05 | 0.0305 |     - |     - |     128 B |
| Vafzamora_Fast1 | Learning Algorithms |  45.50 ns |  0.5212 ns |  0.4875 ns |  45.55 ns |  0.65 |    0.01 | 0.0305 |     - |     - |     128 B |
| Vafzamora_Fast2 | Learning Algorithms |  41.28 ns |  1.3377 ns |  3.8382 ns |  39.22 ns |  0.64 |    0.07 | 0.0305 |     - |     - |     128 B |

#Merge Sorted Array

|    Method | firstArray | secondArray |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------- |----------- |------------ |---------:|----------:|----------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|  FirstTry |   Array[4] |    Array[3] | 17.03 ns | 0.3484 ns | 0.3259 ns | 17.04 ns |  1.00 |    0.00 | 0.0133 |     - |     - |      56 B |
| SecondTry |   Array[4] |    Array[3] | 16.59 ns | 0.4111 ns | 0.7201 ns | 16.27 ns |  1.00 |    0.06 | 0.0133 |     - |     - |      56 B |
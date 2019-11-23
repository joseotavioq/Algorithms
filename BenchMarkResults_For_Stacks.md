# Benchmark Results For Stacks

## Stack with Linked List vs Stack with Array - [File](src/Algorithms/Stacks/Stacks.cs)

|     Method |      Mean |     Error |    StdDev | Ratio |   Gen 0 |   Gen 1 | Gen 2 | Allocated |
|----------- |----------:|----------:|----------:|------:|--------:|--------:|------:|----------:|
| LinkedList | 169.11 us | 1.9980 us | 1.7712 us |  1.00 | 71.0449 | 11.9629 |     - | 312.54 KB |
|      Array |  60.13 us | 0.9518 us | 0.8903 us |  0.36 | 19.5923 |  0.0610 |     - |  80.25 KB |
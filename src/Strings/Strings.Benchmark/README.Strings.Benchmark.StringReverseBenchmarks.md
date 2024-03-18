```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.87 μs** | **202.77 μs** | **11.115 μs** |  **10.519 μs** |  **10.389 μs** |  **29.70 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  79.20 μs | 241.11 μs | 13.216 μs |  74.775 μs |  68.763 μs |  94.06 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.21 μs | 388.22 μs | 21.280 μs |  26.689 μs |  25.176 μs |  62.77 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  21.10 μs | 196.47 μs | 10.769 μs |  15.078 μs |  14.687 μs |  33.53 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.14 μs | 222.78 μs | 12.211 μs |  45.586 μs |  44.614 μs |  66.23 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.96 μs | 154.55 μs |  8.472 μs |   9.528 μs |   8.617 μs |  23.72 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.22 μs | 279.66 μs | 15.329 μs |  28.903 μs |  27.851 μs |  54.91 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.83 μs** | **373.44 μs** | **20.470 μs** |  **13.456 μs** |  **12.573 μs** |  **48.46 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 303.61 μs | 284.90 μs | 15.616 μs | 300.675 μs | 289.665 μs | 320.48 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 186.32 μs |  51.77 μs |  2.838 μs | 186.553 μs | 183.375 μs | 189.04 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.30 μs | 226.60 μs | 12.421 μs |  60.593 μs |  50.815 μs |  75.48 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 243.37 μs | 504.45 μs | 27.651 μs | 240.727 μs | 217.135 μs | 272.25 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  20.31 μs | 296.13 μs | 16.232 μs |  11.121 μs |  10.761 μs |  39.05 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.54 μs | 575.25 μs | 31.531 μs |  68.868 μs |  67.815 μs | 122.95 μs |  68.69 KB |

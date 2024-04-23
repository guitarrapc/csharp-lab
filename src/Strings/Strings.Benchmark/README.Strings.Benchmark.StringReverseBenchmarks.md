```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median    | Min       | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.00 μs** | **220.87 μs** | **12.107 μs** |  **11.26 μs** |  **10.77 μs** |  **31.98 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 115.04 μs | 277.06 μs | 15.186 μs | 113.50 μs | 100.68 μs | 130.94 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  55.10 μs | 442.99 μs | 24.282 μs |  41.59 μs |  40.59 μs |  83.14 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  22.44 μs | 195.51 μs | 10.717 μs |  20.01 μs |  13.14 μs |  34.16 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  64.02 μs | 282.07 μs | 15.461 μs |  61.21 μs |  50.15 μs |  80.69 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  17.30 μs | 210.14 μs | 11.518 μs |  10.85 μs |  10.45 μs |  30.60 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  54.99 μs | 331.75 μs | 18.184 μs |  45.50 μs |  43.51 μs |  75.95 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.72 μs** | **359.95 μs** | **19.730 μs** |  **13.40 μs** |  **13.24 μs** |  **47.50 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 482.14 μs | 345.96 μs | 18.963 μs | 478.03 μs | 465.57 μs | 502.82 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 210.93 μs |  28.71 μs |  1.574 μs | 210.77 μs | 209.44 μs | 212.57 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  71.38 μs | 258.48 μs | 14.168 μs |  68.11 μs |  59.14 μs |  86.90 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 282.65 μs | 497.37 μs | 27.262 μs | 269.14 μs | 264.78 μs | 314.03 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  20.79 μs | 280.96 μs | 15.401 μs |  12.20 μs |  11.60 μs |  38.57 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 102.97 μs | 642.98 μs | 35.244 μs |  82.69 μs |  82.56 μs | 143.67 μs |  68.69 KB |

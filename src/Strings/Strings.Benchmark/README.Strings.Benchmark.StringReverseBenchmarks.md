```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.53 μs** |   **170.49 μs** |  **9.345 μs** |  **16.291 μs** |  **10.511 μs** |  **28.79 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.63 μs |   168.24 μs |  9.222 μs |  88.445 μs |  72.996 μs |  89.45 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  31.98 μs |   250.93 μs | 13.754 μs |  26.188 μs |  22.061 μs |  47.68 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.69 μs |   152.79 μs |  8.375 μs |  15.059 μs |  10.941 μs |  27.06 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.12 μs |   240.06 μs | 13.159 μs |  45.075 μs |  43.993 μs |  67.31 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.30 μs |   184.57 μs | 10.117 μs |   7.699 μs |   7.227 μs |  24.98 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.35 μs |   280.06 μs | 15.351 μs |  27.541 μs |  27.441 μs |  54.08 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.57 μs** |   **272.74 μs** | **14.950 μs** |   **9.078 μs** |   **8.807 μs** |  **34.84 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 345.49 μs |   553.58 μs | 30.344 μs | 343.068 μs | 316.429 μs | 376.97 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 153.25 μs |    33.03 μs |  1.811 μs | 152.804 μs | 151.712 μs | 155.25 μs | 560.88 KB |
| ReverseXor             | 64     | 100    | 106.55 μs |   704.10 μs | 38.594 μs |  97.361 μs |  73.377 μs | 148.91 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 241.97 μs |   547.19 μs | 29.993 μs | 237.488 μs | 214.475 μs | 273.96 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  25.47 μs |   548.34 μs | 30.056 μs |   8.370 μs |   7.870 μs |  60.18 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 103.56 μs | 1,146.46 μs | 62.841 μs |  67.496 μs |  67.055 μs | 176.12 μs |  68.69 KB |

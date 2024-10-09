```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.07 μs** | **228.91 μs** | **12.548 μs** |  **11.332 μs** |  **10.340 μs** |  **32.55 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  76.42 μs | 158.77 μs |  8.703 μs |  74.038 μs |  69.149 μs |  86.06 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  44.00 μs | 380.05 μs | 20.832 μs |  36.492 μs |  27.957 μs |  67.54 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.39 μs | 147.54 μs |  8.087 μs |  15.008 μs |  10.761 μs |  26.40 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.35 μs | 248.47 μs | 13.620 μs |  44.502 μs |  44.472 μs |  68.08 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.69 μs | 201.45 μs | 11.042 μs |   7.355 μs |   7.275 μs |  26.44 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.71 μs | 301.77 μs | 16.541 μs |  29.115 μs |  27.231 μs |  56.78 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.49 μs** | **300.52 μs** | **16.473 μs** |   **9.217 μs** |   **8.746 μs** |  **37.51 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.87 μs | 277.40 μs | 15.205 μs | 301.671 μs | 286.764 μs | 317.17 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 158.49 μs | 115.87 μs |  6.351 μs | 159.489 μs | 151.695 μs | 164.28 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  85.29 μs | 272.49 μs | 14.936 μs |  82.415 μs |  71.996 μs | 101.45 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 239.83 μs | 539.84 μs | 29.590 μs | 236.223 μs | 212.208 μs | 271.06 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.24 μs | 205.65 μs | 11.272 μs |   7.955 μs |   7.504 μs |  27.25 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  96.30 μs | 833.81 μs | 45.704 μs |  70.703 μs |  69.139 μs | 149.07 μs |  68.69 KB |

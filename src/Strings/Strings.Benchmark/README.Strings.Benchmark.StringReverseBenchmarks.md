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
| **ArrayReverse**           | **10**     | **100**    |  **12.89 μs** | **167.55 μs** |  **9.184 μs** |   **7.743 μs** |   **7.433 μs** |  **23.49 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.93 μs | 242.46 μs | 13.290 μs |  77.475 μs |  71.434 μs |  96.87 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.23 μs | 258.00 μs | 14.142 μs |  26.048 μs |  22.232 μs |  48.41 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.15 μs | 166.88 μs |  9.147 μs |  14.908 μs |  11.060 μs |  28.47 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  58.27 μs | 307.25 μs | 16.841 μs |  51.126 μs |  46.176 μs |  77.50 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.38 μs | 216.15 μs | 11.848 μs |   7.745 μs |   7.343 μs |  28.06 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.72 μs | 281.92 μs | 15.453 μs |  27.872 μs |  27.722 μs |  54.56 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.53 μs** | **296.96 μs** | **16.277 μs** |   **9.217 μs** |   **9.037 μs** |  **37.32 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 299.92 μs | 293.73 μs | 16.100 μs | 296.685 μs | 285.684 μs | 317.39 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 169.29 μs |  34.71 μs |  1.903 μs | 170.058 μs | 167.124 μs | 170.69 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  71.85 μs | 279.63 μs | 15.327 μs |  68.087 μs |  58.750 μs |  88.70 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 240.15 μs | 490.12 μs | 26.865 μs | 236.181 μs | 215.483 μs | 268.77 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.77 μs | 263.52 μs | 14.444 μs |  10.559 μs |  10.299 μs |  35.45 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.32 μs | 567.45 μs | 31.104 μs |  68.677 μs |  68.058 μs | 122.24 μs |  68.69 KB |
